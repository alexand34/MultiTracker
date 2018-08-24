using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultiTracker.Data.Entities;
using MultiTracker.Services.Interfaces;

namespace MultiTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarService _service;
        public CalendarController(ICalendarService service)
        {
            this._service = service;
        }

        [HttpPost]
        [Route("api/[controller]/additem")]
        public async Task AddItem([FromBody] CalendarItem model)
        {
            await _service.AddEvent(model);
        }

        [HttpGet]
        public async Task<string> Get()
        {
            return "hello";
        }
    }
}