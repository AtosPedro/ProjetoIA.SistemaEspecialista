namespace SistemaEspecialista.DesktopUI.Views
{
    partial class ObjectiveDialogForm
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
            this.txtObjectiveName = new System.Windows.Forms.TextBox();
            this.txtObjectiveDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveObjectiveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtObjectiveName
            // 
            this.txtObjectiveName.Location = new System.Drawing.Point(50, 95);
            this.txtObjectiveName.Name = "txtObjectiveName";
            this.txtObjectiveName.Size = new System.Drawing.Size(397, 23);
            this.txtObjectiveName.TabIndex = 0;
            // 
            // txtObjectiveDescription
            // 
            this.txtObjectiveDescription.Location = new System.Drawing.Point(50, 163);
            this.txtObjectiveDescription.Name = "txtObjectiveDescription";
            this.txtObjectiveDescription.Size = new System.Drawing.Size(397, 23);
            this.txtObjectiveDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição";
            // 
            // saveObjectiveBtn
            // 
            this.saveObjectiveBtn.Location = new System.Drawing.Point(210, 217);
            this.saveObjectiveBtn.Name = "saveObjectiveBtn";
            this.saveObjectiveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveObjectiveBtn.TabIndex = 4;
            this.saveObjectiveBtn.Text = "Salvar";
            this.saveObjectiveBtn.UseVisualStyleBackColor = true;
            this.saveObjectiveBtn.Click += new System.EventHandler(this.saveObjectiveBtn_Click);
            // 
            // ObjectiveDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 274);
            this.Controls.Add(this.saveObjectiveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtObjectiveDescription);
            this.Controls.Add(this.txtObjectiveName);
            this.Name = "ObjectiveDialogForm";
            this.Text = "ObjectiveDialogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtObjectiveName;
        private TextBox txtObjectiveDescription;
        private Label label1;
        private Label label2;
        private Button saveObjectiveBtn;
    }
}