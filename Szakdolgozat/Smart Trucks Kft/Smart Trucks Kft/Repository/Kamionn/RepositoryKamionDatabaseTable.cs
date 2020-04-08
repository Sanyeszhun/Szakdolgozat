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
    partial class RepositoryKamionDatabaseTable
    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;


        public RepositoryKamionDatabaseTable() 
        {

            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();


        }


        /// <summary>
        /// Téblák létrehozása a Kamion tesztadatoknak
        /// </summary>
        public void createTableKamion()
        {

            string queryUSE = "USE kamion;";
            string queryCreateTable =
                "Create TABLE `kamionok` (" +
                "   `tid` int(60) NOT NULL DEFAULT '0', " +
                 "`Muszakierv` date NOT NULL DEFAULT '2017-01-01'," +
                  "   `Rendszam` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +
                   "   `Motor` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +
                    "   `Uzemanyag` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '', " +
                     "   `Suly` int(60) NOT NULL DEFAULT '0', " +
                       "   `Hajtas` varchar(60) COLLATE latin2_hungarian_ci NOT NULL DEFAULT '') " +
                        " ENGINE = InnoDB;";
            string queryPrimaryKey =
                "ALTER TABLE `kamionok`  ADD PRIMARY KEY(`tid`); ";

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
        /// Kamionok tábla törlése kamion adatbázisból
        /// </summary>

        public void deleteTableKamion()
        {
            string query =
                "USE kamion; " +
                "DROP TABLE kamionok;";

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
        public void deleteDataFromKamionTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Kamion.getSQLCommandDeleteAllRecord();
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
