
namespace BlazorServer.CarService.Shared.ViewModels;

public class AddBookingViewModel
{
    public string? Name { get; set; }
    public int PhoneNumber { get; set; }
    public string? ServiceType { get; set; }
    public string? MachineType { get; set; }
    public string? Email { get; set; }
    public DateTime BookDate { get; set; }
    public string? SpecialRequest { get; set; }
}
