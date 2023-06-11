using BlazorServer.CarService.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.CarService.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Booking> Bookings { get; set; } = default!;
    public DbSet<Service> Services { get; set; } = default!;
}
