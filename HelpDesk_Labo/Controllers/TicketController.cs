using API_HelpDesk_Labo.DTOs.Ticket;
using API_HelpDesk_Labo.Hubs;
using API_HelpDesk_Labo.Mappers;
using BLL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace API_HelpDesk_Labo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TicketController : ControllerBase
    {
        private readonly ITicketRepository ticketService;
        private readonly TicketHub _ticketHub;

        public TicketController(ITicketRepository ticketService, TicketHub ticketHub)
        {
            this.ticketService = ticketService;
            _ticketHub = ticketHub;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await ticketService.GetAll());
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await ticketService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTicketDTO ticketDTO, int Id_User)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            ticketService.AddTicket(ticketDTO.ToTicket(), Id_User);
            await _ticketHub.NotifyNewTicket();
            return Ok();
        }

        // [FromBody] permet de désérialiser automatiquement les données JSON envoyées dans le corps de la requête
        // en un objet de type CreateTicketDTO

    }
}
