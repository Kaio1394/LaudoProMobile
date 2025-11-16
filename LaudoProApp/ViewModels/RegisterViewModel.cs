using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaudoProApp.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _fullName;

        [ObservableProperty]
        private string _username;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _confirmPassword;

        [ObservableProperty]
        private string _cpfCnpj;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private bool _isTermsAccepted;

        [ObservableProperty]
        private bool _itsCommonUser;

        private bool itsCompanyUser => !ItsCommonUser;
        private bool isUserValid => ValidateInputs();

        [RelayCommand]
        public void DoRegister()
        {
            if(!isUserValid)
            {
                return;
            }
        }

        public bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(FullName))
                return false;
            if (string.IsNullOrEmpty(Username))
                return false;
            if (string.IsNullOrEmpty(Email))
                return false;
            if (string.IsNullOrEmpty(CpfCnpj))
                return false;
            if (string.IsNullOrEmpty(Username))
                return false;

            if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmPassword))
                return false;
            if (Password != ConfirmPassword)
                return false;
            return true;
        }
    }
}
