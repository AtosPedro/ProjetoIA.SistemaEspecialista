using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;

namespace SistemaEspecialista.DesktopUI.Views
{
    public partial class CharacteristicsDialogForm : Form
    {
        private ICharacteristicsRepository _characteristicsRepository;
        private readonly IQuestionRepository _questionRepository;
        private int _projectId;
        private Characteristic _characteristic;
        private Question _questionInMemory = null;

        public CharacteristicsDialogForm(
            ICharacteristicsRepository characteristicsRepository,
            IQuestionRepository questionRepository,
            int id,
            Characteristic characteristic = null)
        {
            _characteristicsRepository = characteristicsRepository;
            _projectId = id;
            _characteristic = characteristic ?? new();
            InitializeComponent();

            if (_characteristic.Id != DefaultValues.IdNullValue)
            {
                txtName.Text = _characteristic.Name;
                txtDescription.Text = _characteristic.Description;
                dgvQuestion.DataSource = new List<Question> { (_questionRepository.Search(qu => qu.CharacteristicId == _characteristic.Id, CancellationToken.None)).Result.FirstOrDefault() };
            }

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (_questionInMemory is not null)
            {
                return;
            }

            using (QuestionDialogForm form = new QuestionDialogForm(_projectId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _questionInMemory = form.Question;
                    dgvQuestion.DataSource = new List<Question> { _questionInMemory };
                }
            }
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            Question question = null;
            if (dgvQuestion.SelectedRows.Count > 0)
            {
                question = (Question)dgvQuestion.SelectedRows[0].DataBoundItem;
            }
            else
            {
                question = (Question)dgvQuestion.Rows[dgvQuestion.SelectedCells[0].RowIndex]?.DataBoundItem;
            }

            using (QuestionDialogForm form = new QuestionDialogForm(_projectId, question))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _questionInMemory = question;
                    dgvQuestion.DataSource = new List<Question> { _questionInMemory };
                }
            }
        }

        private async void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            Question question = null;
            if (dgvQuestion.SelectedRows.Count > 0)
            {
                question = (Question)dgvQuestion.SelectedRows[0].DataBoundItem;
            }
            else
            {
                question = (Question)dgvQuestion.Rows[dgvQuestion.SelectedCells[0].RowIndex].DataBoundItem;
            }

            if (question != null)
            {
                await _questionRepository.Remove(question);
                dgvQuestion.DataSource = new List<Question>();
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            _characteristic.ProjectId = _projectId;
            _characteristic.Name = txtName.Text;
            _characteristic.Name = txtDescription.Text;

            try
            {
                await _characteristicsRepository.Add(_characteristic, CancellationToken.None);

                if (_questionInMemory is not null)
                {
                    _questionInMemory.CharacteristicId = _characteristic.Id;
                    await _questionRepository.Add(_questionInMemory, CancellationToken.None);
                }

                this.DialogResult = DialogResult.OK;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
