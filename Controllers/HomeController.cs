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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<ActionResult> SubmitAppointment([FromBody] AppointmentModel apptData)
        {
                AppointmentManager am = new AppointmentManager();

                Console.WriteLine(apptData.AppointmentID);
                Console.WriteLine(apptData.FirstName);
                Console.WriteLine(apptData.LastName);
                Console.WriteLine(apptData.DateTimeOfAppointment);
                Console.WriteLine(apptData.Purpose);

                am.AddAppointment(apptData);
                return RedirectToAction("Index");
        }
    }
}