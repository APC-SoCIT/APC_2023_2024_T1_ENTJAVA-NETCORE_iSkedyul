using iSkedyul.Models;
using iSkedyul.Models.EntityManager;
using iSkedyul.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
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

        public IActionResult Vaccination()
        {
            return View();
        }

        public IActionResult BarangayForm() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Vaccination(VaccinationModel vaxData)
        {
            ModelState.Remove("MiddleName");

            if (ModelState.IsValid)
            {
                VaccinationManager vm = new VaccinationManager();

                vm.AddVaccination(vaxData);

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult BarangayForm(BarangayFormModel formData)
        {
            ModelState.Remove("MiddleName");

            if (ModelState.IsValid)
            {
                BarangayFormManager bm = new BarangayFormManager();

                bm.AddBarangayForm(formData);

                return RedirectToAction("Index");
            }
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