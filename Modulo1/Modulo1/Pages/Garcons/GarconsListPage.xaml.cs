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
using Modulo1.Modelo;

namespace Modulo1.Pages.Garcons
{

    public partial class GarconsListPage : ContentPage
    {
        private GarcomDAL dalGarcom = GarcomDAL.GetInstance();

        public GarconsListPage()
        {
            InitializeComponent();
            lvGarcons.ItemsSource = dalGarcom.GetAll();

        }

        public async void OnRemoverClick(Object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = mi.CommandParameter as Garcom;
            var opcao = await DisplayAlert("Confirmação de exclusão", "Confirma excluir o item" + item.Nome.ToUpper() + "?", "Sim", "Não");
            if (opcao)
            {
                dalGarcom.Remove(item);
            }
        }

        public async void OnAlterarClick(Object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = mi.CommandParameter as Garcom;
            await Navigation.PushModalAsync(new GarconsEditPage(item));
        }
    }
}