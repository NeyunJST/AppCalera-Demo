using AppViajes.modelo;
using AppViajes.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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
            Foto.Add(new ClsImagenes
            {
                imagen = "Calmacen.jpg",
            });
            Foto.Add(new ClsImagenes
            {
                imagen = "Cfundador.jpg",
            });
            Foto.Add(new ClsImagenes
            {
                imagen = "Cfrutos.jpg",
            });

            BindingContext = this;
        }
        private async void btnIntranet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new vista.Login());
        }

        private async void Barra_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new vista.inicio());
        }



        private async void btnAcceso_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new vista.inicio());
        }

        private void btnLlamar_Clicked(object sender, EventArgs e)
        {
            try
            {
                PhoneDialer.Open("923697331");
            }
            catch (Exception ex)
            {
                DisplayAlert("No se pudo realizar la llamada", "intentelo más tarde", "OK");
            }
        }

    }
}
