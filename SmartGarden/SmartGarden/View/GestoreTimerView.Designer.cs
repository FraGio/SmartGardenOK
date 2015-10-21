namespace SmartGarden.View
{
    partial class GestoreTimerView
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
            this._oreComboBox = new System.Windows.Forms.ComboBox();
            this._minutiComboBox = new System.Windows.Forms.ComboBox();
            this._irrigazioneTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._confermaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._minutiInizioCombobox = new System.Windows.Forms.ComboBox();
            this._oreInizioComboBox = new System.Windows.Forms.ComboBox();
            this._giornoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _oreComboBox
            // 
            this._oreComboBox.FormattingEnabled = true;
            this._oreComboBox.Location = new System.Drawing.Point(76, 56);
            this._oreComboBox.Name = "_oreComboBox";
            this._oreComboBox.Size = new System.Drawing.Size(78, 21);
            this._oreComboBox.TabIndex = 2;
            // 
            // _minutiComboBox
            // 
            this._minutiComboBox.FormattingEnabled = true;
            this._minutiComboBox.Location = new System.Drawing.Point(76, 83);
            this._minutiComboBox.Name = "_minutiComboBox";
            this._minutiComboBox.Size = new System.Drawing.Size(78, 21);
            this._minutiComboBox.TabIndex = 3;
            // 
            // _irrigazioneTextBox
            // 
            this._irrigazioneTextBox.Location = new System.Drawing.Point(267, 208);
            this._irrigazioneTextBox.Name = "_irrigazioneTextBox";
            this._irrigazioneTextBox.ReadOnly = true;
            this._irrigazioneTextBox.Size = new System.Drawing.Size(115, 20);
            this._irrigazioneTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giorno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ore: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Minuti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Prossima irrigazione:";
            // 
            // _confermaButton
            // 
            this._confermaButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._confermaButton.Enabled = false;
            this._confermaButton.Location = new System.Drawing.Point(202, 149);
            this._confermaButton.Name = "_confermaButton";
            this._confermaButton.Size = new System.Drawing.Size(75, 23);
            this._confermaButton.TabIndex = 10;
            this._confermaButton.Text = "Conferma";
            this._confermaButton.UseVisualStyleBackColor = true;
            this._confermaButton.Click += new System.EventHandler(this._confermaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Minuti:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ore:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._giornoTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._oreComboBox);
            this.groupBox1.Controls.Add(this._minutiComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(260, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 115);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervallo ripetizione";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._oreInizioComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this._minutiInizioCombobox);
            this.groupBox2.Location = new System.Drawing.Point(20, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 115);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ora inizio irrigazione";
            // 
            // _minutiInizioCombobox
            // 
            this._minutiInizioCombobox.FormattingEnabled = true;
            this._minutiInizioCombobox.Location = new System.Drawing.Point(76, 56);
            this._minutiInizioCombobox.Name = "_minutiInizioCombobox";
            this._minutiInizioCombobox.Size = new System.Drawing.Size(78, 21);
            this._minutiInizioCombobox.TabIndex = 12;
            // 
            // _oreInizioComboBox
            // 
            this._oreInizioComboBox.FormattingEnabled = true;
            this._oreInizioComboBox.Location = new System.Drawing.Point(76, 29);
            this._oreInizioComboBox.Name = "_oreInizioComboBox";
            this._oreInizioComboBox.Size = new System.Drawing.Size(78, 21);
            this._oreInizioComboBox.TabIndex = 11;
            // 
            // _giornoTextBox
            // 
            this._giornoTextBox.Location = new System.Drawing.Point(76, 29);
            this._giornoTextBox.Name = "_giornoTextBox";
            this._giornoTextBox.Size = new System.Drawing.Size(78, 20);
            this._giornoTextBox.TabIndex = 9;
            // 
            // GestoreTimerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._confermaButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._irrigazioneTextBox);
            this.Name = "GestoreTimerView";
            this.Size = new System.Drawing.Size(472, 289);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox _oreComboBox;
        private System.Windows.Forms.ComboBox _minutiComboBox;
        private System.Windows.Forms.TextBox _irrigazioneTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _confermaButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _giornoTextBox;
        private System.Windows.Forms.ComboBox _oreInizioComboBox;
        private System.Windows.Forms.ComboBox _minutiInizioCombobox;
    }
}
