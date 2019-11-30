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
    public partial class SideWidePage : ContentPage
    {
        public SideWidePage()
        {
            InitializeComponent();
        }
        public List<Product> Products { get; set; }
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
                Image = "t2.jpg",
                Description = "Tea Tree Facial Wash",
                Price = 150
            };

            Products.Add(product);

            product = new Product
            {
                Image = "t3.jpg",
                Description = "Tea tree Oil",
                Price = 60
            };

            Products.Add(product);

            product = new Product
            {
                Image = "t4.jpg",
                Description = "Tea Tree Night Lotion",
                Price = 90
            };

            Products.Add(product);


            product = new Product
            {
                Image = "t5.jpg",
                Description = "Tea Tree Scrub mask",
                Price = 80
            };

            Products.Add(product);

            product = new Product
            {
                Image = "t6.jpg",
                Description = "Tea Tree Mattifyng Lotion",
                Price = 90
            };

            Products.Add(product);


            product = new Product
            {
                Image = "t7.jpg",
                Description = "Tea Tree Peel-off Mask",
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