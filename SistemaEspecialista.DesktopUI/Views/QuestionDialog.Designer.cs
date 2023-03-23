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
            title_assoc = new Label();
            continue_bttn = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            btnExplanation = new Button();
            SuspendLayout();
            // 
            // title_assoc
            // 
            title_assoc.AutoSize = true;
            title_assoc.Location = new Point(9, 72);
            title_assoc.Name = "title_assoc";
            title_assoc.Size = new Size(55, 15);
            title_assoc.TabIndex = 0;
            title_assoc.Text = "Pergunta";
            // 
            // continue_bttn
            // 
            continue_bttn.Location = new Point(392, 122);
            continue_bttn.Name = "continue_bttn";
            continue_bttn.Size = new Size(171, 51);
            continue_bttn.TabIndex = 5;
            continue_bttn.Text = "Continuar";
            continue_bttn.UseVisualStyleBackColor = true;
            continue_bttn.Click += continue_bttn_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 122);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(81, 19);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Verdadeiro";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 154);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 19);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Falso";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // btnExplanation
            // 
            btnExplanation.AccessibleRole = AccessibleRole.None;
            btnExplanation.Location = new Point(9, 12);
            btnExplanation.Name = "btnExplanation";
            btnExplanation.Size = new Size(44, 33);
            btnExplanation.TabIndex = 9;
            btnExplanation.Text = "?";
            btnExplanation.UseVisualStyleBackColor = true;
            btnExplanation.Click += btnExplanation_Click;
            // 
            // QuestionDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 185);
            Controls.Add(btnExplanation);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(continue_bttn);
            Controls.Add(title_assoc);
            MaximumSize = new Size(591, 224);
            MinimumSize = new Size(591, 224);
            Name = "QuestionDialog";
            Text = "QuestionDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_assoc;
        private Button continue_bttn;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btnExplanation;
    }
}