using MySql.Data.MySqlClient;
using Smart_Trucks_Kft.Modell;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Smart_Trucks_Kft.Repository
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
                    //string muszakierv = dr["Muszakierv"].ToString();
                    string rendszam = dr["Rendszam"].ToString();
                    string motor = dr["Motor"].ToString();
                    string uzemanyag = dr["Uzemanyag"].ToString();
                    string hajtas= dr["Hajtas"].ToString();


                    bool goodResult = false;
                    int tid = -1;
                    goodResult = int.TryParse(dr["tid"].ToString(), out tid);
                    if (goodResult)
                    {
                        int muszakierv = -1;
                        goodResult = int.TryParse(dr["Muszakierv"].ToString(), out muszakierv);
                        if (goodResult)
                        {

                            int suly = -1;
                            goodResult = int.TryParse(dr["suly"].ToString(), out suly);
                            if (goodResult)
                            {

                                Kamion k = new Kamion(tid, muszakierv, rendszam, motor, uzemanyag, suly, hajtas);
                                kamionok.Add(k);

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
                throw new RepositoryException("KamionAdatok beolvasása az adatbázisból nem sikerült!");
            }
            return kamionok;
        }
        public void deleteKamionFromDatabase(int tid)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM kamionok WHERE tid=" + tid;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(tid + " idéjű kamion törlése nem sikerült.");
                throw new RepositoryException("Sikertelen törlés az adatbázisból.");
            }
        }

        public void updateInDatabase(int tid, Kamion modified)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = modified.getUpdate(tid);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(tid + " idéjű kamion módosítása nem sikerült.");
                throw new RepositoryException("Sikertelen módosítás az adatbázisból.");
            }
        }

        public void insertKamionToDatabase(Kamion ujKamion)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ujKamion.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(ujKamion + " kamion beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisból.");
            }
        }

    }
}
