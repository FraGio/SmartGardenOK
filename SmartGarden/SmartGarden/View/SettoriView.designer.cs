namespace SmartGarden.View
{
    partial class _settoriView
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
            this._settoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numPiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fabbisognoTotaleSettore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._timerInizio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._pianteButton = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this._settoreName,
            this._numPiante,
            this._fabbisognoTotaleSettore,
            this._timerInizio,
            this._pianteButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(0, 0);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.Size = new System.Drawing.Size(587, 400);
            this._dataGridView.TabIndex = 0;
            // 
            // _settoreName
            // 
            this._settoreName.HeaderText = "Settore";
            this._settoreName.Name = "_settoreName";
            this._settoreName.ReadOnly = true;
            // 
            // _numPiante
            // 
            this._numPiante.HeaderText = "N° piante";
            this._numPiante.Name = "_numPiante";
            this._numPiante.ReadOnly = true;
            // 
            // _fabbisognoTotaleSettore
            // 
            this._fabbisognoTotaleSettore.HeaderText = "Fabbisogno totale";
            this._fabbisognoTotaleSettore.Name = "_fabbisognoTotaleSettore";
            this._fabbisognoTotaleSettore.ReadOnly = true;
            // 
            // _timerInizio
            // 
            this._timerInizio.HeaderText = "Durata irrigazione";
            this._timerInizio.Name = "_timerInizio";
            this._timerInizio.ReadOnly = true;
            // 
            // _pianteButton
            // 
            this._pianteButton.HeaderText = "";
            this._pianteButton.Name = "_pianteButton";
            this._pianteButton.ReadOnly = true;
            // 
            // _settoriView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this._dataGridView);
            this.Name = "_settoriView";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _settoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numPiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fabbisognoTotaleSettore;
        private System.Windows.Forms.DataGridViewTextBoxColumn _timerInizio;
        private System.Windows.Forms.DataGridViewButtonColumn _pianteButton;
    }
}
