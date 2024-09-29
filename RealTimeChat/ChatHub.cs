using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealTimeChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Broadcast message to all clients
            Clients.All.broadcastMessage(name, message);
        }
    }
}