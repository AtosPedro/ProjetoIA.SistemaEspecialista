using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.DesktopUI.Views
{
    public partial class QuestionDialogForm : Form
    {
        private  int _projectId;
        public Question Question { get; set; }

        public QuestionDialogForm(int projectId, Question question = null)
        {
            _projectId = projectId;
            Question = question;
            InitializeComponent();

            if (Question is not null)
            {
                txtTitle.Text = Question.Title;
                txtDescription.Text = Question.Description;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Question = new();
            Question.ProjectId = _projectId;
            Question.Title = txtTitle.Text;
            Question.Description = txtDescription.Text;

            this.DialogResult = DialogResult.OK;

            return;
        }
    }
}
