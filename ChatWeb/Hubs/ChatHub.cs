﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatWeb.Hubs
{
    public class ChatHub : Hub
    {
        public void ClientToServer(string user, string message)
        {
            Clients.All.ServerToClient(user,message);
        }
    }
}