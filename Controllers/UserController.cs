using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportClub;
using SportClubAPI.Models;

namespace SportClubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly SportClubDbContext context;
        private readonly IMapper mapper;

        public UserController(IMapper mapper, SportClubDbContext context)
        {
            this.context =context ;
            this.mapper = mapper;
        }


        [HttpPost]
        public IActionResult CreateUser(CreateUserModel user)
        {
            context.Users.Add(mapper.Map<User>(user));
            context.SaveChanges();
            return Created();
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(context.Users.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = context.Users.Find(id);
            if (item == null) { return NotFound(); }
            return Ok(item);
        }

        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteUser(int Id)
        {
            var item = context.Users.Find(Id);
            if (item == null) { return NotFound(); }
            context.Users.Remove(item);
            return NoContent();
        }
    }
    }
