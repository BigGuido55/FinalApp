using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FinalApp
{
    class PasswordView : BaseViewModel
    {
        Boolean isEnabled;
        public Boolean IsEnabled {
            get => isEnabled;
            set => SetProperty(ref isEnabled, value); }

        public PasswordView()
        {
            IsEnabled = false;
        }

        ICommand enableLogin;
        public ICommand EnableLogin => enableLogin ?? (enableLogin = new Command<string>(IsButtonEnabled));

        public void IsButtonEnabled(string text)
        {
            if (text.Length >= 5 && text.Length <= 10) IsEnabled = true;
            else IsEnabled = false;
        }


    }
}
