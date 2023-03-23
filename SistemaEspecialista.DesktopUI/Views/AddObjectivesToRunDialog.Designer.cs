namespace SistemaEspecialista.DesktopUI.Views
{
    partial class AddObjectivesToRunDialog
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
            objective_screen = new DataGridView();
            cancel_bttn = new Button();
            save_bttn = new Button();
            objective_to_search = new Label();
            btnAddObject = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)objective_screen).BeginInit();
            SuspendLayout();
            // 
            // objective_screen
            // 
            objective_screen.BackgroundColor = SystemColors.ActiveCaption;
            objective_screen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            objective_screen.GridColor = SystemColors.ControlText;
            objective_screen.Location = new Point(13, 53);
            objective_screen.Name = "objective_screen";
            objective_screen.RowTemplate.Height = 25;
            objective_screen.Size = new Size(501, 200);
            objective_screen.TabIndex = 0;
            // 
            // cancel_bttn
            // 
            cancel_bttn.DialogResult = DialogResult.Cancel;
            cancel_bttn.Location = new Point(13, 329);
            cancel_bttn.Name = "cancel_bttn";
            cancel_bttn.Size = new Size(186, 65);
            cancel_bttn.TabIndex = 1;
            cancel_bttn.Text = "Cancelar";
            cancel_bttn.UseVisualStyleBackColor = true;
            // 
            // save_bttn
            // 
            save_bttn.Location = new Point(328, 329);
            save_bttn.Name = "save_bttn";
            save_bttn.Size = new Size(186, 65);
            save_bttn.TabIndex = 2;
            save_bttn.Text = "Run";
            save_bttn.UseVisualStyleBackColor = true;
            save_bttn.Click += run_bttn_Click;
            // 
            // objective_to_search
            // 
            objective_to_search.AutoSize = true;
            objective_to_search.BorderStyle = BorderStyle.Fixed3D;
            objective_to_search.Location = new Point(13, 21);
            objective_to_search.Name = "objective_to_search";
            objective_to_search.Size = new Size(194, 17);
            objective_to_search.TabIndex = 3;
            objective_to_search.Text = "Escolha os objetivos para pesquisar";
            // 
            // btnAddObject
            // 
            btnAddObject.Location = new Point(12, 259);
            btnAddObject.Name = "btnAddObject";
            btnAddObject.Size = new Size(186, 27);
            btnAddObject.TabIndex = 4;
            btnAddObject.Text = "Adicionar";
            btnAddObject.UseVisualStyleBackColor = true;
            btnAddObject.Click += btnAddObject_Click;
            // 
            // button2
            // 
            button2.Location = new Point(328, 258);
            button2.Name = "button2";
            button2.Size = new Size(186, 28);
            button2.TabIndex = 5;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddObjectivesToRunDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 420);
            Controls.Add(button2);
            Controls.Add(btnAddObject);
            Controls.Add(objective_to_search);
            Controls.Add(save_bttn);
            Controls.Add(cancel_bttn);
            Controls.Add(objective_screen);
            MaximumSize = new Size(552, 459);
            MinimumSize = new Size(552, 459);
            Name = "AddObjectivesToRunDialog";
            Text = "Adicionar Objetivos";
            ((System.ComponentModel.ISupportInitialize)objective_screen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView objective_screen;
        private Button cancel_bttn;
        private Button save_bttn;
        private Label objective_to_search;
        private Button btnAddObject;
        private Button button2;
    }
}