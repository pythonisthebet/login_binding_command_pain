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
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Command clickCommand { get; set; }

        public View_Model()
        {
            clickCommand = new Command<string>((p) => checkiftrue(p));
            
        }

        private bool checkiftrue(string p)
        {
            return true;
        }
    }
}
