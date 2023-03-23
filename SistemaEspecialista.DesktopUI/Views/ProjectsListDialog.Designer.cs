namespace SistemaEspecialista.DesktopUI.Views
{
    partial class ProjectsListDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dgvProjects = new DataGridView();
            label1 = new Label();
            cancelButton = new Button();
            okButton = new Button();
            projectNameLbl = new Label();
            btnEditProject = new Button();
            btnDeleteProject = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvProjects);
            panel1.Location = new Point(12, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(515, 163);
            panel1.TabIndex = 0;
            // 
            // dgvProjects
            // 
            dgvProjects.AllowUserToAddRows = false;
            dgvProjects.AllowUserToDeleteRows = false;
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Location = new Point(0, 0);
            dgvProjects.MultiSelect = false;
            dgvProjects.Name = "dgvProjects";
            dgvProjects.ReadOnly = true;
            dgvProjects.Size = new Size(515, 163);
            dgvProjects.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 30);
            label1.TabIndex = 1;
            label1.Text = "Selecione um projeto";
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(12, 289);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(150, 50);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.Location = new Point(377, 289);
            okButton.Name = "okButton";
            okButton.Size = new Size(150, 50);
            okButton.TabIndex = 3;
            okButton.Text = "Confirmar";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // projectNameLbl
            // 
            projectNameLbl.AutoSize = true;
            projectNameLbl.Location = new Point(12, 289);
            projectNameLbl.Name = "projectNameLbl";
            projectNameLbl.Size = new Size(0, 15);
            projectNameLbl.TabIndex = 4;
            // 
            // btnEditProject
            // 
            btnEditProject.Location = new Point(12, 226);
            btnEditProject.Name = "btnEditProject";
            btnEditProject.Size = new Size(150, 28);
            btnEditProject.TabIndex = 5;
            btnEditProject.Text = "Editar Projeto";
            btnEditProject.UseVisualStyleBackColor = true;
            btnEditProject.Click += btnEditProject_Click;
            // 
            // btnDeleteProject
            // 
            btnDeleteProject.Location = new Point(377, 226);
            btnDeleteProject.Name = "btnDeleteProject";
            btnDeleteProject.Size = new Size(150, 28);
            btnDeleteProject.TabIndex = 6;
            btnDeleteProject.Text = "Deletar projeto";
            btnDeleteProject.UseVisualStyleBackColor = true;
            btnDeleteProject.Click += btnDeleteProject_Click;
            // 
            // ProjectsListDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 355);
            Controls.Add(btnDeleteProject);
            Controls.Add(btnEditProject);
            Controls.Add(projectNameLbl);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximumSize = new Size(555, 394);
            MinimumSize = new Size(555, 394);
            Name = "ProjectsListDialog";
            Text = "Editar";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button cancelButton;
        private Button okButton;
        private DataGridView dgvProjects;
        private Label projectNameLbl;
        private Button btnEditProject;
        private Button btnDeleteProject;
    }
}