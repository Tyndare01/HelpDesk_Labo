
using BLL.Repositories;
using DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using BLL.Entities.DTOs.User;
using BLL.Entities.Mappers;
using BLL.Entities.ViewModel;
using Domain.Entities;

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
        
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            return Ok(await _userService.GetAll());
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            return Ok(await _userService.GetById(Id));
        }

        [HttpGet("{Email}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            return Ok(await _userService.GetByEmail(email));
        }

    }



    
}
