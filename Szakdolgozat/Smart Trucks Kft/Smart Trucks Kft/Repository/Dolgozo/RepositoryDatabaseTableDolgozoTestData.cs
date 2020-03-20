using MySql.Data.MySqlClient;
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
        /// <summary>
        /// Teszt adatokkal tölti fel a Dolgozok Táblát
        /// </summary>
        public void fillDolgozoWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT INTO `dolgozok` (`id`, `nev`, `telefonszam`, `email`, `jelszo`) VALUES " +
                            " (1, 'Makkos Máté', '+36205887205', 'valamik@gmail.com', '1234'), " +
                            " (2, 'Patka Attila', '+36205887204', 'valami@gmail.com', '12456'), " +
                            " (3, 'Nyul Péter', '+36205887203', 'valam@gmail.com', '12341'), " +
                            " (4, 'Bán Norbert', '+36205887202', 'val@gmail.com', 'abc'); ";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Tesztadatok feltöltése sikertelen.");
            }
        }



    }
}
