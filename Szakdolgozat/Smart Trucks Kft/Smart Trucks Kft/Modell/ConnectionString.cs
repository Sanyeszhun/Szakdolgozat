using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{

    /// <summary>
    /// ConnectionString osztály a csatlakozáshoz
    /// </summary>
    public class ConnectionString
    {


        /// <summary>
        /// Connection Stringet csinál az adatbázis létrehozásához
        /// </summary>
        /// <returns>Connection string ami a test adatbázishoz csatlakozik</returns>
        public string getCreateString()
        {
            return "SERVER =\"localhost\";"
             + "DATABASE=\"test\";"
             + "UID=\"root\";"
             + "PASSWORD=\"\";"
             + "PORT=\"3306\";";
        }
        /// <summary>
        /// Connection string  táblák és a teszt adatok feltöltéséhez
        /// </summary>
        /// <returns>A Kamion adatbázishoz csatlakozik</returns>
        public string getConnectionString()
        {
            return
                 "SERVER=\"localhost\";"
                + "DATABASE=\"kamion\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";

        }
    }
}
