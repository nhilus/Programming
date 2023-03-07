using Microsoft.AspNetCore.SignalR;
using ProjetoFinal.Models.Message;

namespace ProjetoFinal.Web.Blazor.Hubs
{
    public class ChatHub : Hub
    {
        public const string HubUrl = "/sighub/chat";

        public async Task Broadcast(Message message)
        {
            await Clients.All.SendAsync("Broadcast", message);
        }
    }
}
