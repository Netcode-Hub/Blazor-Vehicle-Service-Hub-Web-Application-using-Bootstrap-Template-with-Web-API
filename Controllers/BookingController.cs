using BlazorServer.CarService.Api.Data;
using BlazorServer.CarService.Api.Models;
using BlazorServer.CarService.Shared.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.CarService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public BookingController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<ActionResult<Response>> Book(Booking booking)
        {
            if(booking == null)
            {
                return BadRequest(new Response() { Message="Error occured, All fields required", Success=false });
            }
            
            appDbContext.Bookings.Add(booking);
            await appDbContext.SaveChangesAsync();
            return BadRequest(new Response() { Message = "Thanks for making a service day with us, we look to see you soon!" });
        }

        [HttpGet]
        public async Task<ActionResult<List<Booking>>> GetAllBookings() => Ok(await appDbContext.Bookings.ToListAsync());
    }
}
