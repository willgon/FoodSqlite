using Modulo1.Dal;
using Modulo1.Modelo;
using System;

using Xamarin.Forms;

namespace Modulo1.Pages.Entregadores
{
    public partial class EntregadoresEditPage : ContentPage
    {
        private Entregador entregador;
        private EntregadorDAL dalEntregador = EntregadorDAL.GetInstance();
        public EntregadoresEditPage(Entregador entregador)
        {
            InitializeComponent();
            PopularFormulario(entregador);
        }

        private void PopularFormulario(Entregador entregador)
        {
            this.entregador = entregador;
            identregador.Text = entregador.Id.ToString();
            nome.Text = entregador.Nome;
            telefone.Text = entregador.Telefone;
        }

        public async void BtnGravarClick(object sender, EventArgs e)
        {
            if (nome.Text.Trim() == string.Empty)
            {
                await this.DisplayAlert("Erro", "Você precisa informar o nome para o novo entregador.", "OK");
            }
            else
            {
                this.entregador.Nome = nome.Text;
                this.entregador.Telefone = telefone.Text;
                dalEntregador.Update(this.entregador);
                await Navigation.PopModalAsync();
            }
        }
    }
}