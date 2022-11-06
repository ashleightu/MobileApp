using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShoppingUI.ViewModels
{
    public class LandingViewModel
    {
        public ICommand StartCommand { get; private set; }

        private INavigation Navigation;

        public LandingViewModel(INavigation navigation)
        {
            StartCommand = new Command(OnStartCommand);
            Navigation = navigation;

        }
        private async void OnStartCommand(object obj)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }

    }
}
