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
    partial class RepositoryHelyDatabaseTable

    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        public RepositoryHelyDatabaseTable()
        {

            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();

        }
        /// <summary>
        /// Táblák létrehozása a Helyek tesztadatoknak
        /// </summary>
        public void createTableHelyek()
        {
            string queryUSE = "USE kamion;";
            string queryCreateTable =
                "Create TABLE `hely` (" +
                "   `hid` int(60) NOT NULL DEFAULT '0', " +
                   "   `Felvetelezohely` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +
                   "   `Tavolsag` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +
                      "   `Ido` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +
                       "   `Lerakohely` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '') " +
                        " ENGINE = InnoDB;";
            string queryPrimaryKey =
                "ALTER TABLE `hely`  ADD PRIMARY KEY(`hid`); ";

           
          

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
        /// Helyek Tábla törlése az adatbázisból
        /// </summary>
        public void deleteTableHely()
        {
            string query =
                "USE kamion; " +
                "DROP TABLE hely;";

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

        public void deleteDataFromHelyTable()
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
