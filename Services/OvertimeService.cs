using PersonaOvertimeWeb.Models;

namespace PersonaOvertimeWeb.Services
{
    public class OvertimeService : IOvertimeService
    {
        private readonly HttpClient _httpClient;

        public OvertimeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<OvertimeDTO>> GetAllOvertimeList()
        {
            String token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJuYW1lIjoiSWthd2F0aSBCYXNyaSIsIm5iZiI6MTY2NTM2NDk2OCwiZXhwIjoxNjY1NjI0MTY4LCJpYXQiOjE2NjUzNjQ5Njh9.5WmqAjGIvMPfskp52po_Q32e-NWM1Yhgq_EXWE_guZBVcbOsGzDm6ejBvc_G4PFk2nigpt511g6fITLPWNrvVg";
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await _httpClient.GetFromJsonAsync<List<OvertimeDTO>>("/overtime");
        }


        public async Task<SuccessResponse<OvertimeStatistic>> GetOvertimeStatistic()
        {
            String token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJuYW1lIjoiSWthd2F0aSBCYXNyaSIsIm5iZiI6MTY2NTM2NDk2OCwiZXhwIjoxNjY1NjI0MTY4LCJpYXQiOjE2NjUzNjQ5Njh9.5WmqAjGIvMPfskp52po_Q32e-NWM1Yhgq_EXWE_guZBVcbOsGzDm6ejBvc_G4PFk2nigpt511g6fITLPWNrvVg";
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await _httpClient.GetFromJsonAsync<SuccessResponse<OvertimeStatistic>>("/overtime/statistic");
        }
        
        
        public async Task<HttpResponseMessage> PostOvertimeRequest(MultipartFormDataContent request, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = await _httpClient.PostAsync("/overtime", request);
            return response;

        }

        public async Task<SuccessResponse<OvertimeStatistic>> GetOvertimeStatisticSuperior()
        {
            String token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJuYW1lIjoiSWthd2F0aSBCYXNyaSIsIm5iZiI6MTY2NTM2NDk2OCwiZXhwIjoxNjY1NjI0MTY4LCJpYXQiOjE2NjUzNjQ5Njh9.5WmqAjGIvMPfskp52po_Q32e-NWM1Yhgq_EXWE_guZBVcbOsGzDm6ejBvc_G4PFk2nigpt511g6fITLPWNrvVg";
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await _httpClient.GetFromJsonAsync<SuccessResponse<OvertimeStatistic>>("/overtime/statistic/superior");
        }
        public async Task<List<OvertimeDTO>> GetOvertimeById(int id)
        {
            String token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJuYW1lIjoiSWthd2F0aSBCYXNyaSIsIm5iZiI6MTY2NTM2NDk2OCwiZXhwIjoxNjY1NjI0MTY4LCJpYXQiOjE2NjUzNjQ5Njh9.5WmqAjGIvMPfskp52po_Q32e-NWM1Yhgq_EXWE_guZBVcbOsGzDm6ejBvc_G4PFk2nigpt511g6fITLPWNrvVg";
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await _httpClient.GetFromJsonAsync<List<OvertimeDTO>>("/overtime/" + id);
        }
    }
}