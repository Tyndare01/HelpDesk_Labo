using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TicketView
    {
		public string Title { get; set; }

		public string Description { get; set; }

		public string Attachment { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now; // OK 

        public DateTime EndDate { get; set; }  // OK

        public string level { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime DeletionDate { get; set; }

        public string StatusCode { get; set; }

        public string TypeName { get; set; }



    }
}
