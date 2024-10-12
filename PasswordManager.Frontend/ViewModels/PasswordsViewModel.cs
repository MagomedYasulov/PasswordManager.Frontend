using ReactiveUI;
using System.Diagnostics;
using System.Windows.Input;

namespace PasswordManager.Frontend.ViewModels
{
    public class PasswordsViewModel : ViewModelBase
    {
        //public ICommand AddCredentialCommand { get; }

        public string Test => "Test";

        public PasswordsViewModel()
        {
            //AddCredentialCommand = ReactiveCommand.Create(() =>
            //{
            //    Debug.WriteLine("Clicked AddCredentialCommand");
            //});
        }
    }
}
