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
       
        public void fillHelyWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT INTO `hely` (`hid`, `Felvetelezohely`, `Tavolsag`, `Ido`, `Lerakohely`) VALUES " +
                            " (1, 'Makó', '300', '4:00:00', 'Szeged'), " +
                           " (2, 'Makó', '300', '4:00:00', 'Szeged'), " +
                            " (3, 'Makó', '300', '4:00:00', 'Szeged'), " +
                            " (4, 'Makó', '300', '4:00:00', 'Szeged'); ";
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
