using SistemaEspecialista.Application.Interfaces.Repositories;
using SistemaEspecialista.Domain.Entities;

namespace SistemaEspecialista.DesktopUI.Views;

public partial class NewProjectDialog : Form
{
    private readonly IProjectRepository _projectRepository;

    public Project Project { get; set; }

    public NewProjectDialog(IProjectRepository projectRepository)
    {
        InitializeComponent();
        _projectRepository = projectRepository;
    }

    private async void okButton_Click(object sender, EventArgs e)
    {
        Project = new Project
        {
            Name = nameTextBox.Text.Trim(),
            Description = descriptionTxtRBox.Text,
        };

        await _projectRepository.Add(Project, CancellationToken.None);

        this.DialogResult = DialogResult.OK;
    }
}
