using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportClub;
using SportClubAPI.Models;

namespace SportClubAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainingController : Controller
    {
        private readonly SportClubDbContext context;
        private readonly IMapper mapper;

        public TrainingController(IMapper mapper, SportClubDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost]
        public IActionResult CreateTraining(CreateTrainingModel training)
        {
            context.Trainings.Add(mapper.Map<Training>(training));
            context.SaveChanges();
            return Created();
        }

        [HttpGet]
        public IActionResult GetAllTrainings()
        {
            return Ok(context.Trainings.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = context.Trainings.Find(id);
            if (item == null) { return NotFound(); }
            return Ok(item);
        }

        [HttpPut]
        public IActionResult UpdateTraining(Training training)
        {
            context.Trainings.Update(training);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTraining(int Id)
        {
            var item = context.Trainings.Find(Id);
            if (item == null) { return NotFound(); }
            context.Trainings.Remove(item);
            return NoContent();
        }
    }
}
