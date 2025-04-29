using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportClub;
using SportClubAPI.Models;

namespace SportClubAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainerController : Controller
    {
        private readonly SportClubDbContext context;
        private readonly IMapper mapper;

        public TrainerController(IMapper mapper, SportClubDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost]
        public IActionResult CreateTrainer(CreateTrainerModel trainer)
        {
            context.Trainers.Add(mapper.Map<Trainer>(trainer));
            context.SaveChanges();
            return Created();
        }

        [HttpGet]
        public IActionResult GetAllTrainers()
        {
            return Ok(context.Trainers.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = context.Trainers.Find(id);
            if (item == null) { return NotFound(); }
            return Ok(item);
        }

        [HttpPut]
        public IActionResult UpdateTrainer(Trainer trainer)
        {
            context.Trainers.Update(trainer);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTrainer(int Id)
        {
            var item = context.Trainers.Find(Id);
            if (item == null) { return NotFound(); }
            context.Trainers.Remove(item);
            return NoContent();
        }
    }
}
