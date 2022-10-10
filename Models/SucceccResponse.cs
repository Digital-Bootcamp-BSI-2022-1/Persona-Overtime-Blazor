using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonaOvertimeWeb.Models
{
    public class SuccessResponse<T>
{
    public T? data {get; set;}
    public bool? success { get; set; }
    public string? message { get; set; }
    public string? origin { get; set; }
}
}