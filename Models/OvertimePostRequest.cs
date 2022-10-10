using Microsoft.AspNetCore.Components.Forms;

namespace PersonaOvertimeWeb.Models
{
    public class OvertimePostRequest
    {
        public string? start_date { get; set; }
        public string? end_date { get; set; }
        public string? start_time { get; set; }
        public string? end_time { get; set; }
        public string? status { get; set; }
        public string? remarks { get; set; }
        public IBrowserFile? attachment { get; set; }
    }
}