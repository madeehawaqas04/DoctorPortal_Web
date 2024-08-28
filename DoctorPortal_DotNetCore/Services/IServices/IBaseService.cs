using DoctorPortal_DotNetCore.Models;

namespace DoctorPortal_DotNetCore.Services.IServices
{
    public interface IBaseService
    {
        APIResponse responseModel { get; set; }
        Task<T> SendAsync<T>(APIRequest apiRequest);
    }
}
