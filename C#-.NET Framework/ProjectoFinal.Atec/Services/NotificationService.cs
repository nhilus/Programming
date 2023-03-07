using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore;
using ProjetoFinal.Migrations;
using ProjetoFinal.Models.Notification;
using ProjetoFinal.Web.Blazor.Hubs;

namespace ProjetoFinal.Web.Blazor.Services
{
    public class NotificationService
    {
        private NavigationManager navigationManager;
        private PfaDbContext dbContext;

        public NotificationService(NavigationManager _navigationManager, IDbContextFactory<PfaDbContext> _dbFactory)
        {
            navigationManager = _navigationManager;
            dbContext = _dbFactory.CreateDbContext();
        }

        public async Task SendAsync(Notification notification)
        {
            // SignalR client
            HubConnection hubConnection = new HubConnectionBuilder()
                .WithUrl(navigationManager.BaseUri.TrimEnd('/') + NotificationHub.HubUrl)
                .Build();

            await hubConnection.StartAsync();

            dbContext.Notifications.Add(notification);
            dbContext.SaveChanges();

            await hubConnection.SendAsync("Broadcast", notification);
        }
    }
}
