namespace SmartGarden.View
{
    partial class NuovoSettoreView
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
            this._nomeTextBox = new System.Windows.Forms.TextBox();
            this._portataImpiantoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._valvolaComboBox = new System.Windows.Forms.ComboBox();
            this._aggiungiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // _nomeTextBox
            // 
            this._nomeTextBox.Location = new System.Drawing.Point(135, 15);
            this._nomeTextBox.Name = "_nomeTextBox";
            this._nomeTextBox.Size = new System.Drawing.Size(129, 20);
            this._nomeTextBox.TabIndex = 1;
            // 
            // _portataImpiantoTextBox
            // 
            this._portataImpiantoTextBox.Location = new System.Drawing.Point(135, 50);
            this._portataImpiantoTextBox.Name = "_portataImpiantoTextBox";
            this._portataImpiantoTextBox.Size = new System.Drawing.Size(129, 20);
            this._portataImpiantoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Portata impianto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valvola:";
            // 
            // _valvolaComboBox
            // 
            this._valvolaComboBox.FormattingEnabled = true;
            this._valvolaComboBox.Location = new System.Drawing.Point(135, 91);
            this._valvolaComboBox.Name = "_valvolaComboBox";
            this._valvolaComboBox.Size = new System.Drawing.Size(129, 21);
            this._valvolaComboBox.TabIndex = 5;
            // 
            // _aggiungiButton
            // 
            this._aggiungiButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._aggiungiButton.Location = new System.Drawing.Point(135, 132);
            this._aggiungiButton.Name = "_aggiungiButton";
            this._aggiungiButton.Size = new System.Drawing.Size(75, 23);
            this._aggiungiButton.TabIndex = 6;
            this._aggiungiButton.Text = "Aggiungi";
            this._aggiungiButton.UseVisualStyleBackColor = true;
            this._aggiungiButton.Click += new System.EventHandler(this._aggiungiButton_Click);
            // 
            // NuovoSettoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this._aggiungiButton);
            this.Controls.Add(this._valvolaComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._portataImpiantoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._nomeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "NuovoSettoreView";
            this.Size = new System.Drawing.Size(324, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _nomeTextBox;
        private System.Windows.Forms.TextBox _portataImpiantoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _valvolaComboBox;
        private System.Windows.Forms.Button _aggiungiButton;
    }
}
