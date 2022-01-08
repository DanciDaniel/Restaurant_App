using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Restaurant_App.Views
{
    
    public partial class CartView : ContentPage
    {
        public CartView()
        {
            InitializeComponent();
            LabelName.Text = "Welcome " + Preferences.Get("Username", "Guest") + ",";
        }
        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}