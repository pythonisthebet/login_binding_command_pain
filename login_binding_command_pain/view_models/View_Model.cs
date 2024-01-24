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
        Login_Services service;

        private Border border;

        private string lable;

        private string usern;

        private string pass;

        public string Lable
        {
            get { return lable; }
            set { lable = value; }
        }

        public string Usern
        { get { return usern; } set {  usern = value; } }

        public string Pass
        { get { return pass; } set {  pass = value; } }

        public Border Border
        { get { return border; } set {  border = value; } }

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

        public View_Model(Login_Services service)
        {
            clickCommand = new Command<string[]>((p) => checkiftrue());
            border = new Border();
            lable = "";
            usern = "";
            pass = "";
            this.service = service;
        }

        private void checkiftrue()
        {
            User user = new User(usern,pass);
            setvisbility(true);
            if (service.inlist(user))
            {
                Lable = "login succesful!!!";
                setColor(Color.Parse("LawnGreen"));
            }
            else
            {
                Lable = "login failed";
                setColor(Color.Parse("red"));
            }
            OnPropertyChanged();
        }
    }
}
