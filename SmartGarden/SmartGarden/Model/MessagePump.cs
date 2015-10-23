using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    class MessagePump:IMessagePump
    {
        public event EventHandler newMessage;
        private List<String> _messages;
        private static MessagePump instance = null;

        public static MessagePump GetMessagePump()
        {
            if (instance == null)
                instance = new MessagePump();
            return instance;
        }

        private MessagePump()
        {
            _messages = new List<string>();
        }

        protected virtual void OnNewMessage()
        {
            if (newMessage != null)
                newMessage(this, EventArgs.Empty);
        }

        public void SendMessage(string mess)
        {
            _messages.Add(mess);
            OnNewMessage();
        }

        public void DeleteMessages()
        {
            _messages = new List<string>();
        }
    }
}
