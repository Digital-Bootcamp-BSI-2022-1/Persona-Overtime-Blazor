namespace PersonaOvertimeWeb.Models
{
    public class LoginResponse
    {
        public string? name { get; set; }
        public string? email { get; set; }
        public string? token { get; set; }
        public int? expiredAt { get; set; }
    }
}