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
        public int Id { get; set; } // OK

        public string Title { get; set; } 

        public string Description { get; set; }  // OK

        public DateTime StartDate { get; set; } = DateTime.Now; // OK 

        public DateTime EndDate { get; set; }  // OK

        public string Attachment { get; set; } // OK


        public string StatusCode { get; set; } //OK
   

        public Priorities Priority { get; set; } // OK

        public TicketSettings TicketSettings { get; set; } // OK

        public TicketType TicketType { get; set; } // OK

        public TicketStatuses TicketStatuses { get; set; } // OK

        //public string level { get; set; } // OK

        //public string TypeTicket { get; set; } 

        //public DateTime Created { get; set; } // OK

        //public DateTime Updated { get; set; } // OK

        //public DateTime Deleted { get; set; } // OK 


    }
}
