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
    public partial class VannilaPage : ContentPage
    {
        public List<Product> Products { get; set; }

        public VannilaPage()
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
                Image = "vani2.jpg",
                Description = "Body Soap - 75g",
                Price = 499
            };

            Products.Add(product);

            product = new Product
            {
                Image = "vani3.jpg",
                Description = "Body Scrub - 200ml ",
                Price = 299
            };

            Products.Add(product);

            product = new Product
            {
                Image = "vani4.jpg",
                Description = "Body Yogurt - 200ml",
                Price = 93
            };

            Products.Add(product);


            product = new Product
            {
                Image = "vani5.jpg",
                Description = "Hand Cream - 30ml",
                Price = 84
            };

            Products.Add(product);

            product = new Product
            {
                Image = "vani6.jpg",
                Description = " Shower Gel - 250ml",
                Price = 29
            };

            Products.Add(product);


            product = new Product
            {
                Image = "vani7.jpg",
                Description = "Body Scrub - 250ml",
                Price = 43
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