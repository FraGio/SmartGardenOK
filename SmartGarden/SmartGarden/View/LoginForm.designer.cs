namespace SmartGarden
{
    partial class LoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this._panel = new System.Windows.Forms.Panel();
            this._username = new System.Windows.Forms.Label();
            this._resetButton = new System.Windows.Forms.Button();
            this._loginButton = new System.Windows.Forms.Button();
            this._passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _panel
            // 
            this._panel.BackColor = System.Drawing.Color.Silver;
            this._panel.Controls.Add(this._username);
            this._panel.Controls.Add(this._resetButton);
            this._panel.Controls.Add(this._loginButton);
            this._panel.Controls.Add(this._passwordBox);
            this._panel.Controls.Add(this.label1);
            this._panel.Controls.Add(this._passwordLabel);
            this._panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel.Location = new System.Drawing.Point(0, 0);
            this._panel.MaximumSize = new System.Drawing.Size(415, 191);
            this._panel.MinimumSize = new System.Drawing.Size(415, 191);
            this._panel.Name = "_panel";
            this._panel.Size = new System.Drawing.Size(415, 191);
            this._panel.TabIndex = 0;
            // 
            // _username
            // 
            this._username.AutoSize = true;
            this._username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._username.Location = new System.Drawing.Point(226, 38);
            this._username.Name = "_username";
            this._username.Size = new System.Drawing.Size(76, 25);
            this._username.TabIndex = 10;
            this._username.Text = "*user*";
            // 
            // _resetButton
            // 
            this._resetButton.Location = new System.Drawing.Point(231, 117);
            this._resetButton.Name = "_resetButton";
            this._resetButton.Size = new System.Drawing.Size(75, 23);
            this._resetButton.TabIndex = 7;
            this._resetButton.Text = "Reset";
            this._resetButton.UseVisualStyleBackColor = true;
            this._resetButton.Click += new System.EventHandler(this._resetButton_Click);
            // 
            // _loginButton
            // 
            this._loginButton.Location = new System.Drawing.Point(149, 117);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(75, 23);
            this._loginButton.TabIndex = 6;
            this._loginButton.Text = "Login";
            this._loginButton.UseVisualStyleBackColor = true;
            this._loginButton.Click += new System.EventHandler(this._loginButton_Click);
            // 
            // _passwordBox
            // 
            this._passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordBox.Location = new System.Drawing.Point(149, 89);
            this._passwordBox.MaxLength = 0;
            this._passwordBox.Name = "_passwordBox";
            this._passwordBox.PasswordChar = '*';
            this._passwordBox.Size = new System.Drawing.Size(157, 22);
            this._passwordBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Benvenuto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordLabel.Location = new System.Drawing.Point(72, 92);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(71, 16);
            this._passwordLabel.TabIndex = 3;
            this._passwordLabel.Text = "Password:";
            this._passwordLabel.Click += new System.EventHandler(this._passwordLabel_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this._loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(415, 191);
            this.Controls.Add(this._panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(431, 230);
            this.MinimumSize = new System.Drawing.Size(431, 230);
            this.Name = "LoginForm";
            this.Text = "Login";
            this._panel.ResumeLayout(false);
            this._panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.Button _resetButton;
        private System.Windows.Forms.Button _loginButton;
        private System.Windows.Forms.TextBox _passwordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Label _username;

    }
}