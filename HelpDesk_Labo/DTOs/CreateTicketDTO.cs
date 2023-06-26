using Domain.Enums;

namespace API_HelpDesk_Labo.DTOs
{
    public class CreateTicketDTO
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Attachment { get; set; }

        public TicketType TicketType { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;

        

    }
}
