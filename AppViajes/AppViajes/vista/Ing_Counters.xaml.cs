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
    public partial class Ing_Counters : ContentPage
    {
        public Ing_Counters()
        {
            InitializeComponent();
        }
        //public ClsCounters counter { get; set; }
        private async void btnGrabar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var reg = new ClsCounters
                {
                    nom_counter = txtNom.Text,
                    ape_counter = txtApe.Text,
                    dni_counter = txtDni.Text,
                    correo = txtCorreo.Text,
                    cel_counter = txtCel.Text
                };
                var respta = await App.contexto.ingresar(reg);
                if (respta == 1)
                {
                    //await DisplayAlert("Aviso", "se grabó los datos", "Aceptar");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Aviso", "No se grabó los datos", "Aceptar");
                }
            }catch(Exception er)
            {
                await DisplayAlert("Aviso", er.Message, "Aceptar");
            }
            
        }

        private void btnNuevo_Clicked(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtApe.Text = "";
            txtDni.Text = "";
            txtCorreo.Text = "";
            txtCel.Text = "";
            txtNom.Focus();
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {

        }
    }
}