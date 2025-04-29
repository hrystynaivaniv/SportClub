using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportClub;
using SportClubAPI.Models;

namespace SportClubAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : Controller
    {
        private readonly SportClubDbContext context;
        private readonly IMapper mapper;

        public PaymentController(IMapper mapper, SportClubDbContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpPost]
        public IActionResult CreatePayment(CreatePaymentModel payment)
        {
            context.Payments.Add(mapper.Map<Payment>(payment));
            context.SaveChanges();
            return Created();
        }

        [HttpGet]
        public IActionResult GetAllPayments()
        {
            return Ok(context.Payments.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = context.Payments.Find(id);
            if (item == null) { return NotFound(); }
            return Ok(item);
        }

        [HttpPut]
        public IActionResult UpdatePayment(Payment payment)
        {
            context.Payments.Update(payment);
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeletePayment(int Id)
        {
            var item = context.Payments.Find(Id);
            if (item == null) { return NotFound(); }
            context.Payments.Remove(item);
            return NoContent();
        }
    }
}
