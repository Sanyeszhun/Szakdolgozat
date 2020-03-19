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
        public void fillKuldesWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT INTO `kuldes` (`sid`, `kid`, `heid`, `teid`, `did`, `Kikuldes`, `Viszaerkezes`) VALUES " +
                            " (1, 2, 1, 1, 1, '2020-02-27', '2020-02-28'), " +
                             "  (2, 3, 1, 1, 2, '2020-02-22', '2020-02-27'), " +
                              "  (3, 5, 1, 1, 3, '2020-02-20', '2020-02-25'),  " +
                            " (4, 1, 4, 1, 4, '2020-02-21', '2020-02-28'); ";
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
