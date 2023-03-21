using Microsoft.Extensions.DependencyInjection;
using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.DesktopView;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;
using SistemaEspecialista.Infrastructure.Repositories;

namespace SistemaEspecialista.DesktopUI.Views;

public partial class MainForm : Form
{
    private readonly IProjectRepository _projectRepository;
    private readonly IObjectiveRepository _objectiveRepository;
    private readonly ICharacteristicsRepository _characteristicsRepository;
    private readonly IObjectiveCharacteristicRepository _objectiveCharacteristicRepository;
    private readonly IQuestionRepository _questionRepository;

    public Project LoadedProject { get; set; }

    public MainForm()
    {
        _projectRepository = Program.ServiceProvider.GetRequiredService<IProjectRepository>();
        _objectiveRepository = Program.ServiceProvider.GetRequiredService<IObjectiveRepository>();
        _characteristicsRepository = Program.ServiceProvider.GetRequiredService<ICharacteristicsRepository>();
        _objectiveCharacteristicRepository = Program.ServiceProvider.GetRequiredService<IObjectiveCharacteristicRepository>();
        _questionRepository = Program.ServiceProvider.GetRequiredService<IQuestionRepository>();

        LoadedProject = _projectRepository.GetAll(CancellationToken.None)?.Result?.LastOrDefault();
        InitializeComponent();
        Text = $"{AppConstants.AppTitle} ({LoadedProject.Name})";
    }

    #region Menu

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (NewProjectDialog form = new NewProjectDialog(_projectRepository))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadedProject = form.Project;
                Text = $"{AppConstants.AppTitle} ({LoadedProject.Name})";
            }
        }
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        using (ProjectsListDialog form = new ProjectsListDialog(_projectRepository))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadedProject = form.Project;
                Text = $"{AppConstants.AppTitle} ({LoadedProject.Name})";
            }
        }
    }

    private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void manualToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void devsToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    #endregion

    #region Objectives Tab

    private async void addObjectiveButton_Click(object sender, EventArgs e)
    {
        using (ObjectiveDialogForm form = new ObjectiveDialogForm(_objectiveRepository, LoadedProject.Id))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvObjective.DataSource = await _objectiveRepository.GetObjectivesByProjectAsync(LoadedProject.Id);
            }
        }
    }

    private async void editObjectiveButton_Click(object sender, EventArgs e)
    {
        Objective objective = null;
        if (dgvObjective.SelectedRows.Count > 0)
        {
            objective = (Objective)dgvObjective.SelectedRows[0].DataBoundItem;
        }
        else
        {
            objective = (Objective)dgvObjective.Rows[dgvObjective.SelectedCells[0].RowIndex].DataBoundItem;
        }

        if (objective != null)
        {
            using (ObjectiveDialogForm form = new ObjectiveDialogForm(_objectiveRepository, LoadedProject.Id, objective))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    dgvObjective.DataSource = await _objectiveRepository.GetObjectivesByProjectAsync(LoadedProject.Id);
                }
            }
        }
    }

    private async void deleteObjectiveButton_Click(object sender, EventArgs e)
    {
        Objective objective = null;
        if (dgvObjective.SelectedRows.Count > 0)
        {
            objective = (Objective)dgvObjective.SelectedRows[0].DataBoundItem;
        }
        else
        {
            objective = (Objective)dgvObjective.Rows[dgvObjective.SelectedCells[0].RowIndex].DataBoundItem;
        }

        if (objective != null)
        {
            await _objectiveRepository.Remove(objective);
            dgvObjective.DataSource = await _objectiveRepository.GetObjectivesByProjectAsync(LoadedProject.Id);
        }
    }

    private async void refreshObjectiveListButton_Click(object sender, EventArgs e)
    {
        dgvObjective.DataSource = await _objectiveRepository.GetObjectivesByProjectAsync(LoadedProject.Id);
    }

    #endregion

    #region Characteristics Tab

    private async void refreshCharacteristicsListButton_Click(object sender, EventArgs e)
    {
        dgvCharacteristics.DataSource = await _characteristicsRepository.GetCharacteristicsByProjectAsync(LoadedProject.Id);
    }

    private async void addCharacteristicButton_Click(object sender, EventArgs e)
    {
        using (CharacteristicsDialogForm form = new CharacteristicsDialogForm(_characteristicsRepository, _questionRepository, LoadedProject.Id))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvCharacteristics.DataSource = await _characteristicsRepository.GetCharacteristicsByProjectAsync(LoadedProject.Id);
            }
        }
    }

    private async void editCharacteristicButton_Click(object sender, EventArgs e)
    {
        Characteristic characteristic = null;
        if (dgvObjective.SelectedRows.Count > 0)
        {
            characteristic = (Characteristic)dgvCharacteristics.SelectedRows[0].DataBoundItem;
        }
        else
        {
            characteristic = (Characteristic)dgvCharacteristics?.Rows[dgvObjective?.SelectedCells[0]?.RowIndex ?? 0]?.DataBoundItem;
        }

        using (CharacteristicsDialogForm form = new CharacteristicsDialogForm(_characteristicsRepository, _questionRepository, LoadedProject.Id, characteristic))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvCharacteristics.DataSource = await _characteristicsRepository.GetCharacteristicsByProjectAsync(LoadedProject.Id);
            }
        }
    }

    private async void deleteCharacteristicButton_Click(object sender, EventArgs e)
    {
        Characteristic characteristic = null;
        if (dgvObjective.SelectedRows.Count > 0)
        {
            characteristic = (Characteristic)dgvCharacteristics.SelectedRows[0].DataBoundItem;
        }
        else
        {
            characteristic = (Characteristic)dgvCharacteristics.Rows[dgvObjective.SelectedCells[0].RowIndex].DataBoundItem;
        }

        if (characteristic != null)
        {
            await _characteristicsRepository.Remove(characteristic);
            dgvObjective.DataSource = await _objectiveRepository.GetObjectivesByProjectAsync(LoadedProject.Id);
        }
    }

    #endregion

    private async void characteristicPage_Click(object sender, EventArgs e)
    {
        dgvCharacteristics.DataSource = await _characteristicsRepository.GetCharacteristicsByProjectAsync(LoadedProject.Id);
    }

    private async void objectivePage_Click(object sender, EventArgs e)
    {
        dgvObjective.DataSource = await _objectiveRepository.GetObjectivesByProjectAsync(LoadedProject.Id);
    }
}
