using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppViajes.modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViajes.vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

   
    public partial class Terminales : ContentPage
    {
        //Propiedades
        public List<ClsTerminal> lstTerminales { get; set; }
       
        //Constructor
        public Terminales()
        {
            InitializeComponent();
            lstTerminales = new List<ClsTerminal>();
            lstTerminales.Add(new ClsTerminal
            {
                foto="mala.jpg", descrip="Terminal Mala"
            });

            lstTerminales.Add(new ClsTerminal
            {
                foto = "canete.jpg",
                descrip = "Terminal Cañete"
            });

            lstTerminales.Add(new ClsTerminal
            {
                foto = "chincha.jpg",
                descrip = "Terminal Chincha"
            });
            lstTerminales.Add(new ClsTerminal
            {
                foto = "ica.jpg",
                descrip = "Terminal Ica"
            });

            BindingContext = this;

        }
    }
}