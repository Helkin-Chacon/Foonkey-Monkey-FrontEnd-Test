using FrontEndFM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrontEndFM.Views.Principal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainViewModel viewModel { get; set; }
        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = viewModel;
        }
    }
}