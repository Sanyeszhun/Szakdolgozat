using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart_Trucks_Kft.Repository;
using Smart_Trucks_Kft.Modell;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Smart_Trucks_Kft.Repository.Kamionn
{
    partial class RepositoryKamionDatabaseTable
    {
        public List<Kamion> getKamionFromDatabaseTable() 
        {
            List<Kamion> kamionok = new List<Kamion>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Kamion.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bool goodResult = false;
                    string name = dr["fnev"].ToString();
                    int id = -1;
                    goodResult = int.TryParse(dr["fazon"].ToString(), out id);
                    if (goodResult)
                    {
                        string tel = dr["ftel"].ToString();
                        if (goodResult)
                        {
                            Futar f = new Futar(id, name, tel);
                            futarok.Add(f);
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Futar adatok beolvasása az adatbázisból nem sikerült!");
            }
            return futarok;






        }
            
    }
}
