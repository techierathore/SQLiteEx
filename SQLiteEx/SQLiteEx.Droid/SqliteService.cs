using System;
using Xamarin.Forms;
using SQLiteEx.Droid;
using System.IO;
using SQLite;

[assembly: Dependency(typeof(SqliteService))]
namespace SQLiteEx.Droid
{
    public class SqliteService : ISQLite
    {
        public SqliteService() { }

        #region ISQLite implementation

        SQLiteConnection ISQLite.GetConnection()
        {
            var sqliteFilename = "SQLiteEx.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            Console.WriteLine(path);
            if (!File.Exists(path)) File.Create(path);
            var conn = new SQLiteConnection(path);
            // Return the database connection 
            return conn;
        }

        #endregion


    }
}