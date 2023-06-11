using BlazorServer.CarService.Api.Data;
using BlazorServer.CarService.Api.Models;
using BlazorServer.CarService.Shared.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.CarService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public ServiceController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<ActionResult<Response>> AddService(Service service)
        {
            if(service != null) 
            {
                appDbContext.Services.Add(service);
                await appDbContext.SaveChangesAsync();
                return Ok(new Response() { Message = "Service created successfully"});
            }
            return BadRequest(new Response() { Message = "Error occured, All fields required", Success = false });
        }

        [HttpGet]
        public async Task<ActionResult<List<Service>>> GetAllServices() => await appDbContext.Services.ToListAsync();

        [HttpDelete]
        public async Task<ActionResult<Response>> DeleteService (int id)
        {
            var service = await appDbContext.Services.FirstOrDefaultAsync(x => x.Id == id);
            if(service != null)
            {
                appDbContext.Services.Remove(service);
                await appDbContext.SaveChangesAsync();
                return Ok(new Response() { Message = "Service deleted successfully" });
            }
            return NotFound(new Response() { Message = "Service not found", Success=false });
        }
    }
}
