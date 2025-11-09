using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaudoProApp.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _username;

        [ObservableProperty]
        private string _password;

        [RelayCommand]
        public void DoLogin()
        {
            // Implement login logic here
        }
    }
}
