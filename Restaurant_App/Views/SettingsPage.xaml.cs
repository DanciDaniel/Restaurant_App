using System;
using System.Collections.Generic;
using Restaurant_App.Helpers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
        async void ButtonCategories_Clicked(System.Object sender, System.EventArgs e)
        {
            var acd = new AddCategoryData();
            await acd.AddCategoriesAsync();
        }
        async void ButtonProducts_Clicked(System.Object sender, System.EventArgs e)
        {
            var afd = new AddFoodItemData();
            await afd.AddFoodItemAsync();
        }
        async void ButtonCart_Clicked(System.Object sender, System.EventArgs e)
        {
            var cct = new CreateCartTable();
            if (cct.CreateTable())
                DisplayAlert("Success", "Cart Table Created", "Ok");
            else
                DisplayAlert("Error", "Error while creating the table", "Ok");



        }
    }
}