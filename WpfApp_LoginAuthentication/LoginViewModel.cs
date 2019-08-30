using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp_LoginAuthentication.ViewModels;

namespace WpfApp_LoginAuthentication
{
    public class LoginViewModel : ViewModelBase
    {
        // -- https://unclassified.software/en/source/delegatecommand

        #region -- Private --
        private string _userName;
        private string _password; 
        #endregion

        #region --  --

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                if (string.IsNullOrEmpty(_userName))
                {

                }

                OnPropertyChanged(nameof(UserName));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;

                OnPropertyChanged(nameof(Password));
            }
        }
        
        public bool CanLogin
        {
            get
            {
                return !string.IsNullOrEmpty(UserName) &&
                    !string.IsNullOrEmpty(Password);
            }
        }
        #endregion

        #region --  --
        private ICommand _validateCommand;

        public ICommand LogInCommand
        {
            get
            {
                // -- Avec commandParameter --
                //return _validateCommand ?? (_validateCommand = new RelayCommand(
                //        LogIn, param => _canLogin ));

                // -- Sans commandParameter --
                //return _validateCommand ?? (
                //       _validateCommand = new RelayCommand(LogIn));
                var de = string.IsNullOrEmpty(UserName);
                return _validateCommand ?? (
                      _validateCommand = new RelayCommand(LogIn, param => CanLogin));
            }
            set { _validateCommand = value; }
        }

        #endregion

        #region -- Contructor --
        public LoginViewModel()
        {


        } 
        #endregion

        #region -- Properties --

        private void LogIn(object obj)
        {
            var login = UserName;
            var pass = Password;

            if (_userName == "citoyenlamda@gmail.com" && _password == "000")
            {
                //LoginModel.GetInstance().LoggedIn = true;
            }
        }

        #endregion
    }
}
