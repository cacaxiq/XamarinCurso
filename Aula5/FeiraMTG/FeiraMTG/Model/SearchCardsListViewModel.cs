using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using PropertyChanged;
using Xamarin.Forms;

namespace FeiraMTG
{
    [ImplementPropertyChanged]
    public class SearchCardsListViewModel
    {
        public List<Card> CardList
        {
            get;
            set;
        }

        private List<Card> CardListPrivate;

        public SearchCardsListViewModel()
        {
            this.CardListPrivate = new List<Card> {
                new Card{
                    Nome ="Garruk Relentless",
                    Detalhe = "Disponiveis: 4 unidades - Conservaçao: NM",
                    Imagem = ImageSource.FromResource("FeiraMTG.Images.Garruk.jpg")
                }
                //,
                //new Card{
                //    Nome ="Liliana of the Veil",
                //    Detalhe = "Disponiveis: 2 unidades - Conservaçao: SP",
                //    Imagem = ImageSource.FromResource("FeiraMTG.Images.Liliana.jpg")
                //},
                //new Card{
                //    Nome ="Mox Pearl",
                //    Detalhe = "Disponiveis: 20 unidades - Conservaçao: HP",
                //    Imagem = ImageSource.FromResource("FeiraMTG.Images.Mox.jpg")
                //},
                //new Card{
                //    Nome ="Mutavault",
                //    Detalhe = "Disponiveis: 10 unidades - Conservaçao: NM",
                //    Imagem = ImageSource.FromResource("FeiraMTG.Images.Mutavault.jpg")
                //},
                //new Card{
                //    Nome ="Pack Rat",
                //    Detalhe = "Disponiveis: 17 unidades - Conservaçao: MP",
                //    Imagem = ImageSource.FromResource("FeiraMTG.Images.PackRat.jpg")
                //},
                //new Card{
                //    Nome ="Diabolic Tutor",
                //    Detalhe = "Disponiveis: 17 unidades - Conservaçao: MP",
                //    Imagem = ImageSource.FromResource("FeiraMTG.Images.Tutor.jpg")
                //}
            };

            this.CardList = this.CardListPrivate;
        }
    }
}
