using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class ClubRegistration
    {
        private string ClubName, President, VicePresident, Secretary, Description;
        private DateTime RegistrationDate;

        //Constructor
        public ClubRegistration(string ClubName, DateTime RegistrationDate, string President, string VicePresident, string Secretary, string Description, string clubName = null, string president = null, string vicePresident = null, string secretary = null, string description = null, DateTime registrationDate = default)
        {
            //Initialization of data field values
            this.ClubName = clubName;
            this.President = president;
            this.VicePresident = vicePresident;
            this.Secretary = secretary;
            this.Description = description;
            this.RegistrationDate = registrationDate;
        }

        //Declaration of properties
        public string ClubName1 { get => ClubName; set => ClubName = value; }
        public string President1 { get => President; set => President = value; }
        public string VicePresident1 { get => VicePresident; set => VicePresident = value; }
        public string Secretary1 { get => Secretary; set => Secretary = value; }
        public string Description1 { get => Description; set => Description = value; }
        public DateTime RegistrationDate1 { get => RegistrationDate; set => RegistrationDate = value; }


    }
}
