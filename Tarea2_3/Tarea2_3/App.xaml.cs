using System;
using Tarea2_3.Services;
using Tarea2_3.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea2_3
{
    public partial class App : Application
    {
        public static string    dbfirma = string.Empty;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

        }
        public App(string db)
        {
            InitializeComponent();
            dbfirma = db;
            MainPage = new NavigationPage(new MainPage());
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
