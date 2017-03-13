using System;
using System.Collections.ObjectModel;
using PropertyChanged;
using Xamarin.Forms;

namespace FeiraMTG
{
    [ImplementPropertyChanged]
    public class ChangedCardsListViewModel
    {
        public ObservableCollection<Card> CardList
        {
            get;
            set;
        }

        public ChangedCardsListViewModel()
        {
            this.CardList = new ObservableCollection<Card> {
                new Card{
                    Nome ="Ponder",
                    Detalhe = "Disponiveis: 2 unidades - Conservaçao: NM",
                    Imagem = ImageSource.FromResource("FeiraMTG.Images.Ponder.jpg")
                },
                new Card{
                    Nome ="Raio",
                    Detalhe = "Disponiveis: 1 unidades - Conservaçao: MP",
                    Imagem = ImageSource.FromResource("FeiraMTG.Images.Raio.jpg")
                },
                new Card{
                    Nome ="Red Ward",
                    Detalhe = "Disponiveis:4 unidades - Conservaçao: NM",
                    Imagem = ImageSource.FromResource("FeiraMTG.Images.RedWard.jpg")
                },
                new Card{
                    Nome ="Stone rain",
                    Detalhe = "Disponiveis: 9 unidades - Conservaçao: HP",
                    Imagem = ImageSource.FromResource("FeiraMTG.Images.StoneRain.jpg")
                },
                new Card{
                    Nome ="Thalia, Guardian of Thraben",
                    Detalhe = "Disponiveis: 1 unidades - Conservaçao: SP",
                    Imagem = ImageSource.FromResource("FeiraMTG.Images.Thalia.jpg")
                }
            };
        }
    }
}
