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
    partial class RepositoryKuldesDatabaseTable

    {
        private readonly string connectionStringCreate;
        private readonly string connectionString;

        public RepositoryKuldesDatabaseTable()
        {

            ConnectionString cs = new ConnectionString();
            connectionStringCreate = cs.getCreateString();
            connectionString = cs.getConnectionString();

        }
        /// <summary>
        /// Táblák létrehozása a kuldés tesztadatoknak
        /// </summary>
        public void createTableKuldes()
        {
            string queryUSE = "USE kamion;";
            string queryCreateTable =
                "Create TABLE IF NOT EXISTS `kuldes` (" +
                "   `sid` int(60) NOT NULL, " +
                  "   `kid` int(60) NOT NULL, " +
                    "   `heid` int(60) NOT NULL, " +
                      "   `teid` int(60) NOT NULL, " +
                        "   `did` int(60) NOT NULL, " +
                   "   `Kikuldes` varchar(60) COLLATE utf8_hungarian_ci NOT NULL, " +
                       "   `Viszaerkezes` varchar(60) COLLATE utf8_hungarian_ci NOT NULL) " +
                        " ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci;";
            string queryPrimaryKey =
                "ALTER TABLE `kuldes`  ADD PRIMARY KEY(`sid`); ";


            string queryKeys = "ALTER TABLE `kuldes`" +
                 "ADD CONSTRAINT `kuldes_ibfk_1` FOREIGN KEY(`kid`) REFERENCES `kamionok` (`tid`), " +
                 "ADD CONSTRAINT `kuldes_ibfk_2` FOREIGN KEY(`heid`) REFERENCES `hely` (`hid`), " +
                  "ADD CONSTRAINT `kuldes_ibfk_3` FOREIGN KEY(`teid`) REFERENCES `termekek` (`teid`), " +
                 "ADD CONSTRAINT `kuldes_ibfk_4` FOREIGN KEY(`did`) REFERENCES `dolgozok` (`id`); "; 
                 //"ADD CONSTRAINT `kuldes_ibfk_3` FOREIGN KEY(`teid`) REFERENCES `termekek` (`teid`), " +
                 //"ADD CONSTRAINT `kuldes_ibfk_4` FOREIGN KEY(`did`) REFERENCES `dolgozok` (`id`); ";

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
                MySqlCommand cmdQueryKeys = new MySqlCommand(queryKeys, connection);
                cmdQueryKeys.ExecuteNonQuery();
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
        /// Kuldes Tábla törlése az adatbázisból
        /// </summary>
        public void deleteTableKuldes()
        {
            string query =
                "USE kamion; " +
                "DROP TABLE kuldes;";

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
                string query = Kuldes.getSQLCommandDeleteAllRecord();
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
