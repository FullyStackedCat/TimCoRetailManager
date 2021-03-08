using Caliburn.Micro;
using System;

namespace TRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);

            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn
        {
            get
            {
                bool output = false;

                //if (UserName?.Length > 0 && Password?.Length > 0)
                //{
                //    output = true;

                //}
                if (!String.IsNullOrWhiteSpace(UserName) && !String.IsNullOrWhiteSpace(Password))
                {
                    output = true;
                }

                return output;
            }
        }

        public void LogIn()
        {
        }
    }
}
