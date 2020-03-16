using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
   partial class Kamion
    {

        private int tid;
        private string date; //datum jo formatum megadasa
        private string rendszam;
        private string motor;
        private string uzemanyag;
        private string suly;
        private string hajtas;

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
                throw new ModelKamionNotValidMotorExeption("A Rendszámnak 3 nagy betűt és 3 számot kell tartalmaznia!!!!");

            this.uzemanyag = uzemanyag;
            this.suly = suly;

            this.hajtas = hajtas;
            if (!isValidHajtas(hajtas))
                throw new ModelKamionNotValidHajtasExeption("A Kamion Négykerék meghajtsu lehet vagy hatkerék meghajtasu!");



        }

        private bool isValidMotor(string motor)
        {
            if (motor.Length != 3)
            {
                return false;


            }
            else
            {


                if (char.IsDigit(motor[1]))
                {
                    if (char.IsDigit(motor[2]))
                    {
                        if (char.IsDigit(motor[3]))
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
                {
                    return false;
                }
            }
        }
           
          
            
        

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
