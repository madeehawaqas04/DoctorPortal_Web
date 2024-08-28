using DoctorPortal_DotNetCore.Models.Utility;
using DoctorPortal_DotNetCore.Models;
using DoctorPortal_DotNetCore.Models.Dto;
using DoctorPortal_DotNetCore.Services.IServices;

namespace DoctorPortal_DotNetCore.Services
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string Url;

        public AuthService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            Url = configuration.GetValue<string>("ServiceUrls:PortalAPI");

        }

        public Task<T> LoginAsync<T>(LoginRequestDTO obj)
        {
            return SendAsync<T>(new APIRequest()
                {
                    ApiType = SD.ApiType.POST,
                    Data = obj,
                    Url = Url + "/UsersAuth/login"
            });
           
        }

        public Task<T> RegisterAsync<T>(RegisterationRequestDTO obj)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = obj,
                Url = Url + "/UsersAuth/register"
            });
        }
    }
}
