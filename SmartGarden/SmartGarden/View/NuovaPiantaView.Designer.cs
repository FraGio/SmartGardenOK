namespace SmartGarden.View
{
    partial class NuovaPiantaView
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
            this._aggiungiButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._nomeBotanicoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._nomeComuneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._areaTextBox = new System.Windows.Forms.TextBox();
            this._fabbisognoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._inizioDatePicker = new System.Windows.Forms.DateTimePicker();
            this._fineDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _aggiungiButton
            // 
            this._aggiungiButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._aggiungiButton.Location = new System.Drawing.Point(176, 286);
            this._aggiungiButton.Name = "_aggiungiButton";
            this._aggiungiButton.Size = new System.Drawing.Size(75, 23);
            this._aggiungiButton.TabIndex = 13;
            this._aggiungiButton.Text = "Aggiungi";
            this._aggiungiButton.UseVisualStyleBackColor = true;
            this._aggiungiButton.Click += new System.EventHandler(this._aggiungiButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Area:";
            // 
            // _nomeBotanicoTextBox
            // 
            this._nomeBotanicoTextBox.Location = new System.Drawing.Point(212, 48);
            this._nomeBotanicoTextBox.Name = "_nomeBotanicoTextBox";
            this._nomeBotanicoTextBox.Size = new System.Drawing.Size(129, 20);
            this._nomeBotanicoTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome botanico:";
            // 
            // _nomeComuneTextBox
            // 
            this._nomeComuneTextBox.Location = new System.Drawing.Point(212, 13);
            this._nomeComuneTextBox.Name = "_nomeComuneTextBox";
            this._nomeComuneTextBox.Size = new System.Drawing.Size(129, 20);
            this._nomeComuneTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome comune:";
            // 
            // _areaTextBox
            // 
            this._areaTextBox.Location = new System.Drawing.Point(212, 89);
            this._areaTextBox.Name = "_areaTextBox";
            this._areaTextBox.Size = new System.Drawing.Size(129, 20);
            this._areaTextBox.TabIndex = 14;
            // 
            // _fabbisognoTextBox
            // 
            this._fabbisognoTextBox.Location = new System.Drawing.Point(209, 111);
            this._fabbisognoTextBox.Name = "_fabbisognoTextBox";
            this._fabbisognoTextBox.Size = new System.Drawing.Size(129, 20);
            this._fabbisognoTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Inizio periodo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fine periodo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quantità acqua (mm):";
            // 
            // _inizioDatePicker
            // 
            this._inizioDatePicker.Location = new System.Drawing.Point(209, 20);
            this._inizioDatePicker.Name = "_inizioDatePicker";
            this._inizioDatePicker.Size = new System.Drawing.Size(175, 20);
            this._inizioDatePicker.TabIndex = 21;
            // 
            // _fineDatePicker
            // 
            this._fineDatePicker.Location = new System.Drawing.Point(209, 65);
            this._fineDatePicker.Name = "_fineDatePicker";
            this._fineDatePicker.Size = new System.Drawing.Size(175, 20);
            this._fineDatePicker.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._fineDatePicker);
            this.groupBox1.Controls.Add(this._fabbisognoTextBox);
            this.groupBox1.Controls.Add(this._inizioDatePicker);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(3, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 141);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fabbisogno giornaliero";
            // 
            // NuovaPiantaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._areaTextBox);
            this.Controls.Add(this._aggiungiButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._nomeBotanicoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._nomeComuneTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NuovaPiantaView";
            this.Size = new System.Drawing.Size(413, 321);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _aggiungiButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _nomeBotanicoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _nomeComuneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _areaTextBox;
        private System.Windows.Forms.TextBox _fabbisognoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker _inizioDatePicker;
        private System.Windows.Forms.DateTimePicker _fineDatePicker;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
