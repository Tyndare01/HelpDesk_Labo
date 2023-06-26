using Microsoft.AspNetCore.Mvc;

namespace API_HelpDesk_Labo.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
