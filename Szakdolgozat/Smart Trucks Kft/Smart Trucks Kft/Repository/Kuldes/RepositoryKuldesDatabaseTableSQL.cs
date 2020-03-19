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
        public List<Kuldes> getKuldesFromDatabaseTable()
        {
            List<Kuldes> kuldesek = new List<Kuldes>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Kuldes.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string kikuldes = dr["Kikuldes"].ToString();
                    string visszaerkezes = dr["Viszaerkezes"].ToString();

                    bool goodResult = false;
                    int sid = -1;
                    goodResult = int.TryParse(dr["sid"].ToString(), out sid);
                    if (goodResult)
                    {
                        int kid = -1;
                        goodResult = int.TryParse(dr["kid"].ToString(), out kid);
                        if (goodResult)
                        {
                            int heid = -1;
                            goodResult = int.TryParse(dr["heid"].ToString(), out heid);
                            if (goodResult)
                            {
                                int teid = -1;
                                goodResult = int.TryParse(dr["teid"].ToString(), out teid);
                                if (goodResult)
                                {

                                    int did = -1;
                                    goodResult = int.TryParse(dr["did"].ToString(), out did);
                                    if (goodResult)
                                    {
                                        Kuldes ku = new Kuldes(sid, kid, heid, teid, did, kikuldes, visszaerkezes);
                                        kuldesek.Add(ku);
                                    }
                                }
                            }
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("kuldes beolvasása az adatbázisból nem sikerült!");
            }
            return kuldesek;
        }
    }
}
