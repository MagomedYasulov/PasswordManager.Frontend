using PasswordManager.Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Frontend.ViewModels
{
    public class PasswordViewModel : ViewModelBase
    {
        private readonly Credential _credential;
        public PasswordViewModel(Credential credential) 
        {
            _credential = credential;
        }

        public string Login => "username"; //_credential.Login;
        public string Password => "nUMjn8hfbYD7v8"; //_credential.Password;
        public string Service => "Gmail"; //_credential.Service ?? string.Empty;
    }
}
