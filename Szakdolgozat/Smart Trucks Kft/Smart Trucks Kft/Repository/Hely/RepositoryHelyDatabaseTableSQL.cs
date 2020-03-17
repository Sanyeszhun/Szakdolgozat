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
        public List<Hely> getHelyekFromDatabaseTable()
        {
            List<Hely> helyek = new List<Hely>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Hely.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string felvetelezohely= dr["Felvetelezohely"].ToString();

                    string tavolsag = dr["Tavolsag"].ToString();
                    string ido = dr["Ido"].ToString();
                    string lerakohely = dr["lerakohely"].ToString();



                    bool goodResult = false;
                    int hid = -1;
                    goodResult = int.TryParse(dr["hid"].ToString(), out hid);
                    if (goodResult)
                    {



                        Hely h = new Hely(hid, felvetelezohely, tavolsag, ido, lerakohely);
                        helyek.Add(h);


                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("A helyszin adatok beolvasása az adatbázisból nem sikerült!");
            }
            return helyek;
        }


    }
}
