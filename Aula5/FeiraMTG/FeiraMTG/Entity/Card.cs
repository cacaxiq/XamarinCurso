using PropertyChanged;
using Xamarin.Forms;

namespace FeiraMTG
{
    [ImplementPropertyChanged]
    public class Card
    {
        public Card()
        {
        }

        public string Nome
        {
            get;
            set;
        }

        public string Detalhe
        {
            get;
            set;
        }

        public ImageSource Imagem
        {
            get;
            set;
        }

        public string NomeUsuario
        {
            get;
            set;
        }
    }
}
