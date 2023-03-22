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
            _objectiveRepository = objectiveRepository;
            InitializeComponent();
            cmbObjective.DataSource = (_objectiveRepository.GetObjectivesByProjectAsync(projectId))?.Result?.ToList();
            cmbObjective.DisplayMember = "Name";
            cmbObjective.ValueMember = "Id";
        }

        private void btnAddObjective_Click(object sender, EventArgs e)
        {
            if (cmbObjective.SelectedIndex != -1)
            {
                Objective  = cmbObjective.SelectedItem as Objective;
            }

            this.DialogResult = DialogResult.OK;
            return;
        }
    }
}
