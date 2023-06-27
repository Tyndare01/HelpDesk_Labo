using API_HelpDesk_Labo.DTOs;
using Domain.Entities;
using System.Runtime.InteropServices;

namespace API_HelpDesk_Labo.Mappers
{
    public static class TicketMapper
    {
        public static Ticket ToTicket(this CreateTicketDTO ticketDTO)
        {
            return new Ticket
            {
                Title = ticketDTO.Title,
                Description = ticketDTO.Description,
                Attachment = ticketDTO.Attachment,
                StartDate = ticketDTO.StartDate,
            };
        }
    }
}
