using FrontEndFM.Views;
using FrontEndFM.Views.Principal;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrontEndFM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
