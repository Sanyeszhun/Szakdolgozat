using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
   partial class Kamion
    {
        /// <summary>
        /// Adatbázisba való adat beszúrás
        /// </summary>
        /// <returns></returns>
        public string getInsert() 
        {
            return
                "INSERT INTO `kamionok` (`tid`, `Muszakierv`, `Rendszam`, `Motor`, `Uzemanyag`, `Suly`, `Hajtas`) " +
                "VALUES ('" +
                tid +
                "', '" +
                getDate() +
                "', '" +
                getRend() +
                 "', '" +
                getMotor() +
                 "', '" +
                 getUzemanyag() +
                  "', '" +
                  getSuly() +
                   "', '" +
                   getHajtas() +
                "');";

        }
        /// <summary>
         /// Adatbázisba frissíti a mezőket
         /// </summary>
         /// <param name="id"></param>
         /// <returns></returns>
        public string getUpdate(int tid)
        {
            return
                "UPDATE `kamionok` SET `Muszakierv` = '" +
                getDate() +
                "',  `Rendszam` = '" +
                getRend() +
                 "',  `Motor` = '" +
                 getMotor() +
                  "',  `Uzemanyag` = '" +
                  getUzemanyag() +
                   "',  `Suly` = '" +
                   getSuly() +
                    "',  `Hajtas` = '" +
                    getHajtas() +
                "' WHERE `kamionok`.`tid` = " +
                tid;
        }

        /// <summary>
        /// törli az összes sort az adatbáisból
        /// </summary>
        /// <returns></returns>
        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM kamionok";
        }
        /// <summary>
        /// listázza az összes sort az adatbázis táblából
        /// </summary>
        /// <returns></returns>
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM kamionok";
        }
    }
}
