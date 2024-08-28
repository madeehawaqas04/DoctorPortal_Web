using static DoctorPortal_DotNetCore.Models.Utility.SD;

namespace DoctorPortal_DotNetCore.Models
{
    public class APIRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string? Url { get; set; }
        public object? Data { get; set; }
        public string? Token { get; set; }
    }
}
