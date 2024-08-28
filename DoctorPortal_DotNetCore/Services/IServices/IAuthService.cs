using DoctorPortal_DotNetCore.Models.Dto;

namespace DoctorPortal_DotNetCore.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO objToCreate);
        Task<T> RegisterAsync<T>(RegisterationRequestDTO objToCreate);
    }
}
