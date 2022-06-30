using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderingSystem.DTO
{
    public class LoginDTO
    {
        private string _userid;
        private string _password;

        public string Userid { get => _userid; set => _userid = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
