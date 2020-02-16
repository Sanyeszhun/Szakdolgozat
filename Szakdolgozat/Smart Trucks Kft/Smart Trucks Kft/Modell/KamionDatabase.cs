using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
   partial class Kamion
    {

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
        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM kamionok";
        }

        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM kamionok";
        }
    }
}
