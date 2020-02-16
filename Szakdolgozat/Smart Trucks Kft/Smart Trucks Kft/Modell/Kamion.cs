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
        private int date; //datum jo formatum megadasa
        private string rendszam;
        private string motor;
        private string uzemanyag;
        private int suly;
        private string hajtas;

        public Kamion(int tid, int date, string rendszam, string motor, string uzemanyag, int suly, string hajtas)
        {
            this.tid = tid;
            this.date = date;
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
        public void setTid(int tid) 
        {
            this.tid = tid;
        
        }

        public void setDate(int date)
        {
            this.date = date;

        }

        public void setRend(string rendszam)
        {
            this.rendszam = rendszam;

        }

        public void setMotor(string motor) 
        {
            this.motor = motor;
        
        }

        public void setUzemanyag(string uzemanyag)
        {
            this.uzemanyag = uzemanyag;

        }

        public void setSuly(int suly)
        {
            this.suly = suly;

        }

        public void setHajtas(string hajtas)
        {
            this.hajtas =hajtas;

        }

        public int getId() 
        {
            return tid;
        
        }
        public int getDate() 
        {
            return date;
        
        }

        public string getRend()
        {
            return rendszam;

        }

        public string getMotor() 
        {

            return motor;
        
        }

        public string getUzemanyag() 
        {
            return uzemanyag;
        
        }

        public int getSuly()
        {
            return suly;

        
        }

        public string getHajtas()
        {
            return hajtas;
        
        }

        public void update(Kamion modified)
        {
            this.date = modified.getDate();
            this.rendszam = modified.getRend();
            this.motor = modified.getMotor();
            this.uzemanyag = modified.getUzemanyag();
            this.suly = modified.getSuly();
            this.hajtas = modified.getHajtas();
        }



    }
}
