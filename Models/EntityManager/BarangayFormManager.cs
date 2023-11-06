using iSkedyul.Models.DB;
using iSkedyul.Models.ViewModel;
using Microsoft.Identity.Client;
using System;
using System.Linq;

namespace iSkedyul.Models.EntityManager
{
    public class BarangayFormManager
    {
        public void AddBarangayForm(BarangayFormModel barangayForm)
        {
            using (MyDBContext dbContext = new MyDBContext())
            {
                BarangayForm bForm = new BarangayForm
                {
                    BarangayFormID = barangayForm.BarangayFormID,
                    FirstName = barangayForm.FirstName,
                    MiddleName = barangayForm.MiddleName,
                    LastName = barangayForm.LastName,
                    Gender = barangayForm.Gender,
                    CivilStatus = barangayForm.CivilStatus,
                    PWD = barangayForm.PWD,
                    Voter = barangayForm.Voter,
                    ContactNo = barangayForm.ContactNo,
                    Purpose = barangayForm.Purpose,
                    Email = barangayForm.Email,
                    Birthday = barangayForm.Birthday,
                    Nationality = barangayForm.Nationality,
                    Occupation = barangayForm.Occupation,
                    PlaceOfBirth = barangayForm.PlaceOfBirth,
                    StreetAddress = barangayForm.StreetAddress,
                    DateOfAppointment = barangayForm.DateOfAppointment
                };

                dbContext.BarangayForms.Add(bForm);
                dbContext.SaveChanges();
            }
        }

    }
}
