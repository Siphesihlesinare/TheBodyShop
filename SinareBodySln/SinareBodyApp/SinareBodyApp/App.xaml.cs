using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SinareBodyApp
{
    public partial class App : Application
    {


        public App()
        {
            InitializeComponent();
            var mainPage = new MainPage();
            var navPage = new NavigationPage(mainPage);

            navPage.BarBackgroundColor = Color.White;
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
