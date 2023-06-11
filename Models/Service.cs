namespace BlazorServer.CarService.Api.Models;

public class Service
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.Now;
}
