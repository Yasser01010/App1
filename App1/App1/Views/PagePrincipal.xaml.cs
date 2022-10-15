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
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listemple.ItemsSource = await App.DBemple.ListaEmpleadosAll();
        }

        private void listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void tlbadd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageEmple());
        }

        private void tlbmap_Clicked(object sender, EventArgs e)
        {

        }
    }
}