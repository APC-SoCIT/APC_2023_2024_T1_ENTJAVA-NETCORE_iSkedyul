using Microsoft.AspNetCore.Mvc;
using iSkedyul.Models;
using iSkedyul.Models.EntityManager;
using iSkedyul.Models.ViewModel;

namespace iSkedyul.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            AppointmentManager appointmentManager = new AppointmentManager();
            AppointmentsModel appointments = appointmentManager.GetAppointments(DateTime.Now);

            return View(appointments);
        }

        [HttpGet]
        public ActionResult Index(string filter)
        {
            AppointmentManager appointmentManager = new AppointmentManager();
            AppointmentsModel appointments = appointmentManager.GetAppointments(string.IsNullOrWhiteSpace(filter) ? DateTime.Now : DateTime.Parse(filter));

            return View(appointments);
        }
    }
}
