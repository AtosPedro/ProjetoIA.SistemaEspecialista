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
            InitializeComponent();

            cmbCharacteristic.DataSource = (_characteristicsRepository.GetCharacteristicsByProjectAsync(projectId))?.Result?.ToList();
            _characteristicsRepository = characteristicsRepository;
        }

        private void btnAddCharacteristic_Click(object sender, EventArgs e)
        {
            if (cmbCharacteristic.SelectedIndex != -1)
            {
                Characteristic = cmbCharacteristic.SelectedItem as Characteristic;
            }
        }
    }
}
