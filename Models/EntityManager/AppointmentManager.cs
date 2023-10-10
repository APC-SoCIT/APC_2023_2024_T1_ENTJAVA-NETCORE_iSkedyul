using iSkedyul.Models.DB;
using iSkedyul.Models.ViewModel;
using System;
using System.Linq;

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

        public List<AppointmentModel> GetAppointments()
        {
            using (MyDBContext dbContext = new MyDBContext())
            {
                // Retrieve all appointments info from the database
                List<Appointment> dbAppointments = dbContext.Appointments.ToList();

                // Map the database Appointment objects to AppointmentModel objects
                List<AppointmentModel> appointments = dbAppointments.Select(dbAppt => new AppointmentModel
                {
                    AppointmentID = dbAppt.AppointmentID,
                    FirstName = dbAppt.FirstName,
                    LastName = dbAppt.LastName,
                    DateTimeOfAppointment = dbAppt.DateTimeOfAppointment,
                    Purpose = dbAppt.Purpose
                }).ToList();

                return appointments;
            }
        }



    }
}
