using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndDate { get; set; } 

        public string Attachment { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        public DateTime Deleted { get; set; }

        public string TypeTicket { get; set; }

        public Priorities Priority { get; set; }

        public TicketSettings TicketSettings { get; set; }

        public TicketType TicketType { get; set; }


    }
}
