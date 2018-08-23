using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MultiTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"value123", "value223"};
        }
    }
}