using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.DesktopUI.Views
{
    public partial class AddObjectivesToRunDialog : Form
    {
        private readonly IObjectiveRepository _objectiveRepository;
        private readonly int _projectId;
        private List<Objective> _objectivesToRun = new();

        public List<Objective> ObjectivesToRun { get { return _objectivesToRun; } }

        public AddObjectivesToRunDialog(IObjectiveRepository objectiveRepository, int projectId)
        {
            _objectiveRepository = objectiveRepository;
            _projectId = projectId;
            InitializeComponent();
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            using (ObjectivesDialog form = new ObjectivesDialog(_objectiveRepository, _projectId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (!_objectivesToRun.Contains(form.Objective))
                    {
                        _objectivesToRun.Add(form.Objective);
                        objective_screen.DataSource = _objectivesToRun;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Objective objective = null;
            if (objective_screen.SelectedRows.Count > 0)
            {
                objective = (Objective)objective_screen.SelectedRows[0].DataBoundItem;
            }
            else
            {
                objective = (Objective)objective_screen.Rows[objective_screen.SelectedCells[0].RowIndex].DataBoundItem;
            }

            if (objective != null)
            {
                if (_objectivesToRun.Contains(objective))
                {
                    _objectivesToRun.Remove(objective);
                    objective_screen.DataSource = _objectivesToRun;
                }
            }
        }

        private void run_bttn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            return;
        }
    }
}
