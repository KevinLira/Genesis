using Genesis.Common.DTO;
using Genesis.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Genesis.WebAPI.Controllers
{
    [Authorize()]
    public class UserController : Controller
    {

        UserService _service = new UserService();
        [HttpGet]
        [Route("api/User")]
        public string Index()
        {
            var teste = _service.Socorro();
            return "It Works";
        }

        [Route("api/User/SignIn")]
        [HttpPost]
        public JsonResult SignIn([FromBody]string user, string password)
        {
            return new JsonResult(_service.SignIn(user, password));
        }

        [Route("api/User/SignUp")]
        [HttpPost]
        public JsonResult SignUp([FromBody] UserDTO user)
        {
            return new JsonResult(_service.SignUp(user));
        }


        [Route("api/User/search/{user}")]
        [HttpGet]
        public JsonResult Search(string user)
        {
            return null;
        }
    }
   }
