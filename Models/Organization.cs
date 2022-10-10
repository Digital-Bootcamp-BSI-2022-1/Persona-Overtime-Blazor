namespace PersonaOvertimeWeb.Models
{
    public class Organization
    {
        public int id { get; set; }
        public string? organization_name { get; set; }
        public User? head { get; set; }
        public List<User>? member { get; set; }
    }
}