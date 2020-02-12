using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
    class Kamion
    {

        private int tid;
        private int date;//datum jo formatum megadasa
        private string rendszam;
        private string motor;
        private string uzemanyag;
        private int suly;
        private string hajtas;

        public Kamion(int tid, int date, string rendszam, string motor, string uzemanyag, int suly, string hajtas)
        {
            this.tid = tid;
            //datum kell meg this.date

            if (!isValideRendszam(rendszam))
            {
                throw new ModelKamionNotValidRenExeception("Nem megfelelő a rendszam");

            }
            this.rendszam = rendszam;///rendszam lekezelése
            this.motor = motor;
            this.uzemanyag = uzemanyag;
            this.suly = suly;
            this.hajtas = hajtas;



        }


        


    }
}
