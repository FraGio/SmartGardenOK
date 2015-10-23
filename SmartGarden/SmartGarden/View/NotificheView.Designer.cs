namespace SmartGarden.View
{
    partial class NotificheView
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
            this._notificheTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._pulisciButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _notificheTextBox
            // 
            this._notificheTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._notificheTextBox.Location = new System.Drawing.Point(0, 24);
            this._notificheTextBox.Multiline = true;
            this._notificheTextBox.Name = "_notificheTextBox";
            this._notificheTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._notificheTextBox.Size = new System.Drawing.Size(550, 332);
            this._notificheTextBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // _pulisciButton
            // 
            this._pulisciButton.Location = new System.Drawing.Point(3, 0);
            this._pulisciButton.Name = "_pulisciButton";
            this._pulisciButton.Size = new System.Drawing.Size(118, 23);
            this._pulisciButton.TabIndex = 2;
            this._pulisciButton.Text = "Pulisci notifiche";
            this._pulisciButton.UseVisualStyleBackColor = true;
            this._pulisciButton.Click += new System.EventHandler(this._pulisciButton_Click);
            // 
            // NotificheView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this._pulisciButton);
            this.Controls.Add(this._notificheTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "NotificheView";
            this.Size = new System.Drawing.Size(550, 356);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _notificheTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button _pulisciButton;
    }
}
