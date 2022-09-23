using AppViajes.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViajes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
            cargarLista();
        }
        public List<ClsImagenes> Foto { get; set; }
        private void cargarLista()
        {
            Foto = new List<ClsImagenes>();
            Foto.Add(new ClsImagenes
            {

                imagen = "Cfondologin.jpg",
            });
            Foto.Add(new ClsImagenes
            {
                imagen = "Cfondoregistro.jpg",
            });
            BindingContext = this;
        }


        private async void Barra_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new vista.inicio());
        }

        private async void btnAcceso_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new vista.inicio());
        }


    }
}
