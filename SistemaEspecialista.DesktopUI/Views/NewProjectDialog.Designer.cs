namespace SistemaEspecialista.DesktopUI.Views
{
    partial class NewProjectDialog
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
            nameTextBox = new TextBox();
            descriptionTxtRBox = new RichTextBox();
            cancelButton = new Button();
            okButton = new Button();
            nameLbl = new Label();
            descriptionLbl = new Label();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(49, 64);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(306, 23);
            nameTextBox.TabIndex = 0;
            // 
            // descriptionTxtRBox
            // 
            descriptionTxtRBox.Location = new Point(49, 121);
            descriptionTxtRBox.Name = "descriptionTxtRBox";
            descriptionTxtRBox.Size = new Size(306, 96);
            descriptionTxtRBox.TabIndex = 1;
            descriptionTxtRBox.Text = "";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.Control;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(49, 238);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(146, 45);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // okButton
            // 
            okButton.Location = new Point(209, 238);
            okButton.Name = "okButton";
            okButton.Size = new Size(146, 45);
            okButton.TabIndex = 3;
            okButton.Text = "Confirmar";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(49, 46);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(98, 15);
            nameLbl.TabIndex = 4;
            nameLbl.Text = "Nome do Projeto";
            // 
            // descriptionLbl
            // 
            descriptionLbl.AutoSize = true;
            descriptionLbl.Location = new Point(49, 103);
            descriptionLbl.Name = "descriptionLbl";
            descriptionLbl.Size = new Size(116, 15);
            descriptionLbl.TabIndex = 5;
            descriptionLbl.Text = "Descrição do projeto";
            // 
            // NewProjectDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 295);
            Controls.Add(descriptionLbl);
            Controls.Add(nameLbl);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
            Controls.Add(descriptionTxtRBox);
            Controls.Add(nameTextBox);
            MaximumSize = new Size(437, 334);
            MinimumSize = new Size(437, 334);
            Name = "NewProjectDialog";
            Text = "Novo projeto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private RichTextBox descriptionTxtRBox;
        private Button cancelButton;
        private Button okButton;
        private Label nameLbl;
        private Label descriptionLbl;
    }
}