using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportClub;
using SportClubAPI.Models;
namespace SportClubAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ScheduleController : Controller
    {
        private readonly SportClubDbContext context;
        private readonly IMapper mapper;

        public ScheduleController(IMapper mapper, SportClubDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost]
        public IActionResult CreateSchedule(CreateScheduleModel schedule)
        {
            context.Schedules.Add(mapper.Map<Schedule>(schedule));
            context.SaveChanges();
            return Created();
        }

        [HttpGet]
        public IActionResult GetAllSchedules()
        {
            return Ok(context.Schedules.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = context.Schedules.Find(id);
            if (item == null) { return NotFound(); }
            return Ok(item);
        }

        [HttpPut]
        public IActionResult UpdateSchedule(Schedule schedule)
        {
            context.Schedules.Update(schedule);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteSchedule(int Id)
        {
            var item = context.Schedules.Find(Id);
            if (item == null) { return NotFound(); }
            context.Schedules.Remove(item);
            return NoContent();
        }
    }
}
