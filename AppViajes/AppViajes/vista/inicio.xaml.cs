using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViajes.vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();
        }

        private async void btnTerminales_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Terminales());
        }

        private async void btnServicios_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Servicio());
        }

        private async void btnIntranet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private async void btnAPI_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Motorizados());
        }

        private async void btnItinerario_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Itinerario());
        }

        private async void btnCounter_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Counters());
        }

        private async void btnMensaje_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Mensaje());
        }

        private async void btnAutor_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new autor());
        }
    }
}