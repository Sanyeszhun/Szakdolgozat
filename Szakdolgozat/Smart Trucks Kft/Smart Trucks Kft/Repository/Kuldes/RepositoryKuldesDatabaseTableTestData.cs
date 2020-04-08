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

    { /// <summary>
      /// Teszt adatokkal tölti fel a Kuldes Táblát
      /// </summary>
        public void fillKuldesWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT INTO `kuldes` (`sid`, `kid`, `heid`, `teid`, `did`, `Kikuldes`, `Viszaerkezes`) VALUES " +
                            " (1, 1, 1, 1, 1, '2020-02-27', '2020-02-28'), " +
                            " (2, 1, 2, 1, 1, '2020-03-20', '2020-03-28'), " +
                            " (3, 1, 3, 2, 1, '2020-04-01', '2020-04-03'), " +
                            " (4, 2, 2, 4, 2, '2020-01-27', '2020-02-02'), " +
                            " (5, 2, 2, 2, 2, '2020-02-03', '2020-02-05'), " +
                            " (6, 2, 3, 2, 2, '2020-02-10', '2020-02-15'), " +
                            " (7, 2, 2, 1, 3, '2019-12-27', '2019-12-31'), " +
                              " (8, 3, 2, 2, 3, '2020-01-28', '2020-02-01'), " +
                             " (9, 3, 1, 4, 3, '2020-02-27', '2020-02-28'), " +
                             "  (10, 4, 3, 3, 4, '2020-02-22', '2020-02-27'), " +
                              "  (11, 4, 4, 2, 4, '2020-03-23', '2020-03-25'),  " +
                            " (12, 4, 4, 1, 4, '2020-04-10', '2020-04-12'); ";
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
