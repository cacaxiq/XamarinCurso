using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AulaSeis.Infra
{
    public class ObservedClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void OnPropertyChangedByName(string name)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
