using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppViajes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
