namespace SistemaEspecialista.DesktopUI.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            topMenuToolStrip = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            newToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            manualToolStripMenuItem = new ToolStripMenuItem();
            devsToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton1 = new ToolStripButton();
            homeTab = new TabControl();
            homePage = new TabPage();
            objectivePage = new TabPage();
            objectivePageDGPanel = new Panel();
            dgvObjective = new DataGridView();
            objectiveTabToolStrip = new ToolStrip();
            addObjectiveButton = new ToolStripButton();
            editObjectiveButton = new ToolStripButton();
            deleteObjectiveButton = new ToolStripButton();
            refreshObjectiveListButton = new ToolStripButton();
            characteristicPage = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            dgvCharacteristics = new DataGridView();
            characteristicsToolStrip = new ToolStrip();
            addCharacteristicButton = new ToolStripButton();
            editCharacteristicButton = new ToolStripButton();
            deleteCharacteristicButton = new ToolStripButton();
            refreshCharacteristicsListButton = new ToolStripButton();
            topMenuToolStrip.SuspendLayout();
            homeTab.SuspendLayout();
            objectivePage.SuspendLayout();
            objectivePageDGPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvObjective).BeginInit();
            objectiveTabToolStrip.SuspendLayout();
            characteristicPage.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCharacteristics).BeginInit();
            characteristicsToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // topMenuToolStrip
            // 
            topMenuToolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripDropDownButton2, toolStripButton1 });
            topMenuToolStrip.Location = new Point(0, 0);
            topMenuToolStrip.Name = "topMenuToolStrip";
            topMenuToolStrip.Size = new Size(800, 25);
            topMenuToolStrip.TabIndex = 0;
            topMenuToolStrip.Text = "Top Menu";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, editToolStripMenuItem });
            toolStripDropDownButton1.Image = Properties.Resources.description_icon_shallow;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(73, 22);
            toolStripDropDownButton1.Text = "Project";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = Properties.Resources.add_icon_shallow;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(103, 22);
            newToolStripMenuItem.Text = "Novo";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = Properties.Resources.edit_icon_shallow;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(103, 22);
            editToolStripMenuItem.Text = "Abrir";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { manualToolStripMenuItem, devsToolStripMenuItem });
            toolStripDropDownButton2.Image = Properties.Resources.info_icon_shallow;
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(69, 22);
            toolStripDropDownButton2.Text = "About";
            toolStripDropDownButton2.ToolTipText = "About";
            // 
            // manualToolStripMenuItem
            // 
            manualToolStripMenuItem.Image = Properties.Resources.question_mark_icon_shallow;
            manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            manualToolStripMenuItem.Size = new Size(114, 22);
            manualToolStripMenuItem.Text = "Manual";
            manualToolStripMenuItem.Click += manualToolStripMenuItem_Click;
            // 
            // devsToolStripMenuItem
            // 
            devsToolStripMenuItem.Image = Properties.Resources.code_icon_shallow;
            devsToolStripMenuItem.Name = "devsToolStripMenuItem";
            devsToolStripMenuItem.Size = new Size(114, 22);
            devsToolStripMenuItem.Text = "Devs";
            devsToolStripMenuItem.Click += devsToolStripMenuItem_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.play_button_shallow;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(48, 22);
            toolStripButton1.Text = "Run";
            toolStripButton1.Click += runBtn_Click;
            // 
            // homeTab
            // 
            homeTab.Controls.Add(homePage);
            homeTab.Controls.Add(objectivePage);
            homeTab.Controls.Add(characteristicPage);
            homeTab.Dock = DockStyle.Fill;
            homeTab.Location = new Point(0, 25);
            homeTab.Name = "homeTab";
            homeTab.SelectedIndex = 0;
            homeTab.Size = new Size(800, 425);
            homeTab.TabIndex = 3;
            // 
            // homePage
            // 
            homePage.Location = new Point(4, 24);
            homePage.Name = "homePage";
            homePage.Padding = new Padding(3);
            homePage.Size = new Size(792, 397);
            homePage.TabIndex = 0;
            homePage.Text = "Home";
            homePage.UseVisualStyleBackColor = true;
            // 
            // objectivePage
            // 
            objectivePage.Controls.Add(objectivePageDGPanel);
            objectivePage.Controls.Add(objectiveTabToolStrip);
            objectivePage.Location = new Point(4, 24);
            objectivePage.Name = "objectivePage";
            objectivePage.Padding = new Padding(3);
            objectivePage.Size = new Size(792, 397);
            objectivePage.TabIndex = 1;
            objectivePage.Text = "Objetivos";
            objectivePage.UseVisualStyleBackColor = true;
            objectivePage.Click += objectivePage_Click;
            // 
            // objectivePageDGPanel
            // 
            objectivePageDGPanel.Controls.Add(dgvObjective);
            objectivePageDGPanel.Location = new Point(8, 31);
            objectivePageDGPanel.Name = "objectivePageDGPanel";
            objectivePageDGPanel.Size = new Size(776, 358);
            objectivePageDGPanel.TabIndex = 1;
            // 
            // dgvObjective
            // 
            dgvObjective.BackgroundColor = SystemColors.ControlLight;
            dgvObjective.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObjective.Dock = DockStyle.Fill;
            dgvObjective.Location = new Point(0, 0);
            dgvObjective.Name = "dgvObjective";
            dgvObjective.Size = new Size(776, 358);
            dgvObjective.TabIndex = 0;
            // 
            // objectiveTabToolStrip
            // 
            objectiveTabToolStrip.Items.AddRange(new ToolStripItem[] { addObjectiveButton, editObjectiveButton, deleteObjectiveButton, refreshObjectiveListButton });
            objectiveTabToolStrip.Location = new Point(3, 3);
            objectiveTabToolStrip.Name = "objectiveTabToolStrip";
            objectiveTabToolStrip.Size = new Size(786, 25);
            objectiveTabToolStrip.TabIndex = 0;
            objectiveTabToolStrip.Text = "toolStrip1";
            // 
            // addObjectiveButton
            // 
            addObjectiveButton.Image = Properties.Resources.add_icon_shallow;
            addObjectiveButton.ImageTransparentColor = Color.Magenta;
            addObjectiveButton.Name = "addObjectiveButton";
            addObjectiveButton.Size = new Size(78, 22);
            addObjectiveButton.Text = "Adicionar";
            addObjectiveButton.Click += addObjectiveButton_Click;
            // 
            // editObjectiveButton
            // 
            editObjectiveButton.Image = Properties.Resources.edit_icon_shallow;
            editObjectiveButton.ImageTransparentColor = Color.Magenta;
            editObjectiveButton.Name = "editObjectiveButton";
            editObjectiveButton.Size = new Size(57, 22);
            editObjectiveButton.Text = "Editar";
            editObjectiveButton.Click += editObjectiveButton_Click;
            // 
            // deleteObjectiveButton
            // 
            deleteObjectiveButton.Image = Properties.Resources.delete_icon_shallow;
            deleteObjectiveButton.ImageTransparentColor = Color.Magenta;
            deleteObjectiveButton.Name = "deleteObjectiveButton";
            deleteObjectiveButton.Size = new Size(62, 22);
            deleteObjectiveButton.Text = "Excluir";
            deleteObjectiveButton.Click += deleteObjectiveButton_Click;
            // 
            // refreshObjectiveListButton
            // 
            refreshObjectiveListButton.Alignment = ToolStripItemAlignment.Right;
            refreshObjectiveListButton.Image = Properties.Resources.refresh_icon_shallow;
            refreshObjectiveListButton.ImageTransparentColor = Color.Magenta;
            refreshObjectiveListButton.Name = "refreshObjectiveListButton";
            refreshObjectiveListButton.Size = new Size(97, 22);
            refreshObjectiveListButton.Text = "Atualizar lista";
            refreshObjectiveListButton.Click += refreshObjectiveListButton_Click;
            // 
            // characteristicPage
            // 
            characteristicPage.Controls.Add(panel1);
            characteristicPage.Location = new Point(4, 24);
            characteristicPage.Name = "characteristicPage";
            characteristicPage.Size = new Size(792, 397);
            characteristicPage.TabIndex = 2;
            characteristicPage.Text = "Características";
            characteristicPage.UseVisualStyleBackColor = true;
            characteristicPage.Click += characteristicPage_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(characteristicsToolStrip);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 386);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvCharacteristics);
            panel2.Location = new Point(5, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 358);
            panel2.TabIndex = 1;
            // 
            // dgvCharacteristics
            // 
            dgvCharacteristics.AllowUserToAddRows = false;
            dgvCharacteristics.AllowUserToDeleteRows = false;
            dgvCharacteristics.BackgroundColor = SystemColors.ControlLight;
            dgvCharacteristics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCharacteristics.Dock = DockStyle.Fill;
            dgvCharacteristics.Location = new Point(0, 0);
            dgvCharacteristics.Name = "dgvCharacteristics";
            dgvCharacteristics.ReadOnly = true;
            dgvCharacteristics.Size = new Size(776, 358);
            dgvCharacteristics.TabIndex = 0;
            // 
            // characteristicsToolStrip
            // 
            characteristicsToolStrip.Items.AddRange(new ToolStripItem[] { addCharacteristicButton, editCharacteristicButton, deleteCharacteristicButton, refreshCharacteristicsListButton });
            characteristicsToolStrip.Location = new Point(0, 0);
            characteristicsToolStrip.Name = "characteristicsToolStrip";
            characteristicsToolStrip.Size = new Size(786, 25);
            characteristicsToolStrip.TabIndex = 0;
            characteristicsToolStrip.Text = "toolStrip1";
            // 
            // addCharacteristicButton
            // 
            addCharacteristicButton.Image = Properties.Resources.add_icon_shallow;
            addCharacteristicButton.ImageTransparentColor = Color.Magenta;
            addCharacteristicButton.Name = "addCharacteristicButton";
            addCharacteristicButton.Size = new Size(78, 22);
            addCharacteristicButton.Text = "Adicionar";
            addCharacteristicButton.Click += addCharacteristicButton_Click;
            // 
            // editCharacteristicButton
            // 
            editCharacteristicButton.Image = Properties.Resources.edit_icon_shallow;
            editCharacteristicButton.ImageTransparentColor = Color.Magenta;
            editCharacteristicButton.Name = "editCharacteristicButton";
            editCharacteristicButton.Size = new Size(57, 22);
            editCharacteristicButton.Text = "Editar";
            editCharacteristicButton.Click += editCharacteristicButton_Click;
            // 
            // deleteCharacteristicButton
            // 
            deleteCharacteristicButton.Image = Properties.Resources.delete_icon_shallow;
            deleteCharacteristicButton.ImageTransparentColor = Color.Magenta;
            deleteCharacteristicButton.Name = "deleteCharacteristicButton";
            deleteCharacteristicButton.Size = new Size(62, 22);
            deleteCharacteristicButton.Text = "Excluir";
            deleteCharacteristicButton.Click += deleteCharacteristicButton_Click;
            // 
            // refreshCharacteristicsListButton
            // 
            refreshCharacteristicsListButton.Alignment = ToolStripItemAlignment.Right;
            refreshCharacteristicsListButton.Image = Properties.Resources.refresh_icon_shallow;
            refreshCharacteristicsListButton.ImageTransparentColor = Color.Magenta;
            refreshCharacteristicsListButton.Name = "refreshCharacteristicsListButton";
            refreshCharacteristicsListButton.Size = new Size(97, 22);
            refreshCharacteristicsListButton.Text = "Atualizar lista";
            refreshCharacteristicsListButton.Click += refreshCharacteristicsListButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(homeTab);
            Controls.Add(topMenuToolStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "MainForm";
            Text = "XPecialist IDE";
            topMenuToolStrip.ResumeLayout(false);
            topMenuToolStrip.PerformLayout();
            homeTab.ResumeLayout(false);
            objectivePage.ResumeLayout(false);
            objectivePage.PerformLayout();
            objectivePageDGPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvObjective).EndInit();
            objectiveTabToolStrip.ResumeLayout(false);
            objectiveTabToolStrip.PerformLayout();
            characteristicPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCharacteristics).EndInit();
            characteristicsToolStrip.ResumeLayout(false);
            characteristicsToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip topMenuToolStrip;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem manualToolStripMenuItem;
        private ToolStripMenuItem devsToolStripMenuItem;
        private ToolStripButton toolStripButton1;
        private TabControl homeTab;
        private TabPage homePage;
        private TabPage objectivePage;
        private TabPage characteristicPage;
        private ToolStripButton addObjectiveButton;
        private ToolStripButton editObjectiveButton;
        private ToolStripButton deleteObjectiveButton;
        private Panel objectivePageDGPanel;
        private DataGridView dataGridView1;
        private ToolStrip objectiveTabToolStrip;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvCharacteristics;
        private ToolStrip characteristicsToolStrip;
        private ToolStripButton addCharacteristicButton;
        private ToolStripButton editCharacteristicButton;
        private ToolStripButton deleteCharacteristicButton;
        private ToolStripButton refreshCharacteristicsListButton;
        private ToolStripButton refreshObjectiveListButton;
        private DataGridView dgvObjective;
    }
}