using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;
using SistemaEspecialista.Domain.Utils;

namespace SistemaEspecialista.DesktopUI.Views;

public partial class NewProjectDialog : Form
{
    private readonly IProjectRepository _projectRepository;

    public Project Project { get; set; } = new();

    public NewProjectDialog(IProjectRepository projectRepository, Project project = null)
    {
        InitializeComponent();
        _projectRepository = projectRepository;

        if (project!= null)
        {
            Project = project;
            nameTextBox.Text = Project.Name;
            descriptionTxtRBox.Text = Project.Name;
        }
    }

    private async void okButton_Click(object sender, EventArgs e)
    {

        Project.Name = nameTextBox.Text.Trim();
        Project.Description = descriptionTxtRBox.Text;

        if (String.IsNullOrEmpty(Project.Name) ||
            String.IsNullOrEmpty(Project.Description))
        {
            MessageBox.Show(this, "Preencha todos os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        if (Project.Id == DefaultValues.IdNullValue)
        {
            await _projectRepository.Add(Project, CancellationToken.None);
        }
        else
        {
            await _projectRepository.Update(Project);
        }

        this.DialogResult = DialogResult.OK;
    }
}
