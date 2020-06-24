using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Club
    {
        private string ClubId;
        private string ClubName;
        private string President;
        private string VicePresident;
        private string Secretary;
        private string Description;
        private string RegistrationDate;

        //Constructor
        public Club(string clubid, string clubname, string president, string Vpresident, string secretary, string description, string regDate)
        {
            //Initialization of data field values
            this.ClubId = clubid;
            this.ClubName = clubname;
            this.President = president;
            this.VicePresident = Vpresident;
            this.Secretary = secretary;
            this.Description = description;
            this.RegistrationDate = regDate;
        }

        //Declaration of properties
        public string ClubId1 { get => ClubId; set => ClubId = value; }
        public string ClubName1 { get => ClubName; set => ClubName = value; }
        public string President1 { get => President; set => President = value; }
        public string VicePresident1 { get => VicePresident; set => VicePresident = value; }
        public string Secretary1 { get => Secretary; set => Secretary = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string RegistrationDate1 { get => RegistrationDate; set => RegistrationDate = value; }


    }
}
