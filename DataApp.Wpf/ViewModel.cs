using DataApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Wpf
{
    public class ViewModel : INotifyPropertyChanged
    {
        private readonly User model;

        public ViewModel(User model)
        {
            this.model = model;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Username
        {
            get
            {
                return this.model.Username;
            }
            set
            {
                if (this.model.Username != value)
                {
                    this.model.Username = value;
                    this.OnPropertyChanged("Username");
                }
            }
        }

        public string Password
        {
            get
            {
                return this.model.Password;
            }
            set
            {
                if (this.model.Password != value)
                {
                    this.model.Password = value;
                    this.OnPropertyChanged("Password");
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
