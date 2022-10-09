using PersonaOvertimeWeb.Models;

namespace PersonaOvertimeWeb.Services
{
    public class UserDetailService : IUserDetailService
    {
        private readonly HttpClient _httpClient;

        public UserDetailService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserDTO> GetUserDetail()
        {
            return await _httpClient.GetFromJsonAsync<UserDTO>("/profile");
        }
    }
}