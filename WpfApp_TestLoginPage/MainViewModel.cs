using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp_TestLoginPage
{
    // https://social.msdn.microsoft.com/Forums/fr-FR/72d4eced-f3b8-4898-a7ff-5f8f6e763f0e/wpf-and-mvvm-with-login-authentication?forum=wpf

    public class MainViewModel : INotifyPropertyChanged
    {

        #region -- !!!!!!!!!! --
        private bool _isAuthenticated;
        public bool isAuthenticated
        {
            get { return _isAuthenticated; }
            set
            {
                if (value != _isAuthenticated)
                {
                    _isAuthenticated = value;
                    OnPropertyChanged("isAuthenticated");
                }
            }
        }

        private string _username;
        public string UserName
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged("UserName");
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        //public ICommand LoginCommand
        //{
        //    get { return new RelayCommand(() => Login()); }
        //}

        public void Login()
        {
            //TODO check username and password vs database here.
            //If using membershipprovider then just call Membership.ValidateUser(UserName, Password)
            if (!String.IsNullOrEmpty(UserName) && !String.IsNullOrEmpty(Password))
                isAuthenticated = true;
        }

        #region INotifyPropertyChanged Methods

        public void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, args);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        #endregion 
        #endregion

        private ICommand _command;

        public ICommand Command
        {
            get
            {
                return _command ?? (_command = new RelayCommand(
                   x =>
                   {
                       DoStuff();
                   }));
            }

        }

        private static void DoStuff()
        {
            Console.WriteLine("Responding to button click event...");
        }
    }
}