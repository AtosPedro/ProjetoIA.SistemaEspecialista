namespace SistemaEspecialista.DesktopUI.Views
{
    partial class CharacteristicsDialogForm
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
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescription = new TextBox();
            dgvQuestion = new DataGridView();
            label3 = new Label();
            btnAddQuestion = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnEditQuestion = new Button();
            btnDeleteQuestion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 59);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 41);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(347, 59);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(256, 23);
            txtDescription.TabIndex = 2;
            // 
            // dgvQuestion
            // 
            dgvQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestion.Location = new Point(12, 126);
            dgvQuestion.Name = "dgvQuestion";
            dgvQuestion.RowTemplate.Height = 25;
            dgvQuestion.Size = new Size(591, 110);
            dgvQuestion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Pergunta";
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Location = new Point(12, 252);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(133, 23);
            btnAddQuestion.TabIndex = 6;
            btnAddQuestion.Text = "Adicionar Pergunta";
            btnAddQuestion.UseVisualStyleBackColor = true;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(12, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(178, 69);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(425, 300);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 69);
            btnSave.TabIndex = 8;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEditQuestion
            // 
            btnEditQuestion.Location = new Point(228, 252);
            btnEditQuestion.Name = "btnEditQuestion";
            btnEditQuestion.Size = new Size(139, 23);
            btnEditQuestion.TabIndex = 9;
            btnEditQuestion.Text = "Editar Pergunta";
            btnEditQuestion.UseVisualStyleBackColor = true;
            btnEditQuestion.Click += btnEditQuestion_Click;
            // 
            // btnDeleteQuestion
            // 
            btnDeleteQuestion.Location = new Point(464, 252);
            btnDeleteQuestion.Name = "btnDeleteQuestion";
            btnDeleteQuestion.Size = new Size(139, 23);
            btnDeleteQuestion.TabIndex = 10;
            btnDeleteQuestion.Text = "Deletar";
            btnDeleteQuestion.UseVisualStyleBackColor = true;
            btnDeleteQuestion.Click += btnDeleteQuestion_Click;
            // 
            // CharacteristicsDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 386);
            Controls.Add(btnDeleteQuestion);
            Controls.Add(btnEditQuestion);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnAddQuestion);
            Controls.Add(label3);
            Controls.Add(dgvQuestion);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(txtName);
            MaximumSize = new Size(631, 425);
            MinimumSize = new Size(631, 425);
            Name = "CharacteristicsDialogForm";
            Text = "Nova característica";
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtDescription;
        private DataGridView dgvQuestion;
        private Label label3;
        private Button btnAddQuestion;
        private Button btnCancel;
        private Button btnSave;
        private Button btnEditQuestion;
        private Button btnDeleteQuestion;
    }
}