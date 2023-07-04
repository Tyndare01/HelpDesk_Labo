using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace API_HelpDesk_Labo.DTOs
{
    public class CreateTicketDTO
    {
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Attachment { get; set; }

        [Required]
        public TicketType TicketType { get; set; }

        private readonly DateTime _startDate = DateTime.Now;

        public DateTime StartDate
        {
            get { return _startDate; }
        } 
             
         


    }
}
