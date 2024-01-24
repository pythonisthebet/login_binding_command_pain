using login_binding_command_pain.models;
using login_binding_command_pain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_binding_command_pain.view_models
{
    public class View_Model : INotifyPropertyChanged
    {
        private Border border;

        private string lable;

        public string Lable
        {
            get { return lable; }
            set { lable = value; }
        }

        public void setColor(Color c)
        {
            border.BackgroundColor = c;
        }

        public void setvisbility(bool visibility)
        {
            border.IsVisible = visibility;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Command clickCommand { get; set; }

        public View_Model()
        {
            clickCommand = new Command<string[] >((p) => checkiftrue(p));
            border = new Border();
        }

        private bool checkiftrue(string[] p)
        {
            User user = new User(p[0], p[1]);
            if (Login_Services.inlist(user))
            {
                return true;
            }

            return false;
        }
    }
}
