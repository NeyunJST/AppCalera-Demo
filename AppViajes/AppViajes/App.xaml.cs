
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViajes
{
    public partial class App : Application
    {
        //Class contiene propiedades y métodos
        // App es un constructor
        public App()
        {
            InitializeComponent();
            //Navigationpage es para navegar entre páginas de contenido
            MainPage = new NavigationPage(new MainPage());
        }


        //-------------------------------
        //        M É T O D O S
        //-------------------------------
        // override -> Sobreescribir el método OnStart
        // Los métodos pueden public | private | protected
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
