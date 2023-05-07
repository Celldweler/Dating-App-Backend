using Microsoft.AspNetCore.Mvc;

namespace DatingApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public string Get() => "test controller is work!";
    }
}
