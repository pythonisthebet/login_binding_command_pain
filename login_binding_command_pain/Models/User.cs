using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_binding_command_pain.models
{
    public class User
    {
        private string username;
        private string password;

        public string Username
        {
            get
            {
                return username;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }
        }

        public User() { }

        public User(string user, string pass)
        {
            username = user;
            password = pass;
        }
    }
}
