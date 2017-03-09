using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class SignInViewModel : INotifyPropertyChanged
    {
        private bool _signInRequired;
        public bool SignInRequired
        { 
            get
            {
                return _signInRequired;
            }
            private set
            {
                _signInRequired = value;
                RaisePropertyChanged();

            }
        }

        public SignInViewModel()
        {
            SignInRequired = true;
        }

        public void SignIn()
        {
            SignInRequired = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string property = null)
        {
            var propChanged = PropertyChanged;
            if (propChanged != null)
            {
                propChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
