using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel;

namespace MVVMBasic.Model
{
    class Person : INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
                OnPropertyChanged("Fullname");
            }
        }

        private string _lastname;
        public string Lastname
        {
            get { return _lastname; }
            set
            {
                _lastname = value;
                OnPropertyChanged("Lastname");
                OnPropertyChanged("Fullname");
            }
        }
        private string _fullname;
        public string Fullname
        {
            get { return _name + " " + _lastname; }
            set
            {
                _fullname = value;
                OnPropertyChanged("Fullname");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Person()
        {
            if (DesignMode.DesignModeEnabled)
            {
                this.Name = "sachin";
                this.Lastname = "vishwakarma";
            }
        }
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
