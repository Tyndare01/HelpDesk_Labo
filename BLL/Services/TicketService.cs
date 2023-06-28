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
       
        private readonly DAL.Repositories.ITicketRepository _TicketService;


        public TicketService(DAL.Repositories.ITicketRepository ticketService)
        {
            _TicketService = ticketService;
        }

        public void AddTicket(Ticket ticket)
        {
            _TicketService.AddTicket(ticket);
        }

        public async Task<IEnumerable<TicketView>> GetAll()
        {
           return await _TicketService.GetAll();

        }

        public async Task<Ticket> GetById(int Id)
        {
            return await _TicketService.GetById(Id);

        }
    }
}
