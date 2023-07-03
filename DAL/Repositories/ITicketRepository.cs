using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repositories
{
    public interface ITicketRepository
    {
        public void AddTicket (Ticket ticket, int Id_User);
        Task <TicketView> GetById (int Id);
        Task <IEnumerable<TicketView>> GetAll();

    }
}
