using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.DesktopUI.Views
{
    public partial class CharacteristicsDialogForm : Form
    {
        private ICharacteristicsRepository _characteristicsRepository;
        private int _projectId;
        private Characteristic _characteristic;

        public CharacteristicsDialogForm(ICharacteristicsRepository characteristicsRepository, int id, Characteristic characteristic = null)
        {
            _characteristicsRepository = characteristicsRepository;
            _projectId = id;
            _characteristic = characteristic;

            InitializeComponent();
        }
    }
}
