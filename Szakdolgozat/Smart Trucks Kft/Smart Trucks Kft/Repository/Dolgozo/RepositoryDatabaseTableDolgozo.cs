using MySql.Data.MySqlClient;
using Smart_Trucks_Kft.Modell;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Repository
{
    partial class RepositoryDatabaseTableDolgozo
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        /// <summary>
        /// Konstruktor - kezdőértékadások
        /// </summary>
        public RepositoryDatabaseTableDolgozo()
        {
            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();
        }


        /// <summary>
        /// Táblák létrehozása a dolgozó tesztadatoknak
        /// </summary>
        public void createTableDolgozo()
        {
        
            string queryUSE = "USE kamion;";
            string queryCreateTable=
                "Create TABLE `dolgozok` (" +
                "   id INT NOT NULL PRIMARY KEY AUTO_INCREMENT , " +
                  "   `nev` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +
                   "   `telefonszam` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +
                    "   `email` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +
                    "   `jelszo` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '') " +                     
                        " ENGINE = InnoDB;";
          

            MySqlConnection connection =
                new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand cmdUSE = new MySqlCommand(queryUSE, connection);
                cmdUSE.ExecuteNonQuery();
                MySqlCommand cmdCreateTable = new MySqlCommand(queryCreateTable, connection);
                cmdCreateTable.ExecuteNonQuery();
              

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
        /// Dolgozó Tábla törlése az adatbázisból
        /// </summary>
       
        public void deleteTableDolgozo()
        {
            string query =
                "USE kamionok; " +
                "DROP TABLE dolgozok;";

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
        public void deleteDataFromTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Dolgozo.getSQLCommandDeleteAllRecord();
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
