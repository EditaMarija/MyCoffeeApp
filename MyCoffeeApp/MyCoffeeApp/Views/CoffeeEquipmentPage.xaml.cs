using MyCoffeeApp.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        public CoffeeEquipmentPage()
        {
            InitializeComponent();

        }
        
        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var coffee = ((ListView)sender).SelectedItem as Coffee;
            if (coffee == null)
                return;
            await DisplayAlert("Coffee Selected", coffee.Name, "OK");

        }

        private void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }

    }
}