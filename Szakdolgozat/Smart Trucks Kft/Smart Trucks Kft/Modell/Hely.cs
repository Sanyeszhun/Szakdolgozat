using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
    partial class Hely
    {
        private int hid;
        private string felvetelezohely;
        private string tavolsag;
        private string ido;
        private string lerakohely;
       

        public Hely(int hid, string felvetelezohely, string tavolsag, string ido, string lerakohely)
        {

            this.hid = hid;
            this.felvetelezohely = felvetelezohely;
            this.tavolsag = tavolsag;
            this.ido = ido;
            this.lerakohely = lerakohely;

        }

        public int getHelyId()
        {
            return hid;
        }
        public string getFelvetelezohely()
        {
            return felvetelezohely;
        }
        public string getTavolsag()
        {
            return tavolsag;
        }
        public string getIdo()
        {
            return ido;
        }

        public string GetLerakohely() 
        {

            return lerakohely;
        }
    


}
}
