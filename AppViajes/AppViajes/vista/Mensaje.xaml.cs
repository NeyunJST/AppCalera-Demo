using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViajes.vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class Mensaje : ContentPage
    {
        public Mensaje()
        {
            InitializeComponent();
            DisplayItemsPicker();
        }

        private async void btnEnvio_Clicked(object sender, EventArgs e)
        {
            await Sms.ComposeAsync(new SmsMessage {
                Body=txtMen.Text,
                Recipients=new List<string> { txtMen.Text } 
            });
        }
        private void DisplayItemsPicker()
        {            
            pickerTelf.Items.Add("Urgencia");
            pickerTelf.Items.Add("Emergencia");
            
        }

        private void btnLlamar_Clicked(object sender, EventArgs e)
        {
            var numero = " ";
            if (pickerTelf.SelectedIndex == 0) {
                numero = "934477510";
            } else {
                numero = "944990868";
            }
            try
            {
                PhoneDialer.Open(numero);
            }
            catch(Exception ex)
            {
                DisplayAlert("No se pudo realizar la llamada", "intentelo más tarde", "OK");
            }
        }
    }
}