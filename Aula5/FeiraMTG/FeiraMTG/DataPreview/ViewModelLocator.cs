using System;
namespace FeiraMTG
{
    public static class ViewModelLocator
    {

        static WantCardsListViewModel testeVM;

        public static WantCardsListViewModel TesteVM
        => testeVM ?? (testeVM = new WantCardsListViewModel());
    }
}
