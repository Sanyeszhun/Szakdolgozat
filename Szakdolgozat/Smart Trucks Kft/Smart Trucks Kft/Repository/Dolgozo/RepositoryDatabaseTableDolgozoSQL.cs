using MySql.Data.MySqlClient;
using Smart_Trucks_Kft.Modell;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Repository
{
   partial class RepositoryDatabaseTableDolgozo
    {/// <summary>
    /// Ezt nem tudom meg kell kerdezni!!
    /// </summary>
    /// <returns></returns>
        public List<Dolgozo> getDolgozoFromDatabaseTable()
        {
            List<Dolgozo> dologzok = new List<Dolgozo>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Dolgozo.getSQLCommandGetAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string dolgozoname = dr["nev"].ToString();
                    string dolgozotelefon = dr["telefonszam"].ToString();
                    string dolgozoemail = dr["email"].ToString();
                    string dolgozojelszo = dr["jelszo"].ToString();


                    bool goodResult = false;
                    int id = -1;
                    goodResult = int.TryParse(dr["id"].ToString(), out id);
                    if (goodResult)
                    {
                       
                       
                            Dolgozo d = new Dolgozo(id,dolgozoname,dolgozotelefon,dolgozoemail,dolgozojelszo);
                           dologzok.Add(d);
                       
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Pizzaadatok beolvasása az adatbázisból nem sikerült!");
            }
            return dologzok;
        }

        public void deleteDolgozoFromDatabase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM dolgozok WHERE id=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(id + " idéjű dolgozo törlése nem sikerült.");
                throw new RepositoryException("Sikertelen törlés az adatbázisból.");
            }
        }

        public void updateDolgozoInDatabase(int id, Dolgozo modified)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = modified.getUpdate(id);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(id + " idéjű dolgozo módosítása nem sikerült.");
                throw new RepositoryException("Sikertelen módosítás az adatbázisból.");
            }
        }

        public void insertDolgozoToDatabase(Dolgozo ujDolgozo)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ujDolgozo.getInsert();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(ujDolgozo + " dolgozo beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisból.");
            }
        }

    }
}
