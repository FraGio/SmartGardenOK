using SmartGarden.Model;
using System;

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
            _messagePump.newMessage += RefreshNotifiche;
        }

        private void RefreshNotifiche(object sender, EventArgs e)
        {
            _notificheTextBox.Clear();
            _messagePump.GetAllMEssages();
        }

        private void _pulisciButton_Click(object sender, EventArgs e)
        {
            _messagePump.DeleteMessages();
            _notificheTextBox.Clear();
        }
    }
}
