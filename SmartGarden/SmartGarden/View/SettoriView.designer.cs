namespace SmartGarden.View
{
    partial class SettoriView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._aggiungiSettoreButton = new System.Windows.Forms.Button();
            this._settoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._numPiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._fabbisognoTotaleSettore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._pianteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this._eliminaSettoreButton = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this._pianteButton,
            this._eliminaSettoreButton});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(0, 24);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.Size = new System.Drawing.Size(587, 376);
            this._dataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _aggiungiSettoreButton
            // 
            this._aggiungiSettoreButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._aggiungiSettoreButton.Location = new System.Drawing.Point(3, 0);
            this._aggiungiSettoreButton.Name = "_aggiungiSettoreButton";
            this._aggiungiSettoreButton.Size = new System.Drawing.Size(111, 23);
            this._aggiungiSettoreButton.TabIndex = 2;
            this._aggiungiSettoreButton.Text = "Aggiungi settore";
            this._aggiungiSettoreButton.UseVisualStyleBackColor = true;
            this._aggiungiSettoreButton.Click += new System.EventHandler(this._aggiungiSettoreButton_Click);
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
            // _pianteButton
            // 
            this._pianteButton.HeaderText = "";
            this._pianteButton.Name = "_pianteButton";
            this._pianteButton.ReadOnly = true;
            // 
            // _eliminaSettoreButton
            // 
            this._eliminaSettoreButton.HeaderText = "";
            this._eliminaSettoreButton.Name = "_eliminaSettoreButton";
            // 
            // SettoriView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this._aggiungiSettoreButton);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SettoriView";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button _aggiungiSettoreButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn _settoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _numPiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn _fabbisognoTotaleSettore;
        private System.Windows.Forms.DataGridViewButtonColumn _pianteButton;
        private System.Windows.Forms.DataGridViewButtonColumn _eliminaSettoreButton;
    }
}
