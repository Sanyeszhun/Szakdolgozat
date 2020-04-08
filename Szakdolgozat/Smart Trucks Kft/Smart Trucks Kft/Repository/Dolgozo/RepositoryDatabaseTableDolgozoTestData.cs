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
                    "INSERT  INTO  `dolgozok` (`id`, `nev`, `telefonszam`, `email`, `jelszo`) VALUES " +
                            " (1, 'Teszt Elek', '+36205887205', 'teszt@gmail.com', 'Jelszo123!'), " +
                            " (2, 'Teszt Attila', '+36205887204', 'teszt2@gmail.com', 'Jelszo123!'), " +
                            " (3, 'Nyúl Péter', '+36205887203', 'valamik@gmail.com', 'Jelszo123!'), " +
                            " (4, 'Makkos Péter', '+36205887202', 'makker@gmail.com', 'Jelszo123!'); ";
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
