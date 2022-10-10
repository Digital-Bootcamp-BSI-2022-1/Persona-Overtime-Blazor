using PersonaOvertimeWeb.Models;

namespace PersonaOvertimeWeb.Services
{
    public interface IOvertimeService
    {
        Task<List<OvertimeDTO>> GetAllOvertimeList();
        Task<HttpResponseMessage> PostOvertimeRequest(MultipartFormDataContent request);
    }
}