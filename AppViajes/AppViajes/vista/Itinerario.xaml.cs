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
    public partial class Itinerario : ContentPage
    {
        
        public Itinerario()
        {
            InitializeComponent();
            lista01.Items.Add("Mala");
            lista01.Items.Add("Cañete");
            lista01.Items.Add("Chincha");
            lista01.Items.Add("Ica");

            lista02.Items.Add("Mala");
            lista02.Items.Add("Cañete");
            lista02.Items.Add("Chincha");
            lista02.Items.Add("Ica");

        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {

        }
    }
}