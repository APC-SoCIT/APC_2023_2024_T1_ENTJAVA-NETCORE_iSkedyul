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
        public ActionResult Appointments()
        {
            AppointmentManager appointmentManager = new AppointmentManager();
            List<AppointmentModel> appointments = appointmentManager.GetAppointments(); // Retrieve appointments from your database

            AppointmentModel appointmentModel = new AppointmentModel
            {
                Appointments = appointments
            };

            return View(appointmentModel);
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

                Console.WriteLine(apptData.AppointmentID);
                Console.WriteLine(apptData.FirstName);
                Console.WriteLine(apptData.LastName);
                Console.WriteLine(apptData.DateTimeOfAppointment);
                Console.WriteLine(apptData.Purpose);

                am.AddAppointment(apptData);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Appointment()
        {
            return View();
        }
    }
}