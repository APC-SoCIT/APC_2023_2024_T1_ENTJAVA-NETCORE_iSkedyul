using iSkedyul.Models;
using iSkedyul.Models.EntityManager;
using iSkedyul.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace iSkedyul.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Appointment()
        {
            AppointmentManager appointmentManager = new AppointmentManager();
            AppointmentsModel appointments = appointmentManager.GetAppointments();

            return View(appointments);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult Index(AppointmentModel apptData)
        {
            AppointmentManager am = new AppointmentManager();

            if (apptData.AppointmentID.ToString().Length > 0)
            {
                am.AddAppointment(apptData);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] AppointmentModel apptData)
        {
            AppointmentManager am = new AppointmentManager();
            am.UpdateAppointment(apptData);
            return Redirect("Index");
        }
    }
}