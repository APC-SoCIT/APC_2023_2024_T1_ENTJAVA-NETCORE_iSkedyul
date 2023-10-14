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

        public AppointmentsModel GetAppointments()
        {
            AppointmentsModel list = new AppointmentsModel();

            using (MyDBContext dbContext = new MyDBContext())
            {
                list.Appointments = dbContext.Appointments.Select(records => new AppointmentModel()
                {
                    AppointmentID = records.AppointmentID,
                    FirstName = records.FirstName,
                    LastName = records.LastName,
                    DateTimeOfAppointment = records.DateTimeOfAppointment,
                    Purpose = records.Purpose
                }).ToList();
            }

            return list;
        }

        public void UpdateAppointment(AppointmentModel appointment)
        {
            using (MyDBContext db = new MyDBContext())
            {
                Appointment existingAppointment = db.Appointments.FirstOrDefault(a => a.AppointmentID == appointment.AppointmentID);

                if(existingAppointment != null)
                {
                    existingAppointment.FirstName = appointment.FirstName;
                    existingAppointment.LastName = appointment.LastName;
                    existingAppointment.DateTimeOfAppointment = appointment.DateTimeOfAppointment;
                    existingAppointment.Purpose = appointment.Purpose;

                    db.SaveChanges();
                }
            }
        }
    }
}
