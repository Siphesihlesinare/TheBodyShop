using SinareBodyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SinareBodyApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public Product CurrentProduct { get; set; }

        public DetailsPage(Product product)
        {
            InitializeComponent();

            CurrentProduct  = product;
            BindingContext = CurrentProduct;
        }

        private async void AddToCart_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderListPage());
        }

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderListPage());
        }
    }
}