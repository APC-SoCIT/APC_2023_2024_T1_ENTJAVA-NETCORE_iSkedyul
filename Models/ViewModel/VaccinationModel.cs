using System.ComponentModel.DataAnnotations;

namespace iSkedyul.Models.ViewModel
{
    public class VaccinationModel
    {
        [Key]
        public int VaccineID { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get;set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "CivilStatus")]
        public string CivilStatus { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "PWD")]
        public bool PWD { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Voter")]
        public bool Voter { get;set; }
        [Display(Name = "Contact Number")]
        public string ContactNo { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Vaccine Type")]
        public string VaccineType { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Occupation")]
        public string Occupation { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Place of Birth")]
        public string PlaceOfBirth { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Date of Appointment")]
        public DateTime DateOfAppointment { get; set; }
    }

    public class VaccinationsModel
    {
        List<VaccinationModel> Vaccinations { get; set; }
    }
}
