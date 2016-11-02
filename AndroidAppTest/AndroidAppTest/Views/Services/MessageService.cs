using AndroidAppTest.ViewModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidAppTest.Views.Services
{
    public class MessageService : IMessageService
    {
        public async Task MessageBox(string message)
        {
            await App.Current.MainPage.DisplayAlert("AndroidTestApp", message, "ok");
        }
    }
}
