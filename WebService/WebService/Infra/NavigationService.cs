using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace WebService.Infra
{
    public class NavigationService
    {
        private Dictionary<string, Type> pages { get; } = new Dictionary<string, Type>();

        public Page MainPage => Application.Current.MainPage;

        public void Configure(string key, Type pageType) => pages[key] = pageType;

        public void GoBack() => MainPage.Navigation.PopAsync();

        public void NavigateTo(string pageKey, object parameter = null, HistoryBehavior historyBehavior = HistoryBehavior.Default)
        {
            Type pageType;
            if (pages.TryGetValue(pageKey, out pageType))
            {
                var displayPage = (Page)Activator.CreateInstance(pageType);
                displayPage.SetNavigationArgs(parameter);

                if (historyBehavior == HistoryBehavior.ClearHistory)
                {
                    MainPage.Navigation.InsertPageBefore(displayPage, MainPage.Navigation.NavigationStack[0]);

                    var existingPages = MainPage.Navigation.NavigationStack.ToList();
                    for (int i = 1; i < existingPages.Count; i++)
                        MainPage.Navigation.RemovePage(existingPages[i]);
                }
                else
                {
                    MainPage.Navigation.PushModalAsync(displayPage);
                }
            }
            else
            {
                throw new ArgumentException($"No such page: {pageKey}.",
                    nameof(pageKey));
            }
        }
    }

    public enum HistoryBehavior
    {
        Default,
        ClearHistory
    }

    public static class NavigationExtensions
    {
        private static ConditionalWeakTable<Page, object> arguments = new ConditionalWeakTable<Page, object>();

        public static object GetNavigationArgs(this Page page)
        {
            object argument = null;
            arguments.TryGetValue(page, out argument);

            return argument;
        }

        public static void SetNavigationArgs(this Page page, object args)
            => arguments.Add(page, args);
    }
}
