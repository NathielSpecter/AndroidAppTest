using AndroidAppTest.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidAppTest.Views.Services
{
    public class NavigationService : INavigationService
    {
        public async Task NavegarParaListarView()
        {
            await App.Current.MainPage.Navigation.PushAsync(new ListarView());
        }

        public async Task NavegarParaCadastroView()
        {
            await App.Current.MainPage.Navigation.PushAsync(new CadastroView());
        }
    }
}
