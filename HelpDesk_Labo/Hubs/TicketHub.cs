using Microsoft.AspNetCore.SignalR;

namespace API_HelpDesk_Labo.Hubs
{
    public class TicketHub : Hub
    {
        public async Task NotifyNewTicket()
        {
            await Clients.All.SendAsync("newTicket");
        }
    }
}
