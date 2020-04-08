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
        /// <summary>
        /// Teszt adatokkal tölti fel a Hely Táblát
        /// </summary>
        public void fillHelyWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT  INTO  `hely` (`hid`, `Felvetelezohely`, `Tavolsag`, `Ido`, `Lerakohely`) VALUES " +
                            " (1, 'Makó', '330', '1:34:00', 'Budapest'), " +
                           " (2, 'Szeged', '367', '4:23:00', 'Debrecen'), " +
                            " (3, 'Budapest', '150', '1:30:00', 'Kecskemét'), " +
                            " (4, 'Kiszombor', '10', '0:15:00', 'Makó'); ";
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
