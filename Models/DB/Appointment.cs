using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iSkedyul.Models.DB
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTimeOfAppointment { get; set; }
        public string Purpose { get; set; }
    }
}
