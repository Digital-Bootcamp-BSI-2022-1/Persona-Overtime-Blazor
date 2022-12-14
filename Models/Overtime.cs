using System.Text.Json.Serialization;
using PersonaOvertimeWeb.Data.Converter;

namespace PersonaOvertimeWeb.Models
{
    public class Overtime
    {
        public int id { get; set; }
        public User? user { get; set; }

        [property: JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly start_date { get; set; }
        
        [property: JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly end_date { get; set; }

        [property: JsonConverter(typeof(TimeOnlyJsonConverter))]
        public TimeOnly start_time { get; set; }

        [property: JsonConverter(typeof(TimeOnlyJsonConverter))]
        public TimeOnly end_time { get; set; }
        public int break_duration1 { get; set; }
        public int break_duration2 { get; set; }
        public int duration { get; set; }
        public int status { get; set; }
        public string? status_text { get; set; }
        public int is_completed { get; set; }
        public string? remarks { get; set; }
        public string? attachment { get; set; }
        
        [property: JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly request_date { get; set; }

        [property: JsonConverter(typeof(TimeOnlyJsonConverter))]
        public TimeOnly request_time { get; set; }

        [property: JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly approved_date { get; set; }

        [property: JsonConverter(typeof(TimeOnlyJsonConverter))]
        public TimeOnly approved_time { get; set; }

        [property: JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateOnly completed_date { get; set; }

        [property: JsonConverter(typeof(TimeOnlyJsonConverter))]
        public TimeOnly completed_time { get; set; }
    }
}