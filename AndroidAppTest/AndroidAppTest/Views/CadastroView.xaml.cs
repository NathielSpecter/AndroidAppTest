using AndroidAppTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AndroidAppTest.Views
{
    public partial class CadastroView : ContentPage
    {
        public CadastroView()
        {
            InitializeComponent();

            BindingContext = new CadastroViewModel();
        }
    }
}
