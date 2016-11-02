using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidAppTest.ViewModel.Services
{
    public interface INavigationService
    {
        Task NavegarParaCadastroView();
        Task NavegarParaListarView();
    }
}
