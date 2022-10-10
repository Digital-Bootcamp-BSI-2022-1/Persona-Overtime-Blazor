using System.Text.Json.Serialization;
using PersonaOvertimeWeb.Data.Converter;

namespace PersonaOvertimeWeb.Models
{
    public class OvertimeDTO
    {
        public int id { get; set; }
        public UserOTDTO user { get; set; }
        
        [property: JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly start_date { get; set; }
        
        [property: JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly end_date { get; set; }

        [property: JsonConverter(typeof(TimeOnlyJsonConverter))]
        public TimeOnly start_time { get; set; }

        [property: JsonConverter(typeof(TimeOnlyJsonConverter))]
        public TimeOnly end_time { get; set; }
        public int duration { get; set; }
        public int status { get; set; }
        public string? status_text { get; set; }
        public int is_completed { get; set; }
        public string? remarks { get; set; }
        public string? attachment { get; set; }

        [property: JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly request_date { get; set; }

        [property: JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly approved_date { get; set; }

        [property: JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly completed_date { get; set; }

        // public OvertimeDTO() { }
        // public OvertimeDTO(Overtime overtimeItem) =>
        // (id,start_date, end_date, start_time , end_time , duration , status , status_text , is_completed , remarks , attachment, request_date, approved_date, completed_date, user) = 
        // (overtimeItem.id,overtimeItem.start_date, overtimeItem.end_date, overtimeItem.start_time, overtimeItem.end_time, overtimeItem.duration, overtimeItem.status, 
        // overtimeItem.status_text, overtimeItem.is_completed, overtimeItem.remarks, overtimeItem.attachment, overtimeItem.request_date, overtimeItem.approved_date, 
        // overtimeItem.completed_date, new UserOTDTO(overtimeItem.user!));
    }
}