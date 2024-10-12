using Avalonia.Controls;
using Avalonia.ReactiveUI;
using PasswordManager.Frontend.ViewModels;

namespace PasswordManager.Frontend.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}