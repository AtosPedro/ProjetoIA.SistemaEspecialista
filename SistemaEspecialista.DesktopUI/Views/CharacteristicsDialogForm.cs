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
                textBox1.Text = _characteristic.Name;
                textBox2.Text = _characteristic.Description;
            }

        }
    }
}
