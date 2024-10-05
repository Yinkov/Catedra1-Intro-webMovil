using catedra1.src.Dtos;
using catedra1.src.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace catedra1.src.Controller
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository){
            _userRepository = userRepository;
        }
        [HttpPost("")]

        public async Task<IResult> CreateUser(CreateUserDto createUserDto){
            bool existe = await _userRepository.ExtistsByRut(createUserDto.Rut);

            if(existe){
                return TypedResults.Conflict("El rut ya esta en el sistema");
            }
            return TypedResults.Ok();
            
        }

        [HttpGet]

        public async Task<IActionResult> GetAllUser(){
            
            var users = await _userRepository.ListUser();
            return Ok(users);
            
        }


    }
}