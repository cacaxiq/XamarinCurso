using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using PropertyChanged;
using Xamarin.Forms;

namespace FeiraMTG
{
    [ImplementPropertyChanged]
    public class WantCardsListViewModel
    {

        public ObservableCollection<Card> CardList
        {
            get;
            set;
        }

        public WantCardsListViewModel()
        {
            this.CardList = new ObservableCollection<Card> {
                new Card{
                    Nome ="Anjo da Restauração",
                    Detalhe = "Disponiveis: 8 unidades - Conservaçao: SP",
                    Imagem = ImageSource.FromResource("FeiraMTG.Images.AnjoRestauracao.jpg")
                },
                new Card{
                    Nome ="Anjo Serra",
                    Detalhe = "Disponiveis: 1 unidades - Conservaçao: HP",
                    Imagem = ImageSource.FromResource("FeiraMTG.Images.AnjoSerra.jpg")
                },
                new Card{
                    Nome ="Birds of Paradise",
                    Detalhe = "Disponiveis: 2 unidades - Conservaçao: MP",
                    Imagem = ImageSource.FromResource("FeiraMTG.Images.Birds.jpg")
                },
                new Card{
                    Nome ="Brainstorm",
                    Detalhe = "Disponiveis: 10 unidades - Conservaçao: NM",
                    Imagem = ImageSource.FromResource("FeiraMTG.Images.BrainStorm.jpg")
                },
                new Card{
                    Nome ="Counterspell",
                    Detalhe = "Disponiveis: 7 unidades - Conservaçao: MP",
                    Imagem = ImageSource.FromResource("FeiraMTG.Images.Counterspell.jpg")
                }
            };
        }
    }
}
