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

        public async Task<List<OvertimeDTO>> GetAllOvertimeList(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await _httpClient.GetFromJsonAsync<List<OvertimeDTO>>("/overtime");
        }

        public async Task<List<OvertimeDTO>> GetAllOvertimeListSuperior(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await _httpClient.GetFromJsonAsync<List<OvertimeDTO>>("/overtime/superior");
        }

        public async Task<SuccessResponse<OvertimeStatistic>> GetOvertimeStatistic(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await _httpClient.GetFromJsonAsync<SuccessResponse<OvertimeStatistic>>("/overtime/statistic");
        }
        
        public async Task<HttpResponseMessage> PostOvertimeRequest(MultipartFormDataContent request, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = await _httpClient.PostAsync("/overtime", request);
            return response;
        }

        public async Task<SuccessResponse<OvertimeStatistic>> GetOvertimeStatisticSuperior(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await _httpClient.GetFromJsonAsync<SuccessResponse<OvertimeStatistic>>("/overtime/statistic/superior");
        }
        
        public async Task<List<OvertimeDTO>> GetOvertimeById(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await _httpClient.GetFromJsonAsync<List<OvertimeDTO>>("/overtime/" + id);
        }
        public async Task<List<OvertimeDTO>> GetOvertimeByIdSuperior(int id, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            return await _httpClient.GetFromJsonAsync<List<OvertimeDTO>>("/overtime/superior/" + id);
        }

        public async Task<HttpResponseMessage> PostOvertimeStatus(int id, MultipartFormDataContent request, string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = await _httpClient.PostAsync("/update/overtime/" + id, request);
            return response;
        }
    }
}