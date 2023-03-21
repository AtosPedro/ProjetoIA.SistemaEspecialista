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
            this.topMenuToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.homeTab = new System.Windows.Forms.TabControl();
            this.homePage = new System.Windows.Forms.TabPage();
            this.objectivePage = new System.Windows.Forms.TabPage();
            this.objectivePageDGPanel = new System.Windows.Forms.Panel();
            this.dgvObjective = new System.Windows.Forms.DataGridView();
            this.objectiveTabToolStrip = new System.Windows.Forms.ToolStrip();
            this.addObjectiveButton = new System.Windows.Forms.ToolStripButton();
            this.editObjectiveButton = new System.Windows.Forms.ToolStripButton();
            this.deleteObjectiveButton = new System.Windows.Forms.ToolStripButton();
            this.refreshObjectiveListButton = new System.Windows.Forms.ToolStripButton();
            this.characteristicPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCharacteristics = new System.Windows.Forms.DataGridView();
            this.characteristicsToolStrip = new System.Windows.Forms.ToolStrip();
            this.addCharacteristicButton = new System.Windows.Forms.ToolStripButton();
            this.editCharacteristicButton = new System.Windows.Forms.ToolStripButton();
            this.deleteCharacteristicButton = new System.Windows.Forms.ToolStripButton();
            this.refreshCharacteristicsListButton = new System.Windows.Forms.ToolStripButton();
            this.topMenuToolStrip.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.objectivePage.SuspendLayout();
            this.objectivePageDGPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjective)).BeginInit();
            this.objectiveTabToolStrip.SuspendLayout();
            this.characteristicPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacteristics)).BeginInit();
            this.characteristicsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenuToolStrip
            // 
            this.topMenuToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripButton1});
            this.topMenuToolStrip.Location = new System.Drawing.Point(0, 0);
            this.topMenuToolStrip.Name = "topMenuToolStrip";
            this.topMenuToolStrip.Size = new System.Drawing.Size(800, 25);
            this.topMenuToolStrip.TabIndex = 0;
            this.topMenuToolStrip.Text = "Top Menu";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.description_icon_shallow;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripDropDownButton1.Text = "Project";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.add_icon_shallow;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "Novo";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.edit_icon_shallow;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.editToolStripMenuItem.Text = "Abrir";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.devsToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.info_icon_shallow;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(69, 22);
            this.toolStripDropDownButton2.Text = "About";
            this.toolStripDropDownButton2.ToolTipText = "About";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.question_mark_icon_shallow;
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // devsToolStripMenuItem
            // 
            this.devsToolStripMenuItem.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.code_icon_shallow;
            this.devsToolStripMenuItem.Name = "devsToolStripMenuItem";
            this.devsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.devsToolStripMenuItem.Text = "Devs";
            this.devsToolStripMenuItem.Click += new System.EventHandler(this.devsToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.play_button_shallow;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton1.Text = "Run";
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.homePage);
            this.homeTab.Controls.Add(this.objectivePage);
            this.homeTab.Controls.Add(this.characteristicPage);
            this.homeTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeTab.Location = new System.Drawing.Point(0, 25);
            this.homeTab.Name = "homeTab";
            this.homeTab.SelectedIndex = 0;
            this.homeTab.Size = new System.Drawing.Size(800, 425);
            this.homeTab.TabIndex = 3;
            // 
            // homePage
            // 
            this.homePage.Location = new System.Drawing.Point(4, 24);
            this.homePage.Name = "homePage";
            this.homePage.Padding = new System.Windows.Forms.Padding(3);
            this.homePage.Size = new System.Drawing.Size(792, 397);
            this.homePage.TabIndex = 0;
            this.homePage.Text = "Home";
            this.homePage.UseVisualStyleBackColor = true;
            // 
            // objectivePage
            // 
            this.objectivePage.Controls.Add(this.objectivePageDGPanel);
            this.objectivePage.Controls.Add(this.objectiveTabToolStrip);
            this.objectivePage.Location = new System.Drawing.Point(4, 24);
            this.objectivePage.Name = "objectivePage";
            this.objectivePage.Padding = new System.Windows.Forms.Padding(3);
            this.objectivePage.Size = new System.Drawing.Size(792, 397);
            this.objectivePage.TabIndex = 1;
            this.objectivePage.Text = "Objetivos";
            this.objectivePage.UseVisualStyleBackColor = true;
            this.objectivePage.Click += new System.EventHandler(this.objectivePage_Click);
            // 
            // objectivePageDGPanel
            // 
            this.objectivePageDGPanel.Controls.Add(this.dgvObjective);
            this.objectivePageDGPanel.Location = new System.Drawing.Point(8, 31);
            this.objectivePageDGPanel.Name = "objectivePageDGPanel";
            this.objectivePageDGPanel.Size = new System.Drawing.Size(776, 358);
            this.objectivePageDGPanel.TabIndex = 1;
            // 
            // dgvObjective
            // 
            this.dgvObjective.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvObjective.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjective.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObjective.Location = new System.Drawing.Point(0, 0);
            this.dgvObjective.Name = "dgvObjective";
            this.dgvObjective.Size = new System.Drawing.Size(776, 358);
            this.dgvObjective.TabIndex = 0;
            // 
            // objectiveTabToolStrip
            // 
            this.objectiveTabToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addObjectiveButton,
            this.editObjectiveButton,
            this.deleteObjectiveButton,
            this.refreshObjectiveListButton});
            this.objectiveTabToolStrip.Location = new System.Drawing.Point(3, 3);
            this.objectiveTabToolStrip.Name = "objectiveTabToolStrip";
            this.objectiveTabToolStrip.Size = new System.Drawing.Size(786, 25);
            this.objectiveTabToolStrip.TabIndex = 0;
            this.objectiveTabToolStrip.Text = "toolStrip1";
            // 
            // addObjectiveButton
            // 
            this.addObjectiveButton.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.add_icon_shallow;
            this.addObjectiveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addObjectiveButton.Name = "addObjectiveButton";
            this.addObjectiveButton.Size = new System.Drawing.Size(78, 22);
            this.addObjectiveButton.Text = "Adicionar";
            this.addObjectiveButton.Click += new System.EventHandler(this.addObjectiveButton_Click);
            // 
            // editObjectiveButton
            // 
            this.editObjectiveButton.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.edit_icon_shallow;
            this.editObjectiveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editObjectiveButton.Name = "editObjectiveButton";
            this.editObjectiveButton.Size = new System.Drawing.Size(57, 22);
            this.editObjectiveButton.Text = "Editar";
            this.editObjectiveButton.Click += new System.EventHandler(this.editObjectiveButton_Click);
            // 
            // deleteObjectiveButton
            // 
            this.deleteObjectiveButton.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.delete_icon_shallow;
            this.deleteObjectiveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteObjectiveButton.Name = "deleteObjectiveButton";
            this.deleteObjectiveButton.Size = new System.Drawing.Size(61, 22);
            this.deleteObjectiveButton.Text = "Excluir";
            this.deleteObjectiveButton.Click += new System.EventHandler(this.deleteObjectiveButton_Click);
            // 
            // refreshObjectiveListButton
            // 
            this.refreshObjectiveListButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshObjectiveListButton.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.refresh_icon_shallow;
            this.refreshObjectiveListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshObjectiveListButton.Name = "refreshObjectiveListButton";
            this.refreshObjectiveListButton.Size = new System.Drawing.Size(97, 22);
            this.refreshObjectiveListButton.Text = "Atualizar lista";
            this.refreshObjectiveListButton.Click += new System.EventHandler(this.refreshObjectiveListButton_Click);
            // 
            // characteristicPage
            // 
            this.characteristicPage.Controls.Add(this.panel1);
            this.characteristicPage.Location = new System.Drawing.Point(4, 24);
            this.characteristicPage.Name = "characteristicPage";
            this.characteristicPage.Size = new System.Drawing.Size(792, 397);
            this.characteristicPage.TabIndex = 2;
            this.characteristicPage.Text = "Características";
            this.characteristicPage.UseVisualStyleBackColor = true;
            this.characteristicPage.Click += new System.EventHandler(this.characteristicPage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.characteristicsToolStrip);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 386);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCharacteristics);
            this.panel2.Location = new System.Drawing.Point(5, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 358);
            this.panel2.TabIndex = 1;
            // 
            // dgvCharacteristics
            // 
            this.dgvCharacteristics.AllowUserToAddRows = false;
            this.dgvCharacteristics.AllowUserToDeleteRows = false;
            this.dgvCharacteristics.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCharacteristics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharacteristics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCharacteristics.Location = new System.Drawing.Point(0, 0);
            this.dgvCharacteristics.Name = "dgvCharacteristics";
            this.dgvCharacteristics.ReadOnly = true;
            this.dgvCharacteristics.Size = new System.Drawing.Size(776, 358);
            this.dgvCharacteristics.TabIndex = 0;
            // 
            // characteristicsToolStrip
            // 
            this.characteristicsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCharacteristicButton,
            this.editCharacteristicButton,
            this.deleteCharacteristicButton,
            this.refreshCharacteristicsListButton});
            this.characteristicsToolStrip.Location = new System.Drawing.Point(0, 0);
            this.characteristicsToolStrip.Name = "characteristicsToolStrip";
            this.characteristicsToolStrip.Size = new System.Drawing.Size(786, 25);
            this.characteristicsToolStrip.TabIndex = 0;
            this.characteristicsToolStrip.Text = "toolStrip1";
            // 
            // addCharacteristicButton
            // 
            this.addCharacteristicButton.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.add_icon_shallow;
            this.addCharacteristicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCharacteristicButton.Name = "addCharacteristicButton";
            this.addCharacteristicButton.Size = new System.Drawing.Size(78, 22);
            this.addCharacteristicButton.Text = "Adicionar";
            this.addCharacteristicButton.Click += new System.EventHandler(this.addCharacteristicButton_Click);
            // 
            // editCharacteristicButton
            // 
            this.editCharacteristicButton.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.edit_icon_shallow;
            this.editCharacteristicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCharacteristicButton.Name = "editCharacteristicButton";
            this.editCharacteristicButton.Size = new System.Drawing.Size(57, 22);
            this.editCharacteristicButton.Text = "Editar";
            this.editCharacteristicButton.Click += new System.EventHandler(this.editCharacteristicButton_Click);
            // 
            // deleteCharacteristicButton
            // 
            this.deleteCharacteristicButton.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.delete_icon_shallow;
            this.deleteCharacteristicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteCharacteristicButton.Name = "deleteCharacteristicButton";
            this.deleteCharacteristicButton.Size = new System.Drawing.Size(61, 22);
            this.deleteCharacteristicButton.Text = "Excluir";
            this.deleteCharacteristicButton.Click += new System.EventHandler(this.deleteCharacteristicButton_Click);
            // 
            // refreshCharacteristicsListButton
            // 
            this.refreshCharacteristicsListButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshCharacteristicsListButton.Image = global::SistemaEspecialista.DesktopUI.Properties.Resources.refresh_icon_shallow;
            this.refreshCharacteristicsListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshCharacteristicsListButton.Name = "refreshCharacteristicsListButton";
            this.refreshCharacteristicsListButton.Size = new System.Drawing.Size(97, 22);
            this.refreshCharacteristicsListButton.Text = "Atualizar lista";
            this.refreshCharacteristicsListButton.Click += new System.EventHandler(this.refreshCharacteristicsListButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.homeTab);
            this.Controls.Add(this.topMenuToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "XPecialist IDE";
            this.topMenuToolStrip.ResumeLayout(false);
            this.topMenuToolStrip.PerformLayout();
            this.homeTab.ResumeLayout(false);
            this.objectivePage.ResumeLayout(false);
            this.objectivePage.PerformLayout();
            this.objectivePageDGPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjective)).EndInit();
            this.objectiveTabToolStrip.ResumeLayout(false);
            this.objectiveTabToolStrip.PerformLayout();
            this.characteristicPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacteristics)).EndInit();
            this.characteristicsToolStrip.ResumeLayout(false);
            this.characteristicsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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