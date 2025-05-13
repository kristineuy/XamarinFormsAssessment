using System;
using SQLite;

namespace XamarinFormsAssessment.Models
{
    public class Entry
    {
        [PrimaryKey, AutoIncrement]
        public int EntryID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Ignore]
        public int Age => CalculateAge();

        public int CalculateAge()
        {
            var currentDate = DateTime.Today;
            int age = currentDate.Year - DateOfBirth.Year;

            if (DateOfBirth.Date > currentDate.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}