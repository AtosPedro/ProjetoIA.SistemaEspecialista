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
        if (LoadedProject is not null)
        {
            Text = $"{AppConstants.AppTitle} ({LoadedProject?.Name})";

            dgvObjective.DataSource = _objectiveRepository.GetObjectivesByProjectAsync(LoadedProject.Id).Result;
            dgvCharacteristics.DataSource = _characteristicsRepository.GetCharacteristicsByProjectAsync(LoadedProject.Id).Result;
        }
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

    private void manualToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show(this, "Um Sistema Especialista é um sistema que utiliza o conhecimento humano capturado num computador para resolver problemas que normalmente seriam resolvidos por especialistas humanos. Os sistemas bem concebidos imitam o processo de raciocínio que os especialistas utilizam para resolver problemas específicos.\n\n\n"
                              + "Características - crie perguntas que serão feitas ao usuario, podem ser numericas, univaloradas ou multivaloradas a partir dessa seleção.\n\n"
                              + "Objetivos - crie valores que serão resultados de uma condição aplicada pelas variaveis a partir dessa seleção.\n\n"
                              + "Pergunta - Substitua o texto das variáveis apresentadas na tela do usuario através dessa seleção.\n\n", "Manual", MessageBoxButtons.OK);
    }

    private void devsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show(this, @"Atos Pedro, Leonardo Lamas,André Amorim,Tiago Morel", "Manual", MessageBoxButtons.OK);
    }

    #endregion

    #region Objectives Tab

    private async void addObjectiveButton_Click(object sender, EventArgs e)
    {
        using (ObjectiveDialogForm form = new ObjectiveDialogForm(
            _objectiveRepository,
            _objectiveCharacteristicRepository,
            _characteristicsRepository,
            LoadedProject.Id))
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
            using (ObjectiveDialogForm form = new ObjectiveDialogForm(
                _objectiveRepository,
            _objectiveCharacteristicRepository,
            _characteristicsRepository,
            LoadedProject.Id,
            objective))
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
            if (LoadedProject is not null)
            {
                dgvObjective.DataSource = await _objectiveRepository.GetObjectivesByProjectAsync(LoadedProject.Id);
            }
        }
    }

    private async void refreshObjectiveListButton_Click(object sender, EventArgs e)
    {
        if (LoadedProject is not null)
        {
            dgvObjective.DataSource = await _objectiveRepository.GetObjectivesByProjectAsync(LoadedProject.Id);
        }
    }

    #endregion

    #region Characteristics Tab

    private async void refreshCharacteristicsListButton_Click(object sender, EventArgs e)
    {
        if (LoadedProject is not null)
        {
            dgvCharacteristics.DataSource = await _characteristicsRepository.GetCharacteristicsByProjectAsync(LoadedProject.Id);
        }
    }

    private async void addCharacteristicButton_Click(object sender, EventArgs e)
    {
        using (CharacteristicsDialogForm form = new CharacteristicsDialogForm(_characteristicsRepository, _questionRepository, LoadedProject.Id))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (LoadedProject is not null)
                {
                    dgvCharacteristics.DataSource = await _characteristicsRepository.GetCharacteristicsByProjectAsync(LoadedProject.Id);
                }
            }
        }
    }

    private async void editCharacteristicButton_Click(object sender, EventArgs e)
    {
        Characteristic characteristic = null;

        if ((dgvCharacteristics.DataSource as List<Characteristic>).Any())
        {
            if (dgvObjective.SelectedRows.Count > 0)
            {
                characteristic = (Characteristic)dgvCharacteristics.SelectedRows[0].DataBoundItem;
            }
            else
            {
                int rowindex = dgvCharacteristics.SelectedCells[0].RowIndex;
                if (rowindex > -1)
                    characteristic = (Characteristic)dgvCharacteristics?.Rows[rowindex]?.DataBoundItem;
            }

            if (characteristic is not null)
            {
                using (CharacteristicsDialogForm form = new CharacteristicsDialogForm(_characteristicsRepository, _questionRepository, LoadedProject.Id, characteristic))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (LoadedProject is not null)
                        {
                            dgvCharacteristics.DataSource = await _characteristicsRepository.GetCharacteristicsByProjectAsync(LoadedProject.Id);
                        }
                    }
                }
            }
        }
    }

    private async void deleteCharacteristicButton_Click(object sender, EventArgs e)
    {
        Characteristic characteristic = null;

        if ((dgvCharacteristics.DataSource as List<Characteristic>)?.Any() ?? false)
        {
            if (dgvCharacteristics.SelectedRows.Count > 0)
            {
                characteristic = (Characteristic)dgvCharacteristics.SelectedRows[0].DataBoundItem;
            }
            else
            {
                characteristic = (Characteristic)dgvCharacteristics.Rows[dgvCharacteristics.SelectedCells[0].RowIndex].DataBoundItem;
            }

            if (characteristic != null)
            {
                await _characteristicsRepository.Remove(characteristic);
                if (LoadedProject is not null)
                {
                    dgvCharacteristics.DataSource = await _objectiveRepository.GetObjectivesByProjectAsync(LoadedProject.Id);
                }
            }
        }

    }

    #endregion

    private async void characteristicPage_Click(object sender, EventArgs e)
    {
        if (LoadedProject is not null)
        {
            dgvCharacteristics.DataSource = await _characteristicsRepository.GetCharacteristicsByProjectAsync(LoadedProject.Id);
        }
    }

    private async void objectivePage_Click(object sender, EventArgs e)
    {
        if (LoadedProject is not null)
        {
            dgvObjective.DataSource = await _objectiveRepository.GetObjectivesByProjectAsync(LoadedProject.Id);
        }
    }

    private async void runBtn_Click(object sender, EventArgs e)
    {
        using (AddObjectivesToRunDialog form = new AddObjectivesToRunDialog(_objectiveRepository, LoadedProject.Id))
        {
            if (form.ShowDialog() == DialogResult.OK)
            {
                var characteristics = new List<Characteristic>();
                foreach (var objective in form.ObjectivesToRun)
                {
                    var characteristicsByObjective = (await _objectiveCharacteristicRepository.GetWithCharacteristics(obc => obc.ObjectiveId == objective.Id)).Select(w => w.Characteristic);
                    foreach (var chara in characteristicsByObjective)
                    {
                        if (!characteristics.Where(c => c.Id == chara.Id).Any())
                        {
                            characteristics.Add(chara);
                        }
                    }
                }

                foreach (var characteristic in characteristics)
                {
                    characteristic.Question = (await _questionRepository.Search(w => w.CharacteristicId == characteristic.Id, CancellationToken.None)).FirstOrDefault();
                    using (QuestionDialog questionForm = new QuestionDialog(characteristic))
                    {
                        if (questionForm.ShowDialog() == DialogResult.OK)
                        {
                            characteristic.Status = questionForm.Characteristic.Status;
                        }
                    }
                }

                Dictionary<string, int> pontuation = new Dictionary<string, int>();

                foreach (var objective in form.ObjectivesToRun)
                {
                    pontuation.Add(objective.Name, 0);
                    var characteristicsByObjective = (await _objectiveCharacteristicRepository.GetWithCharacteristics(obc => obc.ObjectiveId == objective.Id)).Select(w => w.Characteristic);
                    foreach (var item in characteristicsByObjective)
                    {
                        var characteristicModified = characteristics.Where(w => w.Id == item.Id).FirstOrDefault();
                        if (characteristicModified is not null)
                        {
                            pontuation[objective.Name] += characteristicModified.Status == DefaultValues.Active ? 1 : 0;
                        }
                    }
                }

                var winner = pontuation.Where(w => w.Value == pontuation.Values.Max()).Select(w => w.Key).ToArray();
                string winnerStr = string.Join(", ", winner);

                MessageBox.Show(this, $"O resultado é {winnerStr}", "", MessageBoxButtons.OK);
            }
        }
    }
}
