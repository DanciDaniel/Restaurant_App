using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_App.Model
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
