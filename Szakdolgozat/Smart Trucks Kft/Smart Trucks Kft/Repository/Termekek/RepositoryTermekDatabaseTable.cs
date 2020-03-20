using MySql.Data.MySqlClient;
using Smart_Trucks_Kft.Modell;
using Smart_Trucks_Kft.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Repository
{
    partial class RepositoryTermekDatabaseTable

    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        public RepositoryTermekDatabaseTable()
        {

            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();

        }
        /// <summary>
        /// Táblák létrehozása a dolgozó tesztadatoknak
        /// </summary>

        public void createTableTermekek()
        {
            string queryUSE = "USE kamion;";
            string queryCreateTable =
                "Create TABLE `termekek` (" +
                "   `teid` int(60) NOT NULL DEFAULT '0', " +
                   "   `Mennyiseg` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +
                   "   `Termeksuly` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +
                       "   `TermekNev` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '') " +
                        " ENGINE = InnoDB;";
            string queryPrimaryKey =
                "ALTER TABLE `termekek`  ADD PRIMARY KEY(`teid`); ";

            MySqlConnection connection =
               new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmdUSE = new MySqlCommand(queryUSE, connection);
                cmdUSE.ExecuteNonQuery();
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
                MySqlCommand cmdPrimaryKey = new MySqlCommand(queryPrimaryKey, connection);
                cmdPrimaryKey.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tábla lérehozása sikertelen.");
            }

        }
        /// <summary>
        /// Termék Tábla törlése az adatbázisból
        /// </summary>


        public void deleteTableTermek()
        {
            string query =
                "USE kamion; " +
                "DROP TABLE termekek;";

            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tábla törlése nem sikerült.");
            }
        }
        /// <summary>
        /// Teszt adatok törlése
        /// </summary>
        public void deleteDataFromTermekTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Termek.getSQLCommandDeleteAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tesztadatok törlése sikertelen.");
            }
        }
    }
    }
