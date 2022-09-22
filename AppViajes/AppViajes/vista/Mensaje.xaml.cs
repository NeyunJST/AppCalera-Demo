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
    public partial class Mensaje : ContentPage
    {
        public Mensaje()
        {
            InitializeComponent();
        }

        private async void btnEnvio_Clicked(object sender, EventArgs e)
        {
            await Sms.ComposeAsync(new SmsMessage {
                Body=txtMen.Text,
                Recipients=new List<string> { txtCel.Text } 
            });
        }
    }
}