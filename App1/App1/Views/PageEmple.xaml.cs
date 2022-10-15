using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageEmple : ContentPage
    {
        public PageEmple()
        {
            InitializeComponent();
        }

        private void btnsegunda_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnAgergar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Empleado
            {
                nombre = txtnombre.Text,
                apellidos = txtapellido.Text,
                edad = Convert.ToInt32(txtedad.Text),
                correos = txtcorreo.Text
            };

            if (await App.DBemple.StoreEmple(emple) > 0)
            {
                await DisplayAlert("Aviso", "Empleado Agregado", "OK");
            }


        }
    }
}