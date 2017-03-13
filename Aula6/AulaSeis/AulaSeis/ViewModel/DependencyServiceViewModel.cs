using System;
using System.Diagnostics.Contracts;
using System.Windows.Input;
using AulaSeis.DependencyServices;
using AulaSeis.Infra;
using Xamarin.Forms;

namespace AulaSeis.ViewModel
{
    public class DependencyServiceViewModel : ObservedClass
    {
        public DependencyServiceViewModel()
        {
        }

        private string _textToTalk;
        public string TextToTalk
        {
            get { return _textToTalk; }
            set { _textToTalk = value; OnPropertyChanged(); }
        }


        public ICommand Talk
        {
            get { return new Command(() => DependencyService.Get<ITalkCell>().TextToTalk(this.TextToTalk)); }
        }


        public void Teste()
        {
            DependencyService.Get<ITalkCell>().TextToTalk("Curso Zarb Solutions na ATTPS!");
        }
    }
}
