namespace SmartGarden.View
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.giardinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiGiardinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaCittàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._provinceComboBox = new System.Windows.Forms.ToolStripComboBox();
            this._resetToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.gestisciGiardinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaTimerGeneraleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaNotificheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem();
            this._statusStrip = new System.Windows.Forms.StatusStrip();
            this._dateStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this._treeView = new SmartGarden.View.PannelloSinistra();
            this._pannelloDestra = new SmartGarden.View.PannelloDestra();
            this.menuStrip2.SuspendLayout();
            this._statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.giardinoToolStripMenuItem,
            this.toolStripMenuItem24});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem11});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem11.Text = "E&xit";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // giardinoToolStripMenuItem
            // 
            this.giardinoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiGiardinoToolStripMenuItem,
            this.gestisciGiardinoToolStripMenuItem,
            this.modificaTimerGeneraleToolStripMenuItem,
            this.visualizzaNotificheToolStripMenuItem});
            this.giardinoToolStripMenuItem.Name = "giardinoToolStripMenuItem";
            this.giardinoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.giardinoToolStripMenuItem.Text = "Giardino";
            // 
            // aggiungiGiardinoToolStripMenuItem
            // 
            this.aggiungiGiardinoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificaCittàToolStripMenuItem,
            this._resetToolStrip});
            this.aggiungiGiardinoToolStripMenuItem.Name = "aggiungiGiardinoToolStripMenuItem";
            this.aggiungiGiardinoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.aggiungiGiardinoToolStripMenuItem.Text = "Modifica giardino";
            // 
            // modificaCittàToolStripMenuItem
            // 
            this.modificaCittàToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._provinceComboBox});
            this.modificaCittàToolStripMenuItem.Name = "modificaCittàToolStripMenuItem";
            this.modificaCittàToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.modificaCittàToolStripMenuItem.Text = "Modifica provincia";
            // 
            // _provinceComboBox
            // 
            this._provinceComboBox.Name = "_provinceComboBox";
            this._provinceComboBox.Size = new System.Drawing.Size(121, 23);
            // 
            // _resetToolStrip
            // 
            this._resetToolStrip.Name = "_resetToolStrip";
            this._resetToolStrip.Size = new System.Drawing.Size(173, 22);
            this._resetToolStrip.Text = "Nuovo giardino";
            this._resetToolStrip.Click += new System.EventHandler(this._resetToolStrip_Click);
            // 
            // gestisciGiardinoToolStripMenuItem
            // 
            this.gestisciGiardinoToolStripMenuItem.Name = "gestisciGiardinoToolStripMenuItem";
            this.gestisciGiardinoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.gestisciGiardinoToolStripMenuItem.Text = "Gestisci settori";
            this.gestisciGiardinoToolStripMenuItem.Click += new System.EventHandler(this.gestisciGiardinoToolStripMenuItem_Click);
            // 
            // modificaTimerGeneraleToolStripMenuItem
            // 
            this.modificaTimerGeneraleToolStripMenuItem.Name = "modificaTimerGeneraleToolStripMenuItem";
            this.modificaTimerGeneraleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.modificaTimerGeneraleToolStripMenuItem.Text = "Modifica timer generale";
            this.modificaTimerGeneraleToolStripMenuItem.Click += new System.EventHandler(this.modificaTimerGeneraleToolStripMenuItem_Click);
            // 
            // visualizzaNotificheToolStripMenuItem
            // 
            this.visualizzaNotificheToolStripMenuItem.Name = "visualizzaNotificheToolStripMenuItem";
            this.visualizzaNotificheToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.visualizzaNotificheToolStripMenuItem.Text = "Visualizza notifiche";
            this.visualizzaNotificheToolStripMenuItem.Click += new System.EventHandler(this.visualizzaNotificheToolStripMenuItem_Click);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem29});
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem24.Text = "&Help";
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            this.toolStripMenuItem29.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem29.Text = "&About...";
            // 
            // _statusStrip
            // 
            this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._dateStatusBar});
            this._statusStrip.Location = new System.Drawing.Point(0, 640);
            this._statusStrip.Name = "_statusStrip";
            this._statusStrip.Size = new System.Drawing.Size(1264, 22);
            this._statusStrip.TabIndex = 1;
            this._statusStrip.Text = "statusStrip1";
            // 
            // _dateStatusBar
            // 
            this._dateStatusBar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dateStatusBar.Name = "_dateStatusBar";
            this._dateStatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer2.Panel1.Controls.Add(this._treeView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer2.Panel2.Controls.Add(this._pannelloDestra);
            this.splitContainer2.Size = new System.Drawing.Size(1264, 616);
            this.splitContainer2.SplitterDistance = 337;
            this.splitContainer2.TabIndex = 2;
            // 
            // _treeView
            // 
            this._treeView.BackColor = System.Drawing.Color.Silver;
            this._treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._treeView.GestoreGiardino = null;
            this._treeView.Location = new System.Drawing.Point(0, 0);
            this._treeView.Name = "_treeView";
            this._treeView.Size = new System.Drawing.Size(337, 616);
            this._treeView.TabIndex = 0;
            // 
            // _pannelloDestra
            // 
            this._pannelloDestra.BackColor = System.Drawing.Color.DimGray;
            this._pannelloDestra.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pannelloDestra.GestoreGiardino = null;
            this._pannelloDestra.Location = new System.Drawing.Point(0, 0);
            this._pannelloDestra.Name = "_pannelloDestra";
            this._pannelloDestra.Size = new System.Drawing.Size(923, 616);
            this._pannelloDestra.TabIndex = 0;
            this._pannelloDestra.Load += new System.EventHandler(this._pannelloDestra_Load);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1264, 662);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this._statusStrip);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1278, 700);
            this.Name = "MainWindow";
            this.Text = "SmartGarden";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this._statusStrip.ResumeLayout(false);
            this._statusStrip.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem29;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.StatusStrip _statusStrip;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private View.PannelloSinistra _treeView;
        private System.Windows.Forms.ToolStripStatusLabel _dateStatusBar;
        private View.PannelloDestra _pannelloDestra;
        private System.Windows.Forms.ToolStripMenuItem giardinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiGiardinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestisciGiardinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaTimerGeneraleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaCittàToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox _provinceComboBox;
        private System.Windows.Forms.ToolStripMenuItem _resetToolStrip;
        private System.Windows.Forms.ToolStripMenuItem visualizzaNotificheToolStripMenuItem;
    }
}