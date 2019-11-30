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
    public partial class PearPage : ContentPage
    {
        public List<Product> Products { get; set; }
        public PearPage()
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
                Image = "pear2.jpg",
                Description = "Pear Fragrance Mist",
                Price = 165
            };

            Products.Add(product);

            product = new Product
            {
                Image = "pear3.jpg",
                Description = "Pear Soap",
                Price = 60
            };

            Products.Add(product);

            product = new Product
            {
                Image = "pear4.jpg",
                Description = "Pear Body Yogurt",
                Price = 150
            };

            Products.Add(product);


            product = new Product
            {
                Image = "pear5.jpg",
                Description ="Pear Hand Cream",
                Price = 70
            };

            Products.Add(product);

            product = new Product
            {
                Image = "pear6.jpg",
                Description = "Pear Hand Wash",
                Price = 110
            };

            Products.Add(product);


            product = new Product
            {
                Image = "pear7.jpg",
                Description = "Pear Body Butter",
                Price = 195
            };

            Products.Add(product);


            BindingContext = this;
        }

       
        private async void CollectionView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = e.CurrentSelection[0] as Product;

            await Navigation.PushAsync(new DetailsPage(selectedItem));
        }
    }
}


