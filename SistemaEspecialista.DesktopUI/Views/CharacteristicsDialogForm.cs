using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;
using SistemaEspecialista.Infrastructure.Repositories;
using System.Reflection.PortableExecutable;

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
            _questionRepository = questionRepository;
            _projectId = id;
            _characteristic = characteristic ?? new();
            InitializeComponent();

            if (_characteristic.Id != DefaultValues.IdNullValue)
            {
                txtName.Text = _characteristic.Name;
                txtDescription.Text = _characteristic.Description;
                dgvQuestion.DataSource = (_questionRepository.Search(qu => qu.CharacteristicId == _characteristic.Id, CancellationToken.None)).Result.ToList();
            }
            else
            {
                dgvQuestion.DataSource = new List<Question>();
            }

        }

        private async void btnAddQuestion_Click(object sender, EventArgs e)
        {
            var question = (await _questionRepository.Search(w =>
                w.CharacteristicId == _characteristic.Id &&
                w.ProjectId == _projectId, CancellationToken.None));

            if (_questionInMemory is not null || question.Any())
            {
                MessageBox.Show(
                    this,
                    "Não é possível ter mais de uma pergunta para a mesma característica",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

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
                var dbQuestions = await _questionRepository.Search(qu =>
                qu.CharacteristicId == _characteristic.Id &&
                _characteristic.Id != DefaultValues.IdNullValue, CancellationToken.None);

                if (dbQuestions.Where(dbq => dbq.Id == question.Id).Any())
                {
                    question.CharacteristicId = DefaultValues.IdNullValue;
                    _questionInMemory = null;
                    await _questionRepository.Remove(question);
                }
                else
                {
                    _questionInMemory = null;
                    question = null;
                }

                dgvQuestion.DataSource = new List<Question>();
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            _characteristic.ProjectId = _projectId;
            _characteristic.Name = txtName.Text;
            _characteristic.Description = txtDescription.Text;

            if (String.IsNullOrEmpty(_characteristic.Name) ||
                String.IsNullOrEmpty(_characteristic.Description))
            {
                MessageBox.Show(this, "Preencha todos os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var question = await _questionRepository.Search(w =>
                w.CharacteristicId == _characteristic.Id &&
                w.ProjectId == _projectId, CancellationToken.None);

            if (_questionInMemory is null && !question.Any())
            {
                MessageBox.Show(
                    this,
                    "É necessário criar uma pergunta para a característica para salva=la.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            try
            {

                if (_characteristic.Id == DefaultValues.IdNullValue)
                {
                    await _characteristicsRepository.Add(_characteristic, CancellationToken.None);
                }
                else
                {
                    await _characteristicsRepository.Update(_characteristic);
                }

                if (_questionInMemory is not null)
                {
                    _questionInMemory.CharacteristicId = _characteristic.Id;
                    if (_questionInMemory.Id == DefaultValues.IdNullValue)
                    {
                        await _questionRepository.Add(_questionInMemory, CancellationToken.None);
                    }
                    else
                    {

                        await _questionRepository.Update(_questionInMemory);
                    }

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
