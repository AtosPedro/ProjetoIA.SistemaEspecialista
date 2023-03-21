using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;

namespace SistemaEspecialista.DesktopUI.Views
{
    public partial class ObjectiveDialogForm : Form
    {
        public Objective Objective { get; set; }

        private readonly IObjectiveRepository _objectiveRepository;

        public int ProjectId { get; set; }

        public ObjectiveDialogForm(IObjectiveRepository objectiveRepository, int projectId)
        {
            Objective = new();
            _objectiveRepository = objectiveRepository;
            ProjectId = projectId;
            InitializeComponent();
        }

        private async void saveObjectiveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Objective.ProjectId = ProjectId;
                Objective.Name = txtObjectiveName.Text.Trim();
                Objective.Description = txtObjectiveDescription.Text.Trim();

                if (Objective.Id == DefaultValues.IdNullValue)
                {
                    await _objectiveRepository.Add(Objective, CancellationToken.None);
                }
                else
                {
                    await _objectiveRepository.Update(Objective);
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.DialogResult = DialogResult.Cancel;
        }
    }
}
