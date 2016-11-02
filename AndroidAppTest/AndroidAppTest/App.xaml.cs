using AndroidAppTest.ViewModel.Services;
using AndroidAppTest.Views;
using AndroidAppTest.Views.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AndroidAppTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<IMessageService,MessageService>();
            DependencyService.Register<INavigationService, NavigationService>();
            MainPage = new NavigationPage(new MainPageView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
