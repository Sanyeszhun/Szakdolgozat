using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
    partial class Termek
    {
        private int teid;
        private string mennyiseg;
        private string termeksuly;
        private string termeknev;

        public Termek(int teid, string mennyiseg, string termeksuly, string termeknev) 
        {
            this.teid = teid;
            this.mennyiseg = mennyiseg;
            this.termeksuly = termeksuly;
            this.termeknev = termeknev;
        }

        public int getTermekId() 
        {
            return teid;
        }
        public string getTermekMennyiseg()
        {
            return mennyiseg;
        }
        public string getTermekSuly()
        {
            return termeksuly;
        }
        public string getTermekNev()
        {
            return termeknev;
        }
    }
}
