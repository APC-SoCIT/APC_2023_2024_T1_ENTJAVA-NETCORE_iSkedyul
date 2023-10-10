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

                for (int i = 0; i < list.Appointments.Count; i++)
                {
                    Console.WriteLine(list.Appointments[i].FirstName);
                }
            }

            return list;
        }



    }
}
