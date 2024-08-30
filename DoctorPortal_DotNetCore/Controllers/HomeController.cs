using DoctorPortal_DotNetCore.Models.Utility;
using DoctorPortal_DotNetCore.Models;
using DoctorPortal_DotNetCore.Models.Dto;
using DoctorPortal_DotNetCore.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System.Diagnostics;

namespace DoctorPortal_DotNetCore.Controllers
{
    [Authorize(Roles = "admin")]
    public class HomeController : Controller
    {
        //private readonly IVillaService _villaService;
        //private readonly HttpClient _client;
        ////Uri baseAddress = new Uri("http://localhost:5120/api");
        //public HomeController(IVillaService villaService)
        //{
        //    _villaService = villaService;
        //    //_client = new HttpClient();
        //    //_client.BaseAddress = baseAddress;
        //}

        //public async Task<IActionResult> Index()
        //{

        //    //HttpResponseMessage responsem = _client.GetAsync(_client.BaseAddress + "/Employees").Result;
        //    List<VillaDTO> list = new();

        //    var response = await _villaService.GetAllAsync<APIResponse>(HttpContext.Session.GetString(SD.SessionToken));
        //    if (response != null && response.IsSuccess)
        //    {
        //        list = JsonConvert.DeserializeObject<List<VillaDTO>>(Convert.ToString(response.Result));
        //    }
        //    return View(list);
        //}

        public IActionResult Index()
        {
            return View();
        }
       
    }
}