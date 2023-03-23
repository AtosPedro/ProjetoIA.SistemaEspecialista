namespace SistemaEspecialista.DesktopUI.Views
{
    partial class CharacteristcsDialog
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
            cmbCharacteristic = new ComboBox();
            btnAddCharacteristic = new Button();
            SuspendLayout();
            // 
            // cmbCharacteristic
            // 
            cmbCharacteristic.FormattingEnabled = true;
            cmbCharacteristic.Location = new Point(12, 54);
            cmbCharacteristic.Name = "cmbCharacteristic";
            cmbCharacteristic.Size = new Size(299, 23);
            cmbCharacteristic.TabIndex = 0;
            // 
            // btnAddCharacteristic
            // 
            btnAddCharacteristic.Location = new Point(338, 39);
            btnAddCharacteristic.Name = "btnAddCharacteristic";
            btnAddCharacteristic.Size = new Size(121, 51);
            btnAddCharacteristic.TabIndex = 1;
            btnAddCharacteristic.Text = "Adicionar";
            btnAddCharacteristic.UseVisualStyleBackColor = true;
            btnAddCharacteristic.Click += btnAddCharacteristic_Click;
            // 
            // CharacteristcsDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 121);
            Controls.Add(btnAddCharacteristic);
            Controls.Add(cmbCharacteristic);
            MaximumSize = new Size(496, 160);
            MinimumSize = new Size(496, 160);
            Name = "CharacteristcsDialog";
            Text = "Selecione a Característica";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbCharacteristic;
        private Button btnAddCharacteristic;
    }
}