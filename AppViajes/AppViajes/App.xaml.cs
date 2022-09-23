using AppViajes.data;
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
            crearBD();
            //Navigationpage es para navegar entre páginas de contenido
            MainPage = new NavigationPage(new MainPage());
        }

        public static DbContexto contexto { get; set; }

        private void crearBD()
        {
            //la BD se crea en el proyecto
            var carpeta = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var data = System.IO.Path.Combine(carpeta, "Viajes.db3");
            contexto = new DbContexto(data);
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
