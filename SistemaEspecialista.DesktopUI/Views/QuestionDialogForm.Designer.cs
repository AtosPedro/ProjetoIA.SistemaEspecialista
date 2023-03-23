namespace SistemaEspecialista.DesktopUI.Views
{
    partial class QuestionDialogForm
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
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(49, 61);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(348, 23);
            txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 43);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Pergunta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 103);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Explicação";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(49, 121);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(348, 23);
            txtDescription.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(49, 173);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 44);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(260, 173);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 44);
            btnSave.TabIndex = 5;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // QuestionDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 258);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            MaximumSize = new Size(467, 297);
            MinimumSize = new Size(467, 297);
            Name = "QuestionDialogForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Nova Pergunta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private TextBox txtDescription;
        private Button btnCancel;
        private Button btnSave;
    }
}