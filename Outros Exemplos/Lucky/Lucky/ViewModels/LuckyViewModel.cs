using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lucky.ViewModels
{
    public class LuckyViewModel : BaseViewModel
    {
        public LuckyViewModel()
        {

            Restart();
        }

        bool canExecute = true;

        private int countCorrects;
        public int CountCorrects
        {
            get { return countCorrects; }
            set { countCorrects = value; OnPropertyChanged(); }
        }

        private int errors;
        public int Errors
        {
            get { return errors; }
            set { errors = value; OnPropertyChanged(); }
        }

        private int steps;
        public int Steps
        {
            get { return steps; }
            set { steps = value; OnPropertyChanged(); }
        }

        private int life;
        public int Life
        {
            get { return life; }
            set { life = value; OnPropertyChanged(); }
        }

        private Color color1;
        public Color Color1
        {
            get { return color1; }
            set { color1 = value; }
        }

        private Color color2;
        public Color Color2
        {
            get { return color2; }
            set { color2 = value; }
        }

        private Color _color;
        public Color Color
        {
            get { return _color; }
            set { _color = value; OnPropertyChanged(); }
        }

        private bool derrota;
        public bool Derrota
        {
            get { return derrota; }
            set { derrota = value; OnPropertyChanged(); }
        }

        public ICommand ActionRightCommand
        {
            get { return new Command(() => ChangeBackGroundRight(), () => canExecute); }
        }

        public ICommand ActionLeftCommand
        {
            get { return new Command(() => ChangeBackGroundLeft(), () => canExecute); }
        }

        public ICommand RestartCommand
        {
            get { return new Command(() => Restart(), () => canExecute); }
        }

        private void ChangeBackGroundRight()
        {
            CanExecuteCommand(false, ActionRightCommand);
            Color = Color1;
            ChangedColor();
            ExecuteRules();
            CanExecuteCommand(true, ActionRightCommand);
        }

        private void ChangeBackGroundLeft()
        {
            CanExecuteCommand(false, ActionLeftCommand);
            Color = Color2;
            ChangedColor();
            ExecuteRules();
            CanExecuteCommand(true, ActionLeftCommand);
        }

        private void ChangedColor()
        {
            var random = new Random();

            int indice = random.Next(1, 100);

            if ((indice % 2) == 0)
            {
                Color1 = Color.Green;
                Color2 = Color.Red;
            }
            else
            {
                Color1 = Color.Red;
                Color2 = Color.Green;
            }
        }

        private void ExecuteRules()
        {
            if (Color == Color.Red)
            {
                Error();
            }
            else
            {
                Correct();
            }

            Steps++;
        }

        private void Error()
        {
            CountCorrects = 0;
            Life--;
            Errors++;

            if (Life == 0)
                Derrota = true;
        }

        private void Correct()
        {
            CountCorrects++;
            Life++;

            if (CountCorrects % 5 == 0)
                Life = Life + 2;
        }

        private void Restart()
        {
            CanExecuteCommand(false, RestartCommand);
            Color = Color.Gray;
            Life = 5;
            Steps = 0;
            Errors = 0;
            CountCorrects = 0;
            Derrota = false;
            CanExecuteCommand(true, RestartCommand);
        }

        private void CanExecuteCommand(bool value, ICommand command)
        {
            canExecute = value;
            ((Command)command).ChangeCanExecute();
        }
    }
}
