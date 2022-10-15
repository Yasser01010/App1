using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        static Controllers.DBemple dbemple;

        public static Controllers.DBemple DBemple
        {
            get 
            {
                if (dbemple == null)
                {
                    String dbname = "EmpleDB.db3";
                    String pathdb = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbname);
                    dbemple = new Controllers.DBemple();
                }
                return dbemple;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PagePrincipal());
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
