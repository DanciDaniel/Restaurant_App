using Restaurant_App.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Restaurant_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Shapes_Experimental", "Brush_Experimental" });


            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new LoginView());
            //MainPage = new NavigationPage(new SettingsPage());
             string uname = Preferences.Get("Username", String.Empty);
             if(String.IsNullOrEmpty(uname))
           {
              MainPage = new LoginView();
          }
         else
        {
         MainPage = new ProductsView();
     }



        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
