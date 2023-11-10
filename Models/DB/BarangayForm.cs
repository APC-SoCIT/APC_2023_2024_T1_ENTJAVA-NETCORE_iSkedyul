using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iSkedyul.Models.DB
{
    public class BarangayForm
    {
        [Key]
        public int BarangayFormID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public bool PWD { get; set; }
        public bool Voter { get; set; }
        public string ContactNo { get; set; }
        public string Purpose { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Nationality { get; set; }
        public string Occupation { get; set; }
        public string PlaceOfBirth { get; set; }
        public string StreetAddress { get; set; }
        public DateTime DateOfAppointment { get; set; }
    }
}
