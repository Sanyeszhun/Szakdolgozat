using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
    partial class Dolgozo
    {
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

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM dolgozok";
        }

        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM dolgozok";
        }
    }
}


