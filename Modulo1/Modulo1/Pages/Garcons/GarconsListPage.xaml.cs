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
    }
}
