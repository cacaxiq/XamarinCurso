using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WebService.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public BaseViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
