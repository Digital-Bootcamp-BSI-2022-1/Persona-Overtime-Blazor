using PersonaOvertimeWeb.Models;

namespace PersonaOvertimeWeb.Services
{
    public interface IOvertimeService
    {
        Task<List<OvertimeDTO>> GetAllOvertimeList(string token);
        Task<SuccessResponse<OvertimeStatistic>> GetOvertimeStatistic(string token);
        Task<SuccessResponse<OvertimeStatistic>> GetOvertimeStatisticSuperior(string token);
        Task<HttpResponseMessage> PostOvertimeRequest(MultipartFormDataContent request, string token);
        Task<List<OvertimeDTO>> GetOvertimeById(int id, string token);
    }
}