using catedra1.src.Dtos;
using Microsoft.AspNetCore.Mvc;


namespace catedra1.src.Controller
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("")]

        public IResult CreateUser(CreateUserDto createUserDto){
            
            
        }

    }
}