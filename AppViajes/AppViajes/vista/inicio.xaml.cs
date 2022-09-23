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


        private async void btnIntranet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
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