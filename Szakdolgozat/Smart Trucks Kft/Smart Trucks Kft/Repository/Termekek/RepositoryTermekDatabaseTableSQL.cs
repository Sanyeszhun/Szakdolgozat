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
        public List<Termek> getTermekFromDatabaseTable()
        {
            List<Termek> termekek = new List<Termek>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Termek.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string mennyiseg = dr["Mennyiseg"].ToString();

                    string termeksuly = dr["Termeksuly"].ToString();
                    string termeknev = dr["TermekNev"].ToString();
                  
                   


                    bool goodResult = false;
                    int teid = -1;
                    goodResult = int.TryParse(dr["teid"].ToString(), out teid);
                    if (goodResult)
                    {



                        Termek t = new Termek(teid, mennyiseg, termeksuly, termeknev);
                       termekek.Add(t);


                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Termek adatok beolvasása az adatbázisból nem sikerült!");
            }
            return termekek;
        }

    }
}
