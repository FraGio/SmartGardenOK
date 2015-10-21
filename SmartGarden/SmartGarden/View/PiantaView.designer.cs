namespace SmartGarden.View
{
    partial class PiantaView
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
            this._rimuoviButton = new System.Windows.Forms.Button();
            this._finalizzaButton = new System.Windows.Forms.Button();
            this._aggiungiButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._visitorComboBox = new System.Windows.Forms.ComboBox();
            this._providerComboBox = new System.Windows.Forms.ComboBox();
            this._textBox = new System.Windows.Forms.TextBox();
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
            this.splitContainer1.Panel1.Controls.Add(this._finalizzaButton);
            this.splitContainer1.Panel1.Controls.Add(this._aggiungiButton);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this._visitorComboBox);
            this.splitContainer1.Panel1.Controls.Add(this._providerComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._textBox);
            this.splitContainer1.Size = new System.Drawing.Size(584, 350);
            this.splitContainer1.SplitterDistance = 240;
            this.splitContainer1.TabIndex = 0;
            // 
            // _rimuoviButton
            // 
            this._rimuoviButton.Location = new System.Drawing.Point(330, 104);
            this._rimuoviButton.Name = "_rimuoviButton";
            this._rimuoviButton.Size = new System.Drawing.Size(75, 23);
            this._rimuoviButton.TabIndex = 10;
            this._rimuoviButton.Text = "Rimuovi";
            this._rimuoviButton.UseVisualStyleBackColor = true;
            this._rimuoviButton.Click += new System.EventHandler(this._rimuoviButton_Click);
            // 
            // _finalizzaButton
            // 
            this._finalizzaButton.Location = new System.Drawing.Point(235, 151);
            this._finalizzaButton.Name = "_finalizzaButton";
            this._finalizzaButton.Size = new System.Drawing.Size(75, 23);
            this._finalizzaButton.TabIndex = 9;
            this._finalizzaButton.Text = "Finalizza";
            this._finalizzaButton.UseVisualStyleBackColor = true;
            // 
            // _aggiungiButton
            // 
            this._aggiungiButton.Location = new System.Drawing.Point(235, 104);
            this._aggiungiButton.Name = "_aggiungiButton";
            this._aggiungiButton.Size = new System.Drawing.Size(75, 23);
            this._aggiungiButton.TabIndex = 8;
            this._aggiungiButton.Text = "Aggiungi";
            this._aggiungiButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elaboratore informazioni:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fornitore informazioni:";
            // 
            // _visitorComboBox
            // 
            this._visitorComboBox.FormattingEnabled = true;
            this._visitorComboBox.Location = new System.Drawing.Point(235, 64);
            this._visitorComboBox.Name = "_visitorComboBox";
            this._visitorComboBox.Size = new System.Drawing.Size(170, 21);
            this._visitorComboBox.TabIndex = 5;
            // 
            // _providerComboBox
            // 
            this._providerComboBox.FormattingEnabled = true;
            this._providerComboBox.Location = new System.Drawing.Point(235, 31);
            this._providerComboBox.Name = "_providerComboBox";
            this._providerComboBox.Size = new System.Drawing.Size(170, 21);
            this._providerComboBox.TabIndex = 4;
            // 
            // _textBox
            // 
            this._textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textBox.Location = new System.Drawing.Point(0, 0);
            this._textBox.Multiline = true;
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(584, 106);
            this._textBox.TabIndex = 0;
            // 
            // PiantaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.splitContainer1);
            this.Name = "PiantaView";
            this.Size = new System.Drawing.Size(584, 350);
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
        private System.Windows.Forms.Button _finalizzaButton;
        private System.Windows.Forms.Button _aggiungiButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _visitorComboBox;
        private System.Windows.Forms.ComboBox _providerComboBox;
        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.Button _rimuoviButton;
    }
}
