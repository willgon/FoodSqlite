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
using Modulo1.Dal;

namespace Modulo1.Pages.Entregadores
{
        
    public partial class EntregadoresListPage : ContentPage
    {
        private EntregadorDAL dalEntregador = EntregadorDAL.GetInstance();

        public EntregadoresListPage()
        {
            InitializeComponent();
            lvEntregadores.ItemsSource = dalEntregador.GetAll();

        }
    }
}
