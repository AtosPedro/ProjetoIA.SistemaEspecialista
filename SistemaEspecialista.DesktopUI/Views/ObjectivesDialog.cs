using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.DesktopUI.Views
{
    public partial class ObjectivesDialog : Form
    {
        private readonly IObjectiveRepository _objectiveRepository;

        public Objective Objective { get; set; }
        public ObjectivesDialog(IObjectiveRepository objectiveRepository, int projectId)
        {
            InitializeComponent();

            cmbObjective.DataSource = (_objectiveRepository.GetObjectivesByProjectAsync(projectId))?.Result?.ToList();
            _objectiveRepository = objectiveRepository;
        }

        private void btnAddObjective_Click(object sender, EventArgs e)
        {
            if (cmbObjective.SelectedIndex == -1)
            {
                Objective = cmbObjective.SelectedItem as Objective;
            }
        }
    }
}
