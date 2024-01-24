using login_binding_command_pain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_binding_command_pain.Services
{
    public class Login_Services
    {
        private List<User> userlist;

        public List<User> Userlist
        {
            get { return userlist; }
            set { userlist = value; }
        }
        public Login_Services() 
        {
            userlist = new List<User>
            {
                new User("adam", "7h7hh"),
                new User("shahar", "69420"),
                new User("yarden","goyardigo"),
                new User("ofek","987"),
                new User("god","bible"),
                new User("noam","jk"),
                new User("mom","mom"),
                new User("animewaifu69","love"),
                new User("21pailots","death"),
                new User("larry","##stillalive")
            };
        }

        public bool inlist(User user)
        {
            if (Userlist.Contains(user)) return true;
            else return false;
        }

        


    }


}
