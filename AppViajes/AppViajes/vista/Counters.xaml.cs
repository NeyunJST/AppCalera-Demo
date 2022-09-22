using AppViajes.modelo;
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
    public partial class Counters : ContentPage
    {
        public Counters()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CargarCounters();
        }
        private async void CargarCounters()
        {
            var reg_counters = await App.contexto.GetCounters();
            listado.ItemsSource = reg_counters;
        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ing_Counters());
        }

        private async void BtnEliminar_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Responder", "¿Desea eliminar?", "Si", "No"))
            {
                var elemento = (ClsCounters)(sender as MenuItem).CommandParameter;
                var nreg = await App.contexto.eliminar(elemento.id_counter);
                if (nreg == 1)
                {
                    CargarCounters();
                }
            }
        }
    }
}