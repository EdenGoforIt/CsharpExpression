using Microsoft.AspNetCore.Mvc;

namespace Expression.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("{className}")]
        public async Task<IActionResult> GetUsers()
        {
           
        }
    }
}
