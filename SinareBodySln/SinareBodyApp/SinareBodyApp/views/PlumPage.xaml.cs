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
    public partial class PlumPage : ContentPage
    {
        public List<Product> Products { get; set; }
        public PlumPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();


            PopulateProducts();
        }


        private void PopulateProducts()
        {
            Products = new List<Product>();

            var product = new Product
            {
                Image = "plum2.jpg",
                Description = "Shimmer Mist - 100ml",
                Price = 165
            };

            Products.Add(product);

            product = new Product
            {
                Image = "plum3.jpg",
                Description = "Plum Soap - 75g",
                Price = 60
            };

            Products.Add(product);

            product = new Product
            {
                Image = "plum4.jpg",
                Description = "Plum Lip Butter - 10ml",
                Price = 50
            };

            Products.Add(product);


            product = new Product
            {
                Image = "plum5.jpg",
                Description = "Plum Body Yogurt - 200ml",
                Price = 150
            };

            Products.Add(product);

            product = new Product
            {
                Image = "plum6.jpg",
                Description = "Plum Body Scrub - 250ml",
                Price = 200
            };

            Products.Add(product);


            product = new Product
            {
                Image = "plum7.jpg",
                Description = "Plum Hand Cream - 30ml",
                Price = 70
            };

            Products.Add(product);


            BindingContext = this;
        }
        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = e.CurrentSelection[0] as Product;

            await Navigation.PushAsync(new DetailsPage(selectedItem));
        }
    }
}