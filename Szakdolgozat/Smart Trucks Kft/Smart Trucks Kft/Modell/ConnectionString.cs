using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
     public class ConnectionString
    {
        public string getCreateString()
        {
            return "SERVER =\"localhost\";"
             + "DATABASE=\"test\";"
             + "UID=\"root\";"
             + "PASSWORD=\"\";"
             + "PORT=\"3306\";";
        }

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
