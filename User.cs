using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class User
    {
        private string Username;
        private string Password;
        private string Role;

        //constructor
        public User(string username, string password, string role)
        { //Initialize the datafield values
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        //properties
        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Role1 { get => Role; set => Role = value; }
    }

}
