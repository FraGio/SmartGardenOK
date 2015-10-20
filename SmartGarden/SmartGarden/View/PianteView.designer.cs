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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeComune = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeBotanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FabbisognoAcqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provider = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Visitor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._confermaButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._mostraGestoriButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Id,
            this.NomeComune,
            this.NomeBotanico,
            this.FabbisognoAcqua,
            this.Provider,
            this.Visitor,
            this._confermaButton,
            this._mostraGestoriButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this._dataGridView.Location = new System.Drawing.Point(1, 0);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.Size = new System.Drawing.Size(976, 508);
            this._dataGridView.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 46;
            // 
            // NomeComune
            // 
            this.NomeComune.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeComune.HeaderText = "Nome comune";
            this.NomeComune.Name = "NomeComune";
            // 
            // NomeBotanico
            // 
            this.NomeBotanico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeBotanico.HeaderText = "Nome Botanico";
            this.NomeBotanico.Name = "NomeBotanico";
            // 
            // FabbisognoAcqua
            // 
            this.FabbisognoAcqua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FabbisognoAcqua.HeaderText = "Fabbisogno acqua";
            this.FabbisognoAcqua.Name = "FabbisognoAcqua";
            this.FabbisognoAcqua.Width = 132;
            // 
            // Provider
            // 
            this.Provider.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Provider.HeaderText = "Provider";
            this.Provider.Name = "Provider";
            // 
            // Visitor
            // 
            this.Visitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Visitor.HeaderText = "Visitor";
            this.Visitor.Name = "Visitor";
            // 
            // _confermaButton
            // 
            this._confermaButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._confermaButton.HeaderText = "";
            this._confermaButton.Name = "_confermaButton";
            this._confermaButton.Text = "Conferma";
            this._confermaButton.Width = 5;
            // 
            // _mostraGestoriButton
            // 
            this._mostraGestoriButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._mostraGestoriButton.HeaderText = "";
            this._mostraGestoriButton.Name = "_mostraGestoriButton";
            this._mostraGestoriButton.Width = 5;
            // 
            // PianteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this._dataGridView);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PianteView";
            this.Size = new System.Drawing.Size(979, 511);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeComune;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeBotanico;
        private System.Windows.Forms.DataGridViewTextBoxColumn FabbisognoAcqua;
        private System.Windows.Forms.DataGridViewComboBoxColumn Provider;
        private System.Windows.Forms.DataGridViewComboBoxColumn Visitor;
        private System.Windows.Forms.DataGridViewButtonColumn _confermaButton;
        private System.Windows.Forms.DataGridViewButtonColumn _mostraGestoriButton;
    }
}