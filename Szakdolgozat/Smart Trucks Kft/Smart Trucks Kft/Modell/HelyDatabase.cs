using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
    partial class Hely
    {
        /// <summary>
        /// listázza az összes sort az adatbázis táblából
        /// </summary>
        /// <returns></returns>
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM hely";
        }
        /// <summary>
        /// törli az összes sort az adatbáisból
        /// </summary>
        /// <returns></returns>
        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM hely";
        }

    }
}
