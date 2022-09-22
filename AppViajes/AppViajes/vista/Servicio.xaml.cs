using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViajes.vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Servicio : ContentPage
    {
        public Servicio()
        {
            InitializeComponent();
        }

        private void btn_bbva_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.rhsoftperu.com", BrowserLaunchMode.SystemPreferred);
        }

        private void btn_pago_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.senati.edu.pe", BrowserLaunchMode.SystemPreferred);
        }

        private async void btn_diners_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Terminales());
        }
    }
}