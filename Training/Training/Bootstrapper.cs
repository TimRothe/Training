using FreshMvvm;
using Training.ViewModels;
using Xamarin.Forms;

namespace Training
{
    public class Bootstrapper
    {
        public Page CreateMainPage()
        {
            var mainPage = FreshPageModelResolver.ResolvePageModel<MainViewModel>();
            var mainContainer = new FreshNavigationContainer(mainPage);

            return mainContainer;
        }
    }
}