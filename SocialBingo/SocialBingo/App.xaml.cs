using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SocialBingo.Services;
using SocialBingo.Views;

namespace SocialBingo
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}
