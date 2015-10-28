﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    public interface IMessagePump
    {
        event EventHandler newMessage;

        void SendMessage(string mess);

        void DeleteMessages();

        List<string> GetAllMEssages();
    }
}
