using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportClub;
using SportClubAPI.Models;

namespace SportClubAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistrationController : Controller
    {
        private readonly SportClubDbContext context;
        private readonly IMapper mapper;

        public RegistrationController(IMapper mapper, SportClubDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost]
        public IActionResult CreateRegistration(CreateRegistrationModel registration)
        {
            context.Registrations.Add(mapper.Map<Registration>(registration));
            context.SaveChanges();
            return Created();
        }

        [HttpGet]
        public IActionResult GetAllRegistration()
        {
            return Ok(context.Registrations.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = context.Registrations.Find(id);
            if (item == null) { return NotFound(); }
            return Ok(item);
        }

        [HttpPut]
        public IActionResult UpdateRegistration(Registration registration)
        {
            context.Registrations.Update(registration);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRegistration(int Id)
        {
            var item = context.Registrations.Find(Id);
            if (item == null) { return NotFound(); }
            context.Registrations.Remove(item);
            return NoContent();
        }
    }
}
