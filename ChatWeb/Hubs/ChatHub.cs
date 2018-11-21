using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace ChatWeb.Hubs
{
    [HubName("ChatHub")]
    public class ChatHub : Hub
    {
        public void ClientToServer(string user, string message)
        {
            Clients.All.ServerToClient(user,message);
        }
    }
}