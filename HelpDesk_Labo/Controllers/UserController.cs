
using BLL.Repositories;
using DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using BLL.Entities.DTOs.User;
using BLL.Entities.Mappers;
using BLL.Entities.ViewModel;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;

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

        [HttpDelete("{Id}")]
        
        public async Task<IActionResult> Delete(int Id)
        {
            if (ModelState.IsValid) 
            {
                var success = await _userService.Delete(Id);
                return  success ? Ok() : NotFound();


            }
            return BadRequest();
                
        }

        
        [HttpGet]
        public async Task<IActionResult> GetAll() 
        {
            return Ok(await _userService.GetAll());
        }

        [HttpGet("{Id:int}")]
        public async Task<IActionResult> GetById(int Id)
        {
            return Ok(await _userService.GetById(Id));
        }

        [HttpGet("email/{Email}")]
        public async Task<IActionResult> GetByEmail(string Email)
        {
            return Ok(await _userService.GetByEmail(Email));
        }


        [HttpPatch("data/{Id}")]
        public async Task<IActionResult> UpdateDatas(int Id, ChangeDataDTO changeDataDTO)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (ModelState.IsValid)
            {
                UserViewModel? userViewModel = await _userService.UpdateDatas(Id, changeDataDTO);

                if (userViewModel != null)
                {
                    return Ok(userViewModel);
                }
            }

            return BadRequest();
          
        }

        [HttpPatch("Role/{Id}")]
        public async Task<IActionResult> UpdateRole(int Id, ChangeRoleDTO changeRoleDTO)
        {

            if (ModelState.IsValid)
            {
                UserViewModel? userViewModel = await _userService.UpdateRole(Id, changeRoleDTO);

                if (userViewModel != null)
                {
                    return Ok(userViewModel);
                }
            }

            return BadRequest();

        }

        [HttpPatch("Password/{Id}")]
        public async Task<IActionResult> UpdatePassword(int Id, ChangePasswordDTO changePassword)
        {

            if (ModelState.IsValid)
            {
                UserViewModel? userViewModel = await _userService.UpdatePassword(Id, changePassword);

                if (userViewModel != null)
                {
                    return Ok(userViewModel);
                }
            }

            return BadRequest();

        }










    }




}
