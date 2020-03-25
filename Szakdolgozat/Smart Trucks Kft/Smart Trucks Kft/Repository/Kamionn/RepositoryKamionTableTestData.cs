using MySql.Data.MySqlClient;
using Smart_Trucks_Kft.Modell;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Smart_Trucks_Kft.Repository
{
    partial class RepositoryKamionDatabaseTable
    { /// <summary>
      /// Teszt adatokkal tölti fel a Kamion Táblát
      /// </summary>
        public void fillKamionWithTestDataFromSQLCommand()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                string query =
                    "INSERT INTO `kamionok` (`tid`, `Muszakierv`, `Rendszam`, `Motor`, `Uzemanyag`, `Suly`, `Hajtas`) VALUES " +
                            " (1, '2020-02-27', 'AAA-123', '570', 'Dízel', '7450', 'Negykerek'), " +
                            " (2, '2020-03-27', 'AAB-123', '770', 'Dízel', '8600', 'Negykerek'), " +
                            " (3, '2020-06-27', 'CAS-123', '200', 'Dízel', '6730', 'Negykerek'), " +
                            " (4, '2020-02-27', 'AGW-123', '300', 'Dízel', '8710', 'Negykerek'); ";
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
