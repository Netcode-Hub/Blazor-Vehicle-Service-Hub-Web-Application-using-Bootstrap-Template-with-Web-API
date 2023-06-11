using BlazorServer.CarService.Shared.Responses;
using BlazorServer.CarService.Shared.ViewModels;

namespace BlazorServer.CarService.ApiServices.BookingFolder
{
    public class BookingRepository : IBookingRepository
    {
        private readonly HttpClient httpClient;

        public BookingRepository(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<Response> AddBooking(AddBookingViewModel model)
        {
            var result = await httpClient.PostAsJsonAsync("api/booking", model);
            var response = await result.Content.ReadFromJsonAsync<Response>();
            return response!;
        }

        public async Task<List<GetBookingViewModel>> GetBookings()
        {
            var result = await httpClient.GetAsync("api/booking");
            var response = await result.Content.ReadFromJsonAsync<List<GetBookingViewModel>>();
            return response!;
        }
    }
}
