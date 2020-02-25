using Smart_Trucks_Kft.Modell;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Smart_Trucks_Kft.Repository.Kamionn
{
    partial class RepositoryKamionDatabaseTable
    {
        public void fillKamionWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT INTO `kamionok` (`tid`, `Muszakierv`, `Rendszam`, `Motor`, `Uzemanyag`, `Suly`, `Hajtas`) VALUES " +
                            " (1, '2020-02-27', 'AAA-123', 'Benzin', 'Dizel', 100, 'Negykerek'), " +
                            " (2, '2020-03-27', 'AAB-123', 'Benzin', 'Dizel', 120, 'Negykerek'), " +
                            " (3, '2020-06-27', 'CAS-123', 'Benzin', 'Dizel', 400, 'Negykerek'), " +
                            " (4, '2020-02-27', 'AGW-123', 'Benzin', 'Dizel', 410, 'Negykerek'); ";
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
