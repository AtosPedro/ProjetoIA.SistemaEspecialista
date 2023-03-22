namespace SistemaEspecialista.DesktopUI.Views
{
    partial class ObjectivesDialog
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
            cmbObjective = new ComboBox();
            btnAddObjective = new Button();
            SuspendLayout();
            // 
            // cmbObjective
            // 
            cmbObjective.FormattingEnabled = true;
            cmbObjective.Location = new Point(12, 36);
            cmbObjective.Name = "cmbObjective";
            cmbObjective.Size = new Size(335, 23);
            cmbObjective.TabIndex = 1;
            // 
            // btnAddObjective
            // 
            btnAddObjective.Location = new Point(394, 18);
            btnAddObjective.Name = "btnAddObjective";
            btnAddObjective.Size = new Size(143, 56);
            btnAddObjective.TabIndex = 2;
            btnAddObjective.Text = "Adicionar";
            btnAddObjective.UseVisualStyleBackColor = true;
            btnAddObjective.Click += btnAddObjective_Click;
            // 
            // ObjectivesDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 108);
            Controls.Add(btnAddObjective);
            Controls.Add(cmbObjective);
            Name = "ObjectivesDialog";
            Text = "Adicionar Objetivo";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbObjective;
        private Button btnAddObjective;
    }
}