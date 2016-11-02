using AndroidAppTest.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AndroidAppTest.ViewModel
{
    public class MainPageViewModel
    {

        public ICommand CadastrarViewCommand { get; set; }

        public ICommand ListarViewCommand { get; set; }

        private readonly INavigationService _navigationService;
        

        public MainPageViewModel()
        {
            CadastrarViewCommand = new Command(Cadastrar);
            ListarViewCommand = new Command(Listar);
            _navigationService = DependencyService.Get<INavigationService>();
        }

        private async void Listar()
        {
            await _navigationService.NavegarParaListarView();
        }

        private async void Cadastrar()
        {
            await _navigationService.NavegarParaCadastroView();
        }
    }
}
