using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;
using System.Reflection.PortableExecutable;

namespace SistemaEspecialista.DesktopUI.Views
{
    public partial class ObjectiveDialogForm : Form
    {
        public Objective Objective { get; set; }
        public int ProjectId { get; set; }

        private readonly IObjectiveRepository _objectiveRepository;
        private readonly IObjectiveCharacteristicRepository _objectiveCharacteristicRepository;
        private readonly ICharacteristicsRepository _characteristicRepository;

        private List<Characteristic> _characteristicsInMemory = new();

        public ObjectiveDialogForm(
            IObjectiveRepository objectiveRepository,
            IObjectiveCharacteristicRepository objectiveCharacteristicRepository,
            ICharacteristicsRepository characteristicRepository,
            int projectId,
            Objective objective = null)
        {
            _objectiveRepository = objectiveRepository;
            _objectiveCharacteristicRepository = objectiveCharacteristicRepository;
            _characteristicRepository = characteristicRepository;

            ProjectId = projectId;
            Objective = objective ?? new();

            InitializeComponent();

            if (objective != null)
            {
                var obJectiveCharacteristics = (_objectiveCharacteristicRepository.GetWithCharacteristics(w => w.ObjectiveId == objective.Id)).Result;
                txtObjectiveName.Text = objective.Name;
                txtObjectiveDescription.Text = objective.Description;
                dataGridView1.DataSource = obJectiveCharacteristics.Select(w => w.Characteristic).ToList();
            }
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
                    await _objectiveRepository.Add(
                        Objective,
                        CancellationToken.None);
                }
                else
                {
                    await _objectiveRepository.Update(Objective);
                }

                if (_characteristicsInMemory.Any())
                {
                    foreach (var characteristic in _characteristicsInMemory)
                    {
                        var dbObjectiveCharacteristic = (await _objectiveCharacteristicRepository.Search(obc =>
                            obc.CharacteristicId == characteristic.Id &&
                            obc.ObjectiveId == Objective.Id &&
                            obc.ProjectId == ProjectId, CancellationToken.None)).FirstOrDefault();

                        if (dbObjectiveCharacteristic != null)
                            continue;

                        var objectiveCharacteristic = new ObjectiveCharacteristic
                        {
                            ProjectId = ProjectId,
                            CharacteristicId = characteristic.Id,
                            ObjectiveId = Objective.Id
                        };

                        await _objectiveCharacteristicRepository.Add(
                            objectiveCharacteristic,
                            CancellationToken.None);
                    }
                }

                this.DialogResult = DialogResult.OK;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.DialogResult = DialogResult.Cancel;
        }

        private async void btnAddCharacteristic_Click(object sender, EventArgs e)
        {
            using (CharacteristcsDialog form = new CharacteristcsDialog(_characteristicRepository, ProjectId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var dbObjectiveCharacteristic = (await _objectiveCharacteristicRepository.Search(obc =>
                            obc.CharacteristicId == form.Characteristic.Id &&
                            obc.ObjectiveId == Objective.Id &&
                            obc.ProjectId == ProjectId, CancellationToken.None)).FirstOrDefault();

                    if (!_characteristicsInMemory.Where(cr => form.Characteristic.Id == cr.Id).Any() && dbObjectiveCharacteristic is null)
                        _characteristicsInMemory.Add(form.Characteristic);

                    var characteristicsFromThisObjective = (await _objectiveCharacteristicRepository.GetWithCharacteristics(obc =>
                            obc.ObjectiveId == Objective.Id &&
                            obc.ProjectId == ProjectId)).Select(obc => obc.Characteristic).ToList();

                    foreach (var characteristic in _characteristicsInMemory)
                    {
                        characteristicsFromThisObjective.Add(characteristic);
                    }

                    dataGridView1.DataSource = new List<Characteristic>();
                    dataGridView1.DataSource = characteristicsFromThisObjective;
                }
            }
        }

        private async void btnDeleteCharacteristic_Click(object sender, EventArgs e)
        {
            Characteristic characteristic = null;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                characteristic = (Characteristic)dataGridView1.SelectedRows[0].DataBoundItem;
            }
            else
            {
                characteristic = (Characteristic)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex]?.DataBoundItem;
            }

            if (characteristic is null)
                return;

            if (characteristic.Id == DefaultValues.IdNullValue)
            {
                if (_characteristicsInMemory.Contains(characteristic))
                    _characteristicsInMemory.Remove(characteristic);
            }
            else
            {
                var objectiveCharacteristic = (await _objectiveCharacteristicRepository.Search(obc =>
                    obc.CharacteristicId == characteristic.Id &&
                    obc.ObjectiveId == Objective.Id,
                    CancellationToken.None)).FirstOrDefault();

                if (objectiveCharacteristic is not null)
                    await _objectiveCharacteristicRepository.Remove(objectiveCharacteristic);
            }

            var characteristics = (await _objectiveCharacteristicRepository.Search(obc =>
            obc.ObjectiveId == Objective.Id,
            CancellationToken.None)).ToList();
            var dbCharacteristics = characteristics.Select(obc => obc.Characteristic).ToList();

            foreach (var c in _characteristicsInMemory)
                dbCharacteristics.Add(c);

            dataGridView1.DataSource = dbCharacteristics;
        }
    }
}
