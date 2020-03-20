using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
    partial class Dolgozo
    {
        /// <summary>
        /// Adatbázisba való adat beszúrás
        /// </summary>
        /// <returns></returns>
        public string getInsert()
        {
            return
                "INSERT INTO `dolgozok` (`id`, `nev`, `telefonszam`, `email`, `jelszo`) " +
                "VALUES ('" +
                id +
                "', '" +
                getNev() +
                "', '" +
                 getTelefonszam() +
                "', '" +
                 getEmail() +
                "', '" +               
                getJelszo() +
                "');";
        }
        /// <summary>
        /// Adatbázisba frissíti a mezőket
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string getUpdate(int id)
        {
            return
                "UPDATE `dolgozok` SET `nev` = '" +
                getNev() +
                "', `telefonszam` = '" +
                getTelefonszam() +
                  "', `email` = '" +
                getEmail() +
                  "', `jelszo` = '" +
                getJelszo() +              
                "' WHERE `dolgozok`.`id` = " +
                id;
           
        }
        /// <summary>
        /// törli az összes sort az adatbáisból
        /// </summary>
        /// <returns></returns>
        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM dolgozok";
        }
        /// <summary>
        /// listázza az összes sort az adatbázis táblából
        /// </summary>
        /// <returns></returns>
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM dolgozok";
        }
    }
}


