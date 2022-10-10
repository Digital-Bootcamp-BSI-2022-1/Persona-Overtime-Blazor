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
            String token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJuYW1lIjoiSWthd2F0aSBCYXNyaSIsIm5iZiI6MTY2NTM2NDk2OCwiZXhwIjoxNjY1NjI0MTY4LCJpYXQiOjE2NjUzNjQ5Njh9.5WmqAjGIvMPfskp52po_Q32e-NWM1Yhgq_EXWE_guZBVcbOsGzDm6ejBvc_G4PFk2nigpt511g6fITLPWNrvVg";
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