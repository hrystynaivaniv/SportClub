using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SportClub;
using SportClubAPI.Models;

namespace SportClubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HallController : Controller
    {
        private SportClubDbContext context;
        private readonly IMapper mapper;

        public HallController(IMapper mapper, SportClubDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost]
        public IActionResult CreateHall(CreateHallModel hall)
        {
            context.Halls.Add(mapper.Map<Hall>(hall));
            context.SaveChanges();
            return Created();
        }

        [HttpGet]
        public IActionResult GetAllHalls()
        {
            return Ok(context.Halls.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = context.Halls.Find(id);
            if (item == null) { return NotFound(); }
            return Ok(item);
        }

        [HttpPut]
        public IActionResult UpdateHall(Hall hall)
        {
            context.Halls.Update(hall);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteHall(int Id)
        {
            var item = context.Halls.Find(Id);
            if (item == null) { return NotFound(); }
            context.Halls.Remove(item);
            return NoContent();
        }
    }
}
