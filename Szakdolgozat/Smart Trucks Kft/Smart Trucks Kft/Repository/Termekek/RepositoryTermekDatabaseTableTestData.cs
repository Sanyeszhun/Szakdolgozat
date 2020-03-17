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
    partial class RepositoryTermekDatabaseTable

    {
        public void fillTermekWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT INTO `termekek` (`teid`, `Mennyiseg`, `Termeksuly`, `TermekNev`) VALUES " +
                            " (1, '200', '400', 'Chips'), " +
                             " (2, '200', '600', 'Zsebkendo'), " +
                              " (3, '20', '100', 'Konzerv'), " +
                            " (4, '200', '800', 'Fa'); ";
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
