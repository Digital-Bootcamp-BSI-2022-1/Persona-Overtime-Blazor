using PersonaOvertimeWeb.Models;

namespace PersonaOvertimeWeb.Services
{
    public interface IUserDetailService
    {
        Task<UserDTO> GetUserDetail();
    }
}