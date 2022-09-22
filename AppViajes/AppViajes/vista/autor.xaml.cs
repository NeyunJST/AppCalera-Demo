using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppViajes.vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class autor : ContentPage
    {
        public ICommand TapCommand => new Command<string>((url) =>
        {
            Device.OpenUri(new System.Uri(url));
        });
        public autor()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}