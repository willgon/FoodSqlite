using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Modulo1.Pages.Entregadores;
using Modulo1.Pages.Garcons;

namespace Modulo1.Pages
{
        
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            
        }

        private async void GarconsOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new GarconsPage());
        }

        private async void EntregadoresOnClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new EntregadoresPage());
        }
    }
  
}
