using Modulo1.Dal;
using Modulo1.Modelo;
using PCLStorage;
using Plugin.Media;
using System;

using Xamarin.Forms;

namespace Modulo1.Pages.Garcons
{
    public partial class GarconsEditPage : ContentPage
    {
        private Garcom garcom;
        private GarcomDAL dalGarcom = GarcomDAL.GetInstance();
        public GarconsEditPage(Garcom garcom)
        {
            InitializeComponent();
            PopularFormulario(garcom);
        }

        private void PopularFormulario(Garcom garcom)
        {
            this.garcom = garcom;
            idgarcom.Text = garcom.Id.ToString();
            nome.Text = garcom.Nome;
        }

        public async void BtnGravarClick(object sender, EventArgs e)
        {
            if (nome.Text.Trim() == string.Empty)
            {
                await this.DisplayAlert("Erro", "Você precisa informar o nome para o novo garcom.", "OK");
            }
            else
            {
                this.garcom.Nome = nome.Text;
                dalGarcom.Update(this.garcom);
                await Navigation.PopModalAsync();
            }
        }
    }
}