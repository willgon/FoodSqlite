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
using Modulo1.Modelo;
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

        public async void OnRemoverClick(Object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = mi.CommandParameter as Entregador;
            var opcao = await DisplayAlert("Confirmação de exclusão", "Confirma excluir o item" + item.Nome.ToUpper() + "?", "Sim", "Não");
            if (opcao)
            {
                dalEntregador.Remove(item);
            }
        }

        public async void OnAlterarClick(Object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = mi.CommandParameter as Entregador;
            await Navigation.PushModalAsync(new EntregadoresEditPage(item));
        }
    }
}