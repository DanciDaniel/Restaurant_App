using Restaurant_App.Model;
using Restaurant_App.ViewModels;
using System;
using System.Linq;

using Xamarin.Forms;

namespace Restaurant_App.Views
{
     public partial class CategoryView : ContentPage
    {
        CategoryViewModel cvm;
       public  CategoryView(Category category)
        {
            InitializeComponent();
            cvm = new CategoryViewModel(category);
            this.BindingContext = cvm;
        }

         async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();


        }
        async void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as FoodItem;
            if (selectedProduct == null)
                return;
            await Navigation.PushModalAsync(new ProductDetailsView(selectedProduct));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}