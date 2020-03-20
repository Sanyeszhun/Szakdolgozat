using Smart_Trucks_Kft.myExeception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{

    /// <summary>
    /// Kamion Osztály
    /// </summary>
   partial class Kamion
    {

        private int tid;
        private string date; //datum jo formatum megadasa
        private string rendszam;
        private string motor;
        private string uzemanyag;
        private string suly;
        private string hajtas;
        /// <summary>
        /// Konstruktorok es validálásuk;
        /// </summary>
        /// <param name="tid"></param>
        /// <param name="date"></param>
        /// <param name="rendszam"></param>
        /// <param name="motor"></param>
        /// <param name="uzemanyag"></param>
        /// <param name="suly"></param>
        /// <param name="hajtas"></param>
        public Kamion(int tid, string date, string rendszam, string motor, string uzemanyag, string suly, string hajtas)
        {
            this.tid = tid;
            this.date = date;
          ////Datumot hogy kell le kezelni hogy tegnapi vagy regebbi datumot nem lehesen de irni
            this.rendszam = rendszam;///rendszam lekezelése
            if (!isValidRendszam(rendszam))
                throw new ModelKamionNotValidRenExeption("A Rendszámnak 3 nagy betűt és 3 számot kell tartalmaznia!!!!");
            this.motor = motor;
            if (!isValidMotor(motor))
                throw new ModelKamionNotValidMotorExeption("A  A Motor Lóerőnek 3 számot kell tartalmaznia!!");

            this.uzemanyag = uzemanyag;
            if (!isValidUzemanyag(uzemanyag))
                throw new ModelKamionNotValidUzemanyagExeption("Az üzemanyag Dízel vagy Benzin lehet!!!");
            this.suly = suly;
            if (!isValidSuly(suly))
                throw new ModelKamionNotValidSulyExeption("A kamion Sulyat kgbna adja meg ami 4 számjegy!!!!");

            this.hajtas = hajtas;
            if (!isValidHajtas(hajtas))
                throw new ModelKamionNotValidHajtasExeption("A Kamion Négykerék meghajtsu lehet vagy hatkerék meghajtasu!");



        }
        /// <summary>
        /// A Suly validációja
        /// </summary>
        /// <param name="suly"></param>
        /// <returns>Vissza tér hibával ha suly nem 4 karakter ha a suly 4 karakter nem dob hibat</returns>
        private bool isValidSuly(string suly)
        {
            if (suly.Length !=4)
            {
                return false;


            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Uzemanyag validálása
        /// </summary>
        /// <param name="uzemanyag"></param>
        /// <returns>Hiibát dob ha szöveg amit a felhasznaló be írt nem egyezik Az uzemanyag típusával ha jól irta beigaz ágra fut és nem dob hibát</returns>
        private bool isValidUzemanyag(string uzemanyag)
        {
            if (uzemanyag == "Benzin" || uzemanyag == "Dízel")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Motor lóerejének validálása
        /// </summary>
        /// <param name="motor"></param>
        /// <returns>Hibét dob ha nem 3 karakter van meg adva es ha többet ad meg a felhasznaló ha jól adta meg akkor igaz ágra futt es nem dob hibát</returns>
        private bool isValidMotor(string motor)
        {
            if (motor.Length != 3)
            {
                return false;


            }
            else
            {
                return true;
            }

              
        }
           
          
            
        
        /// <summary>
        /// Rendszám validálása
        /// </summary>
        /// <param name="rendszam"></param>
        /// <returns>Hibát dob ha az első 3 karakter nem nagy betüvel kezdödik ha a felhasznaló jól irta be igaz ágra futt és nem dob hibát</returns>
        private bool isValidRendszam(string rendszam)
        {
            if (char.IsLetter(rendszam[0]) && char.IsUpper(rendszam.ElementAt(0)))
            {
                if (char.IsLetter(rendszam[1]) && char.IsUpper(rendszam.ElementAt(1)))
                {
                    if (char.IsLetter(rendszam[2]) && char.IsUpper(rendszam.ElementAt(2)))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else 
                {
                    return false;
                }
               

            }
            else
            { return false;
            }
        }
        /// <summary>
        /// Kamion Hajtásának validálása
        /// </summary>
        /// <param name="hajtas"></param>
        /// <returns>Hiibát dob ha szöveg amit a felhasznaló be írt nem egyezik A hajtás típusával ha jól irta be igaz ágra futf és nem dob hibát</returns>
        private bool isValidHajtas(string hajtas)
        {
            if (hajtas == "Negykerek" || hajtas=="Hatkerék")
            {
                return true;
            }
            else 
            {
                return false;
            } 
        }

        //Setterek létrehozása és beállítása

        public void setTid(int tid) 
        {
            this.tid = tid;
        
        }

        public void setDate(string date)
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

        public void setSuly(string suly)
        {
            this.suly = suly;

        }

        public void setHajtas(string hajtas)
        {
            this.hajtas =hajtas;

        }
        //Getterek létrehozása és beállítása
        public int getId() 
        {
            return tid;
        
        }
        public string getDate() 
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

        public string getSuly()
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
