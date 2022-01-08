using Restaurant_App.Model;

using Xamarin.Forms;
using System;
using System.Collections.Generic;
using Restaurant_App.ViewModels;

namespace Restaurant_App.Views
{
     public partial class ProductDetailsView : ContentPage
    {
        ProductDetailsViewModel pvm;
        public ProductDetailsView(FoodItem foodItem)
        {
            InitializeComponent();
            pvm = new ProductDetailsViewModel(foodItem);
            this.BindingContext = pvm;

        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();

        }
    }
}