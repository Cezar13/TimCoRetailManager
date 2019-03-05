using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName;
        private string _password;

        public string userName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => userName);
            }
        }
       

        public string Password
        {
            get { return _password; }
            set {
                _password = value;
                NotifyOfPropertyChange(() => Password);
            }
        }

        public bool CanLogIn(string userName, string password)
        {
            bool output = false;

            if (userName.Length > 0 && password.Length > 0)
            {
                output = true;
            }
            return output;
        }

        public void LogIn(string userName, string password)
        {
            Console.WriteLine();
        }

    }
}
