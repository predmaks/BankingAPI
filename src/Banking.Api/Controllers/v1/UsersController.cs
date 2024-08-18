using Microsoft.AspNetCore.Mvc;

namespace Banking.Api.Controllers.v1
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
