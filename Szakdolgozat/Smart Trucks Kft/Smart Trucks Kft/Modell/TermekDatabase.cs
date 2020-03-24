using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
    partial class Termek
    {
        public static string getSQLCommandGetAllRecord()
        {
            return "SELECT * FROM termekek";
        }

        public static string getSQLCommandDeleteAllRecord()
        {
            return "DELETE FROM termekek";
        }
    }
}
