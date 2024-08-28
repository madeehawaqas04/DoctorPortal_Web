using DoctorPortal_DotNetCore.Models.Dto;

namespace DoctorPortal_DotNetCore.Services.IServices
{
    public interface IPatientService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id, string token);
        Task<T> CreateAsync<T>(PatientDTO dto, string token);
        Task<T> UpdateAsync<T>(PatientDTO dto, string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}
