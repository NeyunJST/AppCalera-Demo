using AppViajes.modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViajes.vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Motorizados : ContentPage
    {
        public Motorizados()
        {
            InitializeComponent();
        }

        private async void btn_api_Clicked(object sender, EventArgs e)
        {
            try
            {
                var request = new HttpRequestMessage();
                request.RequestUri = new Uri("https://www.rhsoftperu.com/servicio/servicio.php");
                request.Method = HttpMethod.Get;
                request.Headers.Add("Accept", "application/json");

                var client = new HttpClient();
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<List<ClsMotorizados>>(json);

                    Listado_Motorizado.ItemsSource = data;
                }



            }catch(Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Aceptar");
            }
        }
    }
}