using SinareBodyApp.ShopData;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SinareBodyApp
{
    public partial class App : Application
    {
        
        private static ShopDatabase productDatabase;

        public static ShopDatabase Database
        {
            get
            {
                if (productDatabase == null)
                    productDatabase = new ShopDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TShirt.db3"));

                return productDatabase;

            }
        }

        public static object DataBase { get; internal set; }

        public App()
        {
            InitializeComponent();
            var mainPage = new MainPage();
            var navPage = new NavigationPage(mainPage);

            navPage.BarBackgroundColor = Color.LightGray;
            navPage.BarTextColor = Color.Black;
           
            


            MainPage = navPage;
        }
    

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
