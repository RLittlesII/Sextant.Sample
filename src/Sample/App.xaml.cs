using System;
using Genesis.Logging;
using ReactiveUI;
using Sextant;
using Sample.ViewModels;
using Sample.Views;
using Splat;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            RxApp.DefaultExceptionHandler = new SextantDefaultExceptionHandler();

            SextantHelper.RegisterView<HomeView, HomeViewModel>();
            SextantHelper.RegisterView<FirstModalView, FirstModalViewModel>();
            SextantHelper.RegisterView<SecondModalView, SecondModalViewModel>();
            SextantHelper.RegisterView<RedView, RedViewModel>();
            SextantHelper.RegisterNavigation<BlueNavigationView, SecondModalViewModel>();

            MainPage = SextantHelper.Initialize<HomeViewModel>();
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
