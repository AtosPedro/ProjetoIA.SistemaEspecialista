namespace SistemaEspecialista.DesktopUI.Views
{
    partial class QuestionDialog
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
            this.title_assoc = new System.Windows.Forms.Label();
            this.pgt_assoc = new System.Windows.Forms.Label();
            this.true_bttn = new System.Windows.Forms.Button();
            this.continue_bttn = new System.Windows.Forms.Button();
            this.false_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_assoc
            // 
            this.title_assoc.AutoSize = true;
            this.title_assoc.Location = new System.Drawing.Point(247, 9);
            this.title_assoc.Name = "title_assoc";
            this.title_assoc.Size = new System.Drawing.Size(176, 15);
            this.title_assoc.TabIndex = 0;
            this.title_assoc.Text = "Responda as perguntas à seguir:";
            // 
            // pgt_assoc
            // 
            this.pgt_assoc.AutoSize = true;
            this.pgt_assoc.Location = new System.Drawing.Point(314, 77);
            this.pgt_assoc.Name = "pgt_assoc";
            this.pgt_assoc.Size = new System.Drawing.Size(55, 15);
            this.pgt_assoc.TabIndex = 1;
            this.pgt_assoc.Text = "pergunta";
            this.pgt_assoc.Click += new System.EventHandler(this.label2_Click);
            // 
            // true_bttn
            // 
            this.true_bttn.Location = new System.Drawing.Point(186, 128);
            this.true_bttn.Name = "true_bttn";
            this.true_bttn.Size = new System.Drawing.Size(90, 40);
            this.true_bttn.TabIndex = 4;
            this.true_bttn.Text = "Verdadeiro";
            this.true_bttn.UseVisualStyleBackColor = true;
            // 
            // continue_bttn
            // 
            this.continue_bttn.Location = new System.Drawing.Point(252, 207);
            this.continue_bttn.Name = "continue_bttn";
            this.continue_bttn.Size = new System.Drawing.Size(171, 51);
            this.continue_bttn.TabIndex = 5;
            this.continue_bttn.Text = "Continuar";
            this.continue_bttn.UseVisualStyleBackColor = true;
            // 
            // false_bttn
            // 
            this.false_bttn.Location = new System.Drawing.Point(400, 128);
            this.false_bttn.Name = "false_bttn";
            this.false_bttn.Size = new System.Drawing.Size(90, 40);
            this.false_bttn.TabIndex = 6;
            this.false_bttn.Text = "Falso";
            this.false_bttn.UseVisualStyleBackColor = true;
            // 
            // QuestionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 281);
            this.Controls.Add(this.false_bttn);
            this.Controls.Add(this.continue_bttn);
            this.Controls.Add(this.true_bttn);
            this.Controls.Add(this.pgt_assoc);
            this.Controls.Add(this.title_assoc);
            this.Name = "QuestionDialog";
            this.Text = "QuestionDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label title_assoc;
        private Label pgt_assoc;
        private Button true_bttn;
        private Button continue_bttn;
        private Button false_bttn;
    }
}