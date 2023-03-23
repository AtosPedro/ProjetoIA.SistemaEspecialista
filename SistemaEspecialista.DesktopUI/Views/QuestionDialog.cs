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
            title_assoc.Text = characteristic.Question.Title;
        }

        private void continue_bttn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            return;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                Characteristic.Status = DefaultValues.Active;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                Characteristic.Status = DefaultValues.Inactive;
            }
        }

        private void btnExplanation_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                this,
                Characteristic.Question.Description,
                "Porque essa pergunta é feita?",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
