namespace SmartGarden.View
{
    partial class MeteoView
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
            this._temperaturaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._precipitazioniTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._pressioneTextBox = new System.Windows.Forms.TextBox();
            this._umiditàLabel = new System.Windows.Forms.Label();
            this._umiditàTextBox = new System.Windows.Forms.TextBox();
            this._meteoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._meteoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // _temperaturaTextBox
            // 
            this._temperaturaTextBox.Location = new System.Drawing.Point(127, 159);
            this._temperaturaTextBox.Name = "_temperaturaTextBox";
            this._temperaturaTextBox.ReadOnly = true;
            this._temperaturaTextBox.Size = new System.Drawing.Size(100, 20);
            this._temperaturaTextBox.TabIndex = 0;
            this._temperaturaTextBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precipitazioni:";
            // 
            // _precipitazioniTextBox
            // 
            this._precipitazioniTextBox.Location = new System.Drawing.Point(369, 159);
            this._precipitazioniTextBox.Name = "_precipitazioniTextBox";
            this._precipitazioniTextBox.ReadOnly = true;
            this._precipitazioniTextBox.Size = new System.Drawing.Size(100, 20);
            this._precipitazioniTextBox.TabIndex = 2;
            this._precipitazioniTextBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pressione:";
            // 
            // _pressioneTextBox
            // 
            this._pressioneTextBox.Location = new System.Drawing.Point(127, 214);
            this._pressioneTextBox.Name = "_pressioneTextBox";
            this._pressioneTextBox.ReadOnly = true;
            this._pressioneTextBox.Size = new System.Drawing.Size(100, 20);
            this._pressioneTextBox.TabIndex = 4;
            this._pressioneTextBox.TabStop = false;
            // 
            // _umiditàLabel
            // 
            this._umiditàLabel.AutoSize = true;
            this._umiditàLabel.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._umiditàLabel.Location = new System.Drawing.Point(300, 216);
            this._umiditàLabel.Name = "_umiditàLabel";
            this._umiditàLabel.Size = new System.Drawing.Size(63, 15);
            this._umiditàLabel.TabIndex = 7;
            this._umiditàLabel.Text = "Umidità:";
            // 
            // _umiditàTextBox
            // 
            this._umiditàTextBox.Location = new System.Drawing.Point(369, 214);
            this._umiditàTextBox.Name = "_umiditàTextBox";
            this._umiditàTextBox.ReadOnly = true;
            this._umiditàTextBox.Size = new System.Drawing.Size(100, 20);
            this._umiditàTextBox.TabIndex = 6;
            this._umiditàTextBox.TabStop = false;
            // 
            // _meteoPictureBox
            // 
            this._meteoPictureBox.Location = new System.Drawing.Point(203, 14);
            this._meteoPictureBox.Name = "_meteoPictureBox";
            this._meteoPictureBox.Size = new System.Drawing.Size(95, 81);
            this._meteoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._meteoPictureBox.TabIndex = 12;
            this._meteoPictureBox.TabStop = false;
            // 
            // MeteoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this._meteoPictureBox);
            this.Controls.Add(this._umiditàLabel);
            this.Controls.Add(this._umiditàTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._pressioneTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._precipitazioniTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._temperaturaTextBox);
            this.Name = "MeteoView";
            this.Size = new System.Drawing.Size(499, 283);
            ((System.ComponentModel.ISupportInitialize)(this._meteoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _temperaturaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _precipitazioniTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _pressioneTextBox;
        private System.Windows.Forms.Label _umiditàLabel;
        private System.Windows.Forms.TextBox _umiditàTextBox;
        private System.Windows.Forms.PictureBox _meteoPictureBox;
    }
}
