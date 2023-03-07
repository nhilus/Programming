using Microsoft.AspNetCore.SignalR;
using ProjetoFinal.Models.Notification;

namespace ProjetoFinal.Web.Blazor.Hubs
{
    public class NotificationHub : Hub
    {
        public const string HubUrl = "/sighub/notifications";

        public async Task Broadcast(Notification notification)
        {
            await Clients.All.SendAsync("Broadcast", notification);
        }
    }
}
