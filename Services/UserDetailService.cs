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

        public async Task<UserDTO> GetUserDetail(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await _httpClient.GetFromJsonAsync<UserDTO>("/profile");
        }

        public async Task<HttpResponseMessage> PostLogin(LoginRequest request)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync<LoginRequest>("/auth/login", request);
            return response;
        }
    }
}