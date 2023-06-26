using BLL.Repositories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TicketService : ITicketRepository
    {
        private readonly ITicketRepository _TicketService;

        public void AddTicket(Ticket ticket)
        {
            _TicketService.AddTicket(ticket);
        }

        public async Task<IEnumerable<Ticket>> GetAll()
        {
           return await _TicketService.GetAll();

        }

        public async Task<Ticket> GetById(int Id)
        {
            return await _TicketService.GetById(Id);

        }
    }
}
