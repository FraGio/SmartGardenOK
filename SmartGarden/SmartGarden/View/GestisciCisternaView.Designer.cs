namespace SmartGarden.View
{
    partial class GestisciCisternaView
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
            this.label1 = new System.Windows.Forms.Label();
            this._guidCisternaTextBox = new System.Windows.Forms.TextBox();
            this._portataTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._capacitàTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._nuovaCisternaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._nuovaPortataTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._creaButton = new System.Windows.Forms.Button();
            this._sensorePressioneComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._valvolaSicurezzaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id cisterna:";
            // 
            // _guidCisternaTextBox
            // 
            this._guidCisternaTextBox.Location = new System.Drawing.Point(103, 24);
            this._guidCisternaTextBox.Name = "_guidCisternaTextBox";
            this._guidCisternaTextBox.ReadOnly = true;
            this._guidCisternaTextBox.Size = new System.Drawing.Size(85, 20);
            this._guidCisternaTextBox.TabIndex = 1;
            // 
            // _portataTextBox
            // 
            this._portataTextBox.Location = new System.Drawing.Point(103, 61);
            this._portataTextBox.Name = "_portataTextBox";
            this._portataTextBox.ReadOnly = true;
            this._portataTextBox.Size = new System.Drawing.Size(85, 20);
            this._portataTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Portata:";
            // 
            // _capacitàTextBox
            // 
            this._capacitàTextBox.Location = new System.Drawing.Point(103, 101);
            this._capacitàTextBox.Name = "_capacitàTextBox";
            this._capacitàTextBox.ReadOnly = true;
            this._capacitàTextBox.Size = new System.Drawing.Size(85, 20);
            this._capacitàTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Capacità:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this._valvolaSicurezzaComboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this._sensorePressioneComboBox);
            this.groupBox1.Controls.Add(this._creaButton);
            this.groupBox1.Controls.Add(this._nuovaCisternaTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._nuovaPortataTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(242, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 208);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crea cisterna";
            // 
            // _nuovaCisternaTextBox
            // 
            this._nuovaCisternaTextBox.Location = new System.Drawing.Point(145, 66);
            this._nuovaCisternaTextBox.Name = "_nuovaCisternaTextBox";
            this._nuovaCisternaTextBox.Size = new System.Drawing.Size(87, 20);
            this._nuovaCisternaTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Capacità:";
            // 
            // _nuovaPortataTextBox
            // 
            this._nuovaPortataTextBox.Location = new System.Drawing.Point(145, 26);
            this._nuovaPortataTextBox.Name = "_nuovaPortataTextBox";
            this._nuovaPortataTextBox.Size = new System.Drawing.Size(87, 20);
            this._nuovaPortataTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Portata:";
            // 
            // _creaButton
            // 
            this._creaButton.Enabled = false;
            this._creaButton.Location = new System.Drawing.Point(89, 179);
            this._creaButton.Name = "_creaButton";
            this._creaButton.Size = new System.Drawing.Size(75, 23);
            this._creaButton.TabIndex = 10;
            this._creaButton.Text = "Crea";
            this._creaButton.UseVisualStyleBackColor = true;
            // 
            // _sensorePressioneComboBox
            // 
            this._sensorePressioneComboBox.FormattingEnabled = true;
            this._sensorePressioneComboBox.Location = new System.Drawing.Point(145, 102);
            this._sensorePressioneComboBox.Name = "_sensorePressioneComboBox";
            this._sensorePressioneComboBox.Size = new System.Drawing.Size(87, 21);
            this._sensorePressioneComboBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this._guidCisternaTextBox);
            this.groupBox2.Controls.Add(this._capacitàTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this._portataTextBox);
            this.groupBox2.Location = new System.Drawing.Point(14, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 208);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cisterna attuale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sensore pressione:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valvola sicurezza:";
            // 
            // _valvolaSicurezzaComboBox
            // 
            this._valvolaSicurezzaComboBox.FormattingEnabled = true;
            this._valvolaSicurezzaComboBox.Location = new System.Drawing.Point(145, 139);
            this._valvolaSicurezzaComboBox.Name = "_valvolaSicurezzaComboBox";
            this._valvolaSicurezzaComboBox.Size = new System.Drawing.Size(87, 21);
            this._valvolaSicurezzaComboBox.TabIndex = 12;
            // 
            // GestisciCisternaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestisciCisternaView";
            this.Size = new System.Drawing.Size(512, 244);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _guidCisternaTextBox;
        private System.Windows.Forms.TextBox _portataTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _capacitàTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _nuovaCisternaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _nuovaPortataTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _creaButton;
        private System.Windows.Forms.ComboBox _sensorePressioneComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _valvolaSicurezzaComboBox;
        private System.Windows.Forms.Label label6;
    }
}
