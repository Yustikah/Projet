using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Projet.Database
{
    internal class LoginDatabase
    {
        readonly SQLiteConnection database;

        public LoginDatabase(string dbpath)
        {
            database = new SQLiteConnection(dbpath);
        }
    }
}
