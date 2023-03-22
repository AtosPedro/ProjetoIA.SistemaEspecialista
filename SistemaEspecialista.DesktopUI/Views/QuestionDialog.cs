using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;

namespace SistemaEspecialista.DesktopUI.Views
{
    public partial class QuestionDialog : Form
    {
        public Characteristic Characteristic { get; set; }
        public QuestionDialog(Characteristic characteristic)
        {
            Characteristic = characteristic;
            InitializeComponent();
            pgt_assoc.Text = characteristic.Question.Description;
            title_assoc.Text = characteristic.Question.Title;
        }

        private void continue_bttn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            return;
        }

        private void true_bttn_Click(object sender, EventArgs e)
        {
            Characteristic.Status = DefaultValues.Active;
        }

        private void false_bttn_Click(object sender, EventArgs e)
        {
            Characteristic.Status = DefaultValues.Inactive;
        }
    }
}
