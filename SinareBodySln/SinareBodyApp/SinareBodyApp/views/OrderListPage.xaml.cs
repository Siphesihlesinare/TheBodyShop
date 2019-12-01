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
    public partial class OrderListPage : ContentPage
    {
        public OrderListPage()
        {
            InitializeComponent();
        }

        private async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}