using iSkedyul.Models.DB;
using iSkedyul.Models.ViewModel;

namespace iSkedyul.Models.EntityManager
{
    public class AppointmentManager
    {
        public void AddAppointment(AppointmentModel appointment)
        {
            using (MyDBContext dbContext = new MyDBContext())
            {
                Appointment appt = new Appointment
                {
                    AppointmentID = appointment.AppointmentID,
                    FirstName = appointment.FirstName,
                    LastName = appointment.LastName,
                    DateTimeOfAppointment = appointment.DateTimeOfAppointment,
                    Purpose = appointment.Purpose
                };

                dbContext.Appointments.Add(appt);
                dbContext.SaveChanges();
            }
        }
    }
}
