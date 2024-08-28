using System.Net;

namespace DoctorPortal_DotNetCore.Models
{
    public class APIResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string>? ErrorMessages { get; set; }

        public string? message { get; set; }
        public object? Result { get; set; }
    }
}
