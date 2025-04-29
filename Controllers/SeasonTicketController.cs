using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportClub;
using SportClubAPI.Models;

namespace SportClubAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SeasonTicketController : Controller
    {
        private readonly SportClubDbContext context;
        private readonly IMapper mapper;

        public SeasonTicketController(IMapper mapper, SportClubDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost]
        public IActionResult CreateSeasonTicket(CreateSeasonTicketModel seasonTicket)
        {
            context.SeasonTickets.Add(mapper.Map<SeasonTicket>(seasonTicket));
            context.SaveChanges();
            return Created();
        }

        [HttpGet]
        public IActionResult GetAllSeasonTickets()
        {
            return Ok(context.SeasonTickets.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = context.SeasonTickets.Find(id);
            if (item == null) { return NotFound(); }
            return Ok(item);
        }

        [HttpPut]
        public IActionResult UpdateSeasonTicket(SeasonTicket seasonTicket)
        {
            context.SeasonTickets.Update(seasonTicket);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteSeasonTicket(int Id)
        {
            var item = context.SeasonTickets.Find(Id);
            if (item == null) { return NotFound(); }
            context.SeasonTickets.Remove(item);
            return NoContent();
        }
    }
}
