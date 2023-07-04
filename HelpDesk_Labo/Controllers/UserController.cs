
using API_HelpDesk_Labo.ViewModel;
using BLL.Repositories;
using BLL.Repositories.DTOs.User;
using DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace API_HelpDesk_Labo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepositoryBLL _userService;

        public UserController(IUserRepositoryBLL userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] CreateUserDTO createUserDto)
        {
            if(ModelState.IsValid) 
            {
                _userService.Create(createUserDto);
                return Ok();
            }
            return BadRequest();
        }

        public ActionResult<IEnumerable<UserViewModel>> GetAll() 
        {
            return Ok(_userService.GetAll());
        }
    }

    
}
