using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.DesktopUI.Views
{
    public partial class QuestionDialogForm : Form
    {
        private int _projectId;
        public Question Question { get; set; }

        public QuestionDialogForm(int projectId, Question question = null)
        {
            _projectId = projectId;
            Question = question ?? new();
            InitializeComponent();

            if (Question is not null)
            {
                txtTitle.Text = Question.Title;
                txtDescription.Text = Question.Description;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Question.ProjectId = _projectId;
            Question.Title = txtTitle.Text;
            Question.Description = txtDescription.Text;

            if (String.IsNullOrEmpty(Question.Title) || 
                String.IsNullOrEmpty(Question.Description))
            {
                MessageBox.Show(this, "Preencha todos os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = DialogResult.OK;

            return;
        }
    }
}
