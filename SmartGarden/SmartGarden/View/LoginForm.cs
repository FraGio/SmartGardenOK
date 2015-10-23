using System;
using System.Windows.Forms;

namespace SmartGarden.View
{
    public partial class LoginForm : Form
    {
        private bool _isValid;

        public LoginForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _username.Text = Environment.UserName;
        }

        private void _loginButton_Click(object sender, EventArgs e)
        {
            string password = _passwordBox.Text;


            /*using (PrincipalContext pc = new PrincipalContext(ContextType.Machine))
            {
                _isValid = pc.ValidateCredentials(Environment.UserName, password);
            }*/
            _isValid = true;

            if (_isValid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Password non corretta!");
                _passwordBox.Clear();
            }

        }

        private void _resetButton_Click(object sender, EventArgs e)
        {
            _passwordBox.Clear();
        }

        private void _passwordLabel_Click(object sender, EventArgs e)
        {
            //nothing
        }
    }
}
