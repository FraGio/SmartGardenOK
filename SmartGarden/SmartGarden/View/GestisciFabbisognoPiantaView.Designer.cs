namespace SmartGarden.View
{
    partial class GestisciFabbisognoPiantaView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._aggiungiButton = new System.Windows.Forms.Button();
            this._idPiantaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._quantitàAcquaTextBox = new System.Windows.Forms.TextBox();
            this._fineDatePicker = new System.Windows.Forms.DateTimePicker();
            this._inizioDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._fabbisogniTextBox = new System.Windows.Forms.TextBox();
            this._rimuoviButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._rimuoviButton);
            this.splitContainer1.Panel1.Controls.Add(this._aggiungiButton);
            this.splitContainer1.Panel1.Controls.Add(this._idPiantaTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this._quantitàAcquaTextBox);
            this.splitContainer1.Panel1.Controls.Add(this._fineDatePicker);
            this.splitContainer1.Panel1.Controls.Add(this._inizioDatePicker);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._fabbisogniTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(535, 400);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 0;
            // 
            // _aggiungiButton
            // 
            this._aggiungiButton.Location = new System.Drawing.Point(219, 215);
            this._aggiungiButton.Name = "_aggiungiButton";
            this._aggiungiButton.Size = new System.Drawing.Size(75, 23);
            this._aggiungiButton.TabIndex = 8;
            this._aggiungiButton.Text = "Aggiungi";
            this._aggiungiButton.UseVisualStyleBackColor = true;
            this._aggiungiButton.Click += new System.EventHandler(this._aggiungiButton_Click);
            // 
            // _idPiantaTextBox
            // 
            this._idPiantaTextBox.Location = new System.Drawing.Point(219, 45);
            this._idPiantaTextBox.Name = "_idPiantaTextBox";
            this._idPiantaTextBox.ReadOnly = true;
            this._idPiantaTextBox.Size = new System.Drawing.Size(200, 20);
            this._idPiantaTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID pianta:";
            // 
            // _quantitàAcquaTextBox
            // 
            this._quantitàAcquaTextBox.Location = new System.Drawing.Point(219, 85);
            this._quantitàAcquaTextBox.Name = "_quantitàAcquaTextBox";
            this._quantitàAcquaTextBox.Size = new System.Drawing.Size(200, 20);
            this._quantitàAcquaTextBox.TabIndex = 5;
            // 
            // _fineDatePicker
            // 
            this._fineDatePicker.Location = new System.Drawing.Point(219, 166);
            this._fineDatePicker.Name = "_fineDatePicker";
            this._fineDatePicker.Size = new System.Drawing.Size(200, 20);
            this._fineDatePicker.TabIndex = 4;
            // 
            // _inizioDatePicker
            // 
            this._inizioDatePicker.Location = new System.Drawing.Point(219, 127);
            this._inizioDatePicker.Name = "_inizioDatePicker";
            this._inizioDatePicker.Size = new System.Drawing.Size(200, 20);
            this._inizioDatePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data fine:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data inizio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantità acqua (mm) :";
            // 
            // _fabbisogniTextBox
            // 
            this._fabbisogniTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._fabbisogniTextBox.Location = new System.Drawing.Point(0, 0);
            this._fabbisogniTextBox.Multiline = true;
            this._fabbisogniTextBox.Name = "_fabbisogniTextBox";
            this._fabbisogniTextBox.Size = new System.Drawing.Size(535, 117);
            this._fabbisogniTextBox.TabIndex = 0;
            // 
            // _rimuoviButton
            // 
            this._rimuoviButton.Location = new System.Drawing.Point(332, 215);
            this._rimuoviButton.Name = "_rimuoviButton";
            this._rimuoviButton.Size = new System.Drawing.Size(87, 23);
            this._rimuoviButton.TabIndex = 9;
            this._rimuoviButton.Text = "Rimuovi tutto";
            this._rimuoviButton.UseVisualStyleBackColor = true;
            this._rimuoviButton.Click += new System.EventHandler(this._rimuoviButton_Click);
            // 
            // GestisciFabbisognoPiantaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.splitContainer1);
            this.Name = "GestisciFabbisognoPiantaView";
            this.Size = new System.Drawing.Size(535, 400);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox _fabbisogniTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _aggiungiButton;
        private System.Windows.Forms.TextBox _idPiantaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _quantitàAcquaTextBox;
        private System.Windows.Forms.DateTimePicker _fineDatePicker;
        private System.Windows.Forms.DateTimePicker _inizioDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _rimuoviButton;
    }
}
