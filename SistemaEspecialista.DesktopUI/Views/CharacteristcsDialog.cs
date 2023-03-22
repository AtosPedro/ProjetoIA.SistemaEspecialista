using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.DesktopUI.Views
{
    public partial class CharacteristcsDialog : Form
    {
        private readonly ICharacteristicsRepository _characteristicsRepository;
        public Characteristic Characteristic { get; set; }

        public CharacteristcsDialog(
            ICharacteristicsRepository characteristicsRepository,
            int projectId)
        {
            _characteristicsRepository = characteristicsRepository;
            InitializeComponent();
            var characteristicsList = (_characteristicsRepository.GetCharacteristicsByProjectAsync(projectId))?.Result;
            cmbCharacteristic.DataSource = characteristicsList ?? new List<Characteristic>();
            cmbCharacteristic.DisplayMember = "Name";
            cmbCharacteristic.ValueMember = "Id";
        }

        private void btnAddCharacteristic_Click(object sender, EventArgs e)
        {
            if (cmbCharacteristic.SelectedIndex != -1)
            {
                Characteristic = cmbCharacteristic.SelectedItem as Characteristic;
                this.DialogResult = DialogResult.OK;
                return;
            }
        }
    }
}
