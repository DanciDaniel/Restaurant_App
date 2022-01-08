using Firebase.Database;
using Restaurant_App.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Firebase.Database.Query;

namespace Restaurant_App.Services
{
   public class CategoyDataService
    {
        FirebaseClient client;
        public CategoyDataService()
        {
            client = new FirebaseClient("https://restaurantapp-ef4ea-default-rtdb.firebaseio.com/");
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = (await client.Child("Categories")
                .OnceAsync<Category>())
                .Select(c => new Category
                {
                    CategoryID = c.Object.CategoryID,
                    CategoryName = c.Object.CategoryName,
                    CategoryPoster = c.Object.CategoryPoster,
                    ImageUrl = c.Object.ImageUrl
                }).ToList();
            return categories;
        }
    }
}
