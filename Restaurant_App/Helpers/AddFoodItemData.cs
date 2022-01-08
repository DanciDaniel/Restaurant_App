using Firebase.Database;
using Firebase.Database.Query;
using Restaurant_App.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Restaurant_App.Helpers
{
    public class AddFoodItemData
    {
        FirebaseClient client;
        public List<FoodItem> FoodItems { get; set; }
        public AddFoodItemData()
        {
            client = new FirebaseClient("https://restaurantapp-ef4ea-default-rtdb.firebaseio.com/");
            FoodItems = new List<FoodItem>()
            {
            new FoodItem
            {
                ProductID = 1,
                CategoryID = 1,
                ImageUrl = "pizza.jpg",
                Name = "Pizza Margherita",
                Description = "Pizza - Fel principal",
                Rating = "4.8",
                RatingDetail = "4200 raitings",
                HomeSelected = "CompleteHeart",
                Price = 20
            },
            new FoodItem
            {
                ProductID = 2,
                CategoryID = 2,
                ImageUrl = "pasta.jpg",
                Name = "Paste bolognese",
                Description = "Paste - Fel principal",
                Rating = "4.9",
                RatingDetail = "3789 raitings",
                HomeSelected = "CompleteHeart",
                Price = 18
            },
            new FoodItem
            {
                ProductID = 3,
                CategoryID = 3,
                ImageUrl = "snitel.jpg",
                Name = "Snitel cu cartofi pai",
                Description = "Snitel - Fel principal",
                Rating = "4.7",
                RatingDetail = "2351 raitings",
                HomeSelected = "EmptyteHeart",
                Price = 27
            },
            new FoodItem
            {
                ProductID = 4,
                CategoryID = 4,
                ImageUrl = "pulpe.jpg",
                Name = "Cartofi piure cu pule de pui",
                Description = "Pulpe - Fel principal",
                Rating = "5.0",
                RatingDetail = "5536 raitings",
                HomeSelected = "CompleteHeart",
                Price = 29
            },
            new FoodItem
            {
                ProductID = 5,
                CategoryID = 5,
                ImageUrl = "cburta.jpg",
                Name = "Ciorba de burta",
                Description = "Ciorba de burta - Ciorbe",
                Rating = "4.6",
                RatingDetail = "2745 raitings",
                HomeSelected = "CompleteHeart",
                Price = 17
            },
            new FoodItem
            {
                ProductID = 6,
                CategoryID = 6,
                ImageUrl = "ctaraneasca.jpg",
                Name = "Ciorba Taraneasca",
                Description = "Ciorba taraneasca - Ciorbe",
                Rating = "4.1",
                RatingDetail = "1752 raitings",
                HomeSelected = "EmptyHeart",
                Price = 17
            },
            new FoodItem
            {
                ProductID = 7,
                CategoryID = 7,
                ImageUrl = "suc.jpg",
                Name = "Sucuri naturale",
                Description = "Suc - Bautura",
                Rating = "5.0",
                RatingDetail = "5497 raitings",
                HomeSelected = "CompleteHeart",
                Price = 11
            },
            new FoodItem
            {
                ProductID = 8,
                CategoryID = 8,
                ImageUrl = "apa.jpg",
                Name = "Apa minerala",
                Description = "Apa - Bautura",
                Rating = "4.9",
                RatingDetail = "3900 raitings",
                HomeSelected = "EmptyHeart",
                Price = 7
            },
            new FoodItem
            {
                ProductID = 9,
                CategoryID = 9,
                ImageUrl = "bere.jpg",
                Name = "Bere Ursus",
                Description = "Bere - Alcool",
                Rating = "5.0",
                RatingDetail = "4152 raitings",
                HomeSelected = "CompleteHeart",
                Price = 12
            }
            };
        


        }
        public async Task AddFoodItemAsync()
        {
            try
            {
                foreach(var item in FoodItems)
                {
                    await client.Child("FoodItems").PostAsync(new FoodItem()
                    {
                        CategoryID = item.CategoryID,
                        ProductID = item.ProductID,
                        Description = item.Description,
                        HomeSelected = item.HomeSelected,
                        ImageUrl = item.ImageUrl,
                        Name = item.Name,
                        Price = item.Price,
                        Rating = item.Rating,
                        RatingDetail = item.RatingDetail
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
