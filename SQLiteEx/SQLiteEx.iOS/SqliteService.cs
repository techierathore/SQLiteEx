﻿using SQLite;
using SQLiteEx.iOS;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqliteService))]
namespace SQLiteEx.iOS
{
    public class SqliteService : ISQLite
    {
        public SqliteService()
        {
        }
        #region ISQLite implementation
        SQLiteConnection ISQLite.GetConnection()
        {
            var sqliteFilename = "SQLiteEx.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);

            // This is where we copy in the prepopulated database
            Console.WriteLine(path);
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            var conn = new SQLiteConnection(path);
            // Return the database connection 
            return conn;
        }
        #endregion
    }
}
