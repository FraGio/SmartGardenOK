using SmartGarden.Model;
using System;
using System.Windows.Forms;

namespace SmartGarden.View
{
    partial class NotificheView : MainView
    {
        private IMessagePump _messagePump;

        public NotificheView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _messagePump = MessagePump.GetMessagePump();
            _notificheTextBox.Clear();
            foreach (string notifica in _messagePump.GetAllMEssages())
            {
                _notificheTextBox.AppendText(notifica + Environment.NewLine);
            }
        }

        private void _pulisciButton_Click(object sender, EventArgs e)
        {
            _messagePump.DeleteMessages();
            _notificheTextBox.Clear();
        }
    }
}
