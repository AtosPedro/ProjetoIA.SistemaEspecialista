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
            this.objective_screen = new System.Windows.Forms.DataGridView();
            this.cancel_bttn = new System.Windows.Forms.Button();
            this.save_bttn = new System.Windows.Forms.Button();
            this.objective_to_search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objective_screen)).BeginInit();
            this.SuspendLayout();
            // 
            // objective_screen
            // 
            this.objective_screen.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.objective_screen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objective_screen.GridColor = System.Drawing.SystemColors.ControlText;
            this.objective_screen.Location = new System.Drawing.Point(13, 53);
            this.objective_screen.Name = "objective_screen";
            this.objective_screen.RowTemplate.Height = 25;
            this.objective_screen.Size = new System.Drawing.Size(501, 248);
            this.objective_screen.TabIndex = 0;
            this.objective_screen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.objective_screen_CellContentClick);
            // 
            // cancel_bttn
            // 
            this.cancel_bttn.Location = new System.Drawing.Point(13, 329);
            this.cancel_bttn.Name = "cancel_bttn";
            this.cancel_bttn.Size = new System.Drawing.Size(186, 65);
            this.cancel_bttn.TabIndex = 1;
            this.cancel_bttn.Text = "Cancelar";
            this.cancel_bttn.UseVisualStyleBackColor = true;
            // 
            // save_bttn
            // 
            this.save_bttn.Location = new System.Drawing.Point(328, 329);
            this.save_bttn.Name = "save_bttn";
            this.save_bttn.Size = new System.Drawing.Size(186, 65);
            this.save_bttn.TabIndex = 2;
            this.save_bttn.Text = "Salvar";
            this.save_bttn.UseVisualStyleBackColor = true;
            // 
            // objective_to_search
            // 
            this.objective_to_search.AutoSize = true;
            this.objective_to_search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.objective_to_search.Location = new System.Drawing.Point(13, 21);
            this.objective_to_search.Name = "objective_to_search";
            this.objective_to_search.Size = new System.Drawing.Size(194, 17);
            this.objective_to_search.TabIndex = 3;
            this.objective_to_search.Text = "Escolha os objetivos para pesquisar";
            // 
            // AddObjectivesToRunDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 420);
            this.Controls.Add(this.objective_to_search);
            this.Controls.Add(this.save_bttn);
            this.Controls.Add(this.cancel_bttn);
            this.Controls.Add(this.objective_screen);
            this.Name = "AddObjectivesToRunDialog";
            this.Text = "Adicionar Objetivos";
            ((System.ComponentModel.ISupportInitialize)(this.objective_screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView objective_screen;
        private Button cancel_bttn;
        private Button save_bttn;
        private Label objective_to_search;
    }
}