using Microsoft.AspNetCore.Mvc;

namespace DoctorPortal_DotNetCore.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
