using PersonaOvertimeWeb.Models;

namespace PersonaOvertimeWeb.Services
{
    public interface IOvertimeService
    {
        Task<List<OvertimeDTO>> GetAllOvertimeList();

        Task<SuccessResponse<OvertimeStatistic>> GetOvertimeStatistic();
        Task<SuccessResponse<OvertimeStatistic>> GetOvertimeStatisticSuperior();

        Task<HttpResponseMessage> PostOvertimeRequest(MultipartFormDataContent request);

    }
}