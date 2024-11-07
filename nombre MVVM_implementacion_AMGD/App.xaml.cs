using nombre_MVVM_implementacion_AMGD.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nombre_MVVM_implementacion_AMGD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pagina1();
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
