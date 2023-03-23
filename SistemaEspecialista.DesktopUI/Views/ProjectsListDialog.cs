using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;

namespace SistemaEspecialista.DesktopUI.Views;

public partial class ProjectsListDialog : Form
{
    public Project Project { get; set; }
    public Project LoadedProject { get; set; }

    private readonly IProjectRepository _projectRepository;

    public ProjectsListDialog(IProjectRepository projectRepository)
    {
        InitializeComponent();
        _projectRepository = projectRepository;
        InitializeDialog();
    }

    public async void InitializeDialog()
    {
        dgvProjects.DataSource = await _projectRepository.GetAll(CancellationToken.None);
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        try
        {
            if ((dgvProjects.DataSource as List<Project>).Any())
            {
                if (dgvProjects.SelectedRows.Count > 0)
                {
                    Project = (Project)dgvProjects.SelectedRows[0].DataBoundItem;
                }
                else
                {
                    Project = (Project)dgvProjects.Rows[dgvProjects.SelectedCells[0].RowIndex].DataBoundItem;
                }

                if (Project is null)
                {
                    this.DialogResult = DialogResult.None;
                    MessageBox.Show(this, "Selecione um projeto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.DialogResult = DialogResult.OK;
                return;
            }
        }
        catch (Exception ex)
        {
            this.DialogResult = DialogResult.Cancel;
            MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnEditProject_Click(object sender, EventArgs e)
    {
        try
        {
            if ((dgvProjects.DataSource as List<Project>).Any())
            {
                if (dgvProjects.SelectedRows.Count > 0)
                {
                    Project = (Project)dgvProjects.SelectedRows[0].DataBoundItem;
                }
                else
                {
                    Project = (Project)dgvProjects.Rows[dgvProjects.SelectedCells[0].RowIndex].DataBoundItem;
                }
                using (NewProjectDialog form = new NewProjectDialog(_projectRepository, Project))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        dgvProjects.DataSource = await _projectRepository.GetAll(CancellationToken.None);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDeleteProject_Click(object sender, EventArgs e)
    {
        try
        {
            if ((dgvProjects.DataSource as List<Project>).Any())
            {
                if (dgvProjects.SelectedRows.Count > 0)
                {
                    Project = (Project)dgvProjects.SelectedRows[0].DataBoundItem;
                }
                else
                {
                    Project = (Project)dgvProjects.Rows[dgvProjects.SelectedCells[0].RowIndex].DataBoundItem;
                }

                if (Project != null)
                {
                    await _projectRepository.Remove(Project);
                    System.Windows.Forms.Application.Restart();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
