using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PropiedadesEnlazables
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new UsandoPropiedadesEnlazables();
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
