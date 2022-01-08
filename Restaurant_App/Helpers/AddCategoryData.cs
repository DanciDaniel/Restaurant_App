using Firebase.Database;
using Firebase.Database.Query;
using Restaurant_App.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Restaurant_App.Helpers
{
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        FirebaseClient client;
        public AddCategoryData()
        {
            client = new FirebaseClient("https://restaurantapp-ef4ea-default-rtdb.firebaseio.com/");
            Categories = new List<Category>()
            {
                new Category()
                {
                    CategoryID = 1,
                    CategoryName = "Pizza",
                    CategoryPoster = "Fel principal",
                    ImageUrl = "pizza.jpg"
                },
                new Category()
                {
                    CategoryID = 2,
                    CategoryName = "Paste",
                    CategoryPoster = "Fel principal",
                    ImageUrl = "pasta.jpg"
                },
                new Category()
                {
                    CategoryID = 3,
                    CategoryName = "Snitel cu cartofi pai",
                    CategoryPoster = "Fel principal",
                    ImageUrl = "snitel.jpg"
                },
                new Category()
                {
                    CategoryID = 4,
                    CategoryName = "Cartofi piure cu pulpe de pui",
                    CategoryPoster = "Fel principal",
                    ImageUrl = "pulpe.jpg"
                },
                new Category()
                {
                    CategoryID = 5,
                    CategoryName = "Ciorba de burta",
                    CategoryPoster = "Ciorbe",
                    ImageUrl = "cburta.jpg"
                },
                new Category()
                {
                    CategoryID = 6,
                    CategoryName = "Ciorba taraneasca",
                    CategoryPoster = "Ciorbe",
                    ImageUrl = "ctararenasca.jpg"
                },
                new Category()
                {
                    CategoryID = 7,
                    CategoryName = "Suc",
                    CategoryPoster = "Bautura",
                    ImageUrl = "suc.jpg"
                },
                new Category()
                {

                    CategoryID = 8,
                    CategoryName = "Apa",
                    CategoryPoster = "Bautura",
                    ImageUrl = "apa.jpg"
                },
                new Category()
                {

                    CategoryID = 9,
                    CategoryName = "Bere",
                    CategoryPoster = "Alcool",
                    ImageUrl = "bere.jpg"
                }
            };
        }
        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach(var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                        {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        CategoryPoster = category.CategoryPoster,
                        ImageUrl = category.ImageUrl
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }

        }
    }
}
