using System;
using SQLite;
using Restaurant_App.Model;
using System.IO;
using Xamarin.Forms;

[assembly:Dependency(typeof(Restaurant_App.Droid.SQLite_Android))]
namespace Restaurant_App.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
        
    }
}