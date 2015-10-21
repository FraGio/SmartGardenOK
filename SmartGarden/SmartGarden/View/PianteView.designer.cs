namespace SmartGarden.View
{
    partial class PianteView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._idPianta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nomeComune = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nomeBotanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fabbisognoAcqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._mostraGestoriButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._aggiungiPiantaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this._dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._idPianta,
            this._nomeComune,
            this._nomeBotanico,
            this._fabbisognoAcqua,
            this._mostraGestoriButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this._dataGridView.Location = new System.Drawing.Point(0, 24);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.Size = new System.Drawing.Size(979, 487);
            this._dataGridView.TabIndex = 1;
            // 
            // _idPianta
            // 
            this._idPianta.HeaderText = "Id";
            this._idPianta.Name = "_idPianta";
            this._idPianta.ReadOnly = true;
            // 
            // _nomeComune
            // 
            this._nomeComune.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._nomeComune.HeaderText = "Nome comune";
            this._nomeComune.Name = "_nomeComune";
            this._nomeComune.ReadOnly = true;
            // 
            // _nomeBotanico
            // 
            this._nomeBotanico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._nomeBotanico.HeaderText = "Nome Botanico";
            this._nomeBotanico.Name = "_nomeBotanico";
            this._nomeBotanico.ReadOnly = true;
            // 
            // _fabbisognoAcqua
            // 
            this._fabbisognoAcqua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._fabbisognoAcqua.HeaderText = "Fabbisogno acqua";
            this._fabbisognoAcqua.Name = "_fabbisognoAcqua";
            this._fabbisognoAcqua.Width = 132;
            // 
            // _mostraGestoriButton
            // 
            this._mostraGestoriButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._mostraGestoriButton.HeaderText = "";
            this._mostraGestoriButton.Name = "_mostraGestoriButton";
            this._mostraGestoriButton.Width = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _aggiungiPiantaButton
            // 
            this._aggiungiPiantaButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._aggiungiPiantaButton.Location = new System.Drawing.Point(3, 0);
            this._aggiungiPiantaButton.Name = "_aggiungiPiantaButton";
            this._aggiungiPiantaButton.Size = new System.Drawing.Size(137, 23);
            this._aggiungiPiantaButton.TabIndex = 3;
            this._aggiungiPiantaButton.Text = "Aggiungi pianta";
            this._aggiungiPiantaButton.UseVisualStyleBackColor = true;
            this._aggiungiPiantaButton.Click += new System.EventHandler(this._aggiungiPiantaButton_Click);
            // 
            // PianteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this._aggiungiPiantaButton);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PianteView";
            this.Size = new System.Drawing.Size(979, 511);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _idPianta;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nomeComune;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nomeBotanico;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fabbisognoAcqua;
        private System.Windows.Forms.DataGridViewButtonColumn _mostraGestoriButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button _aggiungiPiantaButton;
    }
}