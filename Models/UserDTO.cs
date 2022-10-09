namespace PersonaOvertimeWeb.Models
{
    public class UserDTO
    {
        public int id { get; set; }
        public string? nik { get; set; }
        public string? name { get; set; }
        public string? role { get; set; }
        public string? grade { get; set; }
        public string? employment_status { get; set; }
        public string? phone { get; set; }
        public string? email { get; set; }
        public string? ktp { get; set; }
        public string? npwp { get; set; }
        public string? join_date { get; set; }
        public OrganizationDTO organization { get; set; }
    }
}