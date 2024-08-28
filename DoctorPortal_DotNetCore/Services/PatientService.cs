using DoctorPortal_DotNetCore.Models.Utility;
using DoctorPortal_DotNetCore.Models;
using DoctorPortal_DotNetCore.Models.Dto;
using DoctorPortal_DotNetCore.Services.IServices;

namespace DoctorPortal_DotNetCore.Services
{
    public class PatientService : BaseService, IPatientService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string Url;

        public PatientService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
             Url = configuration.GetValue<string>("ServiceUrls:PortalAPI");

        }

        public Task<T> CreateAsync<T>(PatientDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = dto,
                Url = Url + "/Patient",
                Token = token
            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = Url + "/Patient/" + id,
                Token = token
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = Url + "/Patient",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = Url + "/Patient/" + id,
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(PatientDTO dto, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = dto,
                Url = Url + "/Patient/" + dto.Id,
                Token = token
            }) ;
        }
    }
}
