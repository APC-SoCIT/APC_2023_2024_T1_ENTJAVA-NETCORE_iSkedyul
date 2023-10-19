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
            AppointmentsModel appointments = appointmentManager.GetAppointments();

            return View(appointments);
        }

        [HttpGet]
        public ActionResult Appointments()
        {


            return View();
        }
    }
}
