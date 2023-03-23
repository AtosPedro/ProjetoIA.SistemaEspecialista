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
            txtObjectiveName = new TextBox();
            txtObjectiveDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            saveObjectiveBtn = new Button();
            dataGridView1 = new DataGridView();
            btnAddCharacteristic = new Button();
            btnDeleteCharacteristic = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtObjectiveName
            // 
            txtObjectiveName.Location = new Point(12, 43);
            txtObjectiveName.Name = "txtObjectiveName";
            txtObjectiveName.Size = new Size(270, 23);
            txtObjectiveName.TabIndex = 0;
            // 
            // txtObjectiveDescription
            // 
            txtObjectiveDescription.Location = new Point(314, 43);
            txtObjectiveDescription.Name = "txtObjectiveDescription";
            txtObjectiveDescription.Size = new Size(270, 23);
            txtObjectiveDescription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 25);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // saveObjectiveBtn
            // 
            saveObjectiveBtn.Location = new Point(422, 336);
            saveObjectiveBtn.Name = "saveObjectiveBtn";
            saveObjectiveBtn.Size = new Size(167, 41);
            saveObjectiveBtn.TabIndex = 4;
            saveObjectiveBtn.Text = "Salvar";
            saveObjectiveBtn.UseVisualStyleBackColor = true;
            saveObjectiveBtn.Click += saveObjectiveBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(572, 179);
            dataGridView1.TabIndex = 5;
            // 
            // btnAddCharacteristic
            // 
            btnAddCharacteristic.Location = new Point(12, 279);
            btnAddCharacteristic.Name = "btnAddCharacteristic";
            btnAddCharacteristic.Size = new Size(154, 23);
            btnAddCharacteristic.TabIndex = 7;
            btnAddCharacteristic.Text = "Adicionar Característica";
            btnAddCharacteristic.UseVisualStyleBackColor = true;
            btnAddCharacteristic.Click += btnAddCharacteristic_Click;
            // 
            // btnDeleteCharacteristic
            // 
            btnDeleteCharacteristic.Location = new Point(430, 279);
            btnDeleteCharacteristic.Name = "btnDeleteCharacteristic";
            btnDeleteCharacteristic.Size = new Size(154, 23);
            btnDeleteCharacteristic.TabIndex = 8;
            btnDeleteCharacteristic.Text = "Deletar Característica";
            btnDeleteCharacteristic.UseVisualStyleBackColor = true;
            btnDeleteCharacteristic.Click += btnDeleteCharacteristic_Click;
            // 
            // ObjectiveDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 389);
            Controls.Add(btnDeleteCharacteristic);
            Controls.Add(btnAddCharacteristic);
            Controls.Add(dataGridView1);
            Controls.Add(saveObjectiveBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtObjectiveDescription);
            Controls.Add(txtObjectiveName);
            MaximumSize = new Size(617, 428);
            MinimumSize = new Size(617, 428);
            Name = "ObjectiveDialogForm";
            Text = "Novo Objetivo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObjectiveName;
        private TextBox txtObjectiveDescription;
        private Label label1;
        private Label label2;
        private Button saveObjectiveBtn;
        private DataGridView dataGridView1;
        private Button btnAddCharacteristic;
        private Button btnDeleteCharacteristic;
    }
}