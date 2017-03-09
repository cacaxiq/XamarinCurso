using System;
namespace WebService.Infra.Interface
{
    public interface INavigationService
    {
        //
        // Properties
        //
        string CurrentPageKey
        {
            get;
        }

        //
        // Methods
        //
        void GoBack();

        void NavigateTo(string pageKey);

        void NavigateTo(string pageKey, object parameter);
    }
}
