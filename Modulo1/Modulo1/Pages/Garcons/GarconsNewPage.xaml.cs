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
    public partial class GarconsNewPage : ContentPage
    {
        private GarcomDAL dalGarcons = GarcomDAL.GetInstance();
        public GarconsNewPage()
        {
            InitializeComponent();
            PreparaParaNovoGarcom();
        }
        public void BtnGravarClick(object sender, EventArgs e)
        {
            if (nome.Text.Trim() == string.Empty )
            {
                this.DisplayAlert("Erro",
                    "Você precisa informar o nome para o novo entregador.",
                    "OK");
            }
            else
            {
                dalGarcons.Add(new Garcom()
                {
                    Id = Convert.ToUInt32(idgarcom.Text),
                    Nome = nome.Text,
                    
                });
                PreparaParaNovoGarcom();
            }
        }
        private void PreparaParaNovoGarcom()
        {
            var novoId = dalGarcons.GetAll().Max(x => x.Id) + 1;
            idgarcom.Text = novoId.ToString().Trim();
            nome.Text = string.Empty;
            

        }
    }

}
