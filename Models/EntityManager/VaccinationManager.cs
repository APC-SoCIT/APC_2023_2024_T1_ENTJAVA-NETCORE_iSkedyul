using iSkedyul.Models.DB;
using iSkedyul.Models.ViewModel;
using Microsoft.Identity.Client;
using System;
using System.Linq;

namespace iSkedyul.Models.EntityManager
{
    public class VaccinationManager
    {
        public void AddVaccination(VaccinationModel vaccination)
        {
            using (MyDBContext dbContext = new MyDBContext())
            {
                Vaccination vax = new Vaccination
                {
                    VaccineID = vaccination.VaccineID,
                    FirstName = vaccination.FirstName,
                    MiddleName = vaccination.MiddleName,
                    LastName = vaccination.LastName,
                    Gender = vaccination.Gender,
                    CivilStatus = vaccination.CivilStatus,
                    PWD = vaccination.PWD,
                    Voter = vaccination.Voter,
                    ContactNo = vaccination.ContactNo,
                    VaccineType = vaccination.VaccineType,
                    Email = vaccination.Email,
                    Birthday = vaccination.Birthday,
                    Nationality = vaccination.Nationality,
                    Occupation = vaccination.Occupation,
                    PlaceOfBirth = vaccination.PlaceOfBirth,
                    StreetAddress = vaccination.StreetAddress,
                    DateOfAppointment = vaccination.DateOfAppointment
                };

                dbContext.Vaccinations.Add(vax);
                dbContext.SaveChanges();
            }
        }

    }
}
