using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appblacar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.ViajePage();
            MainPage = new Views.TabsPage();
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
