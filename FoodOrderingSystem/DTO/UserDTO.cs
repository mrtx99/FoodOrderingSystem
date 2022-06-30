using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.DTO
{
    public class UserDTO
    {
        private string _userid;
        private string _username;
        private string _password;
        private string _role;
        private string _phone;
        private string _address;

        public string Userid { get => _userid; set => _userid = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
    }
}
