namespace BlazorServer.CarService.Api.Models;

public class Booking
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int PhoneNumber { get; set; }
    public string? ServiceType { get; set; }
    public string? MachineType { get; set; }
    public string? Email { get; set; }
    public DateTime BookDate { get; set; }
    public string? SpecialRequest { get; set; }
    public DateTime DateBooked { get; set; } = DateTime.Now;

}
