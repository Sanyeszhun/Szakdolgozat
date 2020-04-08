using Smart_Trucks_Kft.myExeception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{

    /// <summary>
    /// Dolgozo osztaly
    /// </summary>
   partial class Dolgozo
    {

      
        private int id;
        private string nev;
        private string telefonszam;
        private string email;
        private string jelszo;


        /// <summary>
        /// Konstruktorok és validálásuk
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nev"></param>
        /// <param name="telefonszam"></param>
        /// <param name="email"></param>
        /// <param name="jelszo"></param>
        public Dolgozo(int id, string nev, string telefonszam, string email, string jelszo)
        {
            this.id = id;
            this.nev = nev;
            if (!isValidName(nev))
                throw new ModelDolgozoNotValidNevExeption("A dolgozo neve nem megfelelő!");
            this.telefonszam = telefonszam;
            if (!isValidTel(telefonszam))
            {
                throw new ModelDolgozoNotValidNTelExeption("A telefonszám nem megfelelő (pl: +36705462345) !");
            }
            this.email = email;
          
            if (!isValidEmail(email))
            {
                throw new ModelDolgozoNotValidEmailExeption("Az email nem megfelelő (pl: vasarlo@emailem.hu)!");
            }

            this.jelszo = jelszo;
            if (!isValidJelszo(jelszo))
            {
                throw new ModelDolgozoNotValidjelszoExeption("Az email nem megfelelő (pl: vasarlo@emailem.hu)!");
            }

        }

        private bool isValidJelszo(string email)
        {
            var regjelsz = new Regex(@"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@#!%*?&])[A-Za-z\d$@$!%*?&]{8,32}");
            return regjelsz.IsMatch(jelszo);
        }


        /// <summary>
        /// Azemail cím Validációja
        /// </summary>
        /// <param name="email"></param>
        /// <returns>MEgfelelő eredményel tér vissza az email címben rossz esetben hibát dob</returns>
        private bool isValidEmail(string email)
        {
     
            {
                if (string.IsNullOrEmpty(email))
                    return false;
                else
                {
                    var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                    return regex.IsMatch(email) && !email.EndsWith(".");
                }
            }
           
        }

       


        /// <summary>
        /// A Dolgozok adatok firsitése történik itt
        /// </summary>
        /// <param name="modified"></param>
        public void update(Dolgozo modified)
        {
            this.nev = modified.getNev();
            this.telefonszam= modified.getTelefonszam();
            this.email = modified.getEmail();
            this.jelszo = modified.getJelszo();
        }
        
        
        
        /// <summary>
        /// A telefonszám Validációja
        /// </summary>
        /// <param name="telefonszam"></param>
        /// <returns>Vissza ter jo ertekel ha a felhasznalo helyesen adta meg rossz esetben hibat dob</returns>

       
        public bool isValidTel(string telefonszam)
        {
            if (telefonszam.Length != 12)
            {
                return false;
            }
            else
            {
                if (telefonszam[0] == '+')
                {
                    if (telefonszam[1] == '3')
                    {
                        if (telefonszam[2] == '6')
                        {
                            if (char.IsDigit(telefonszam[3]))
                            {
                                if (char.IsDigit(telefonszam[4]))
                                {
                                    if (char.IsDigit(telefonszam[5]))
                                    {
                                        if (char.IsDigit(telefonszam[6]))
                                        {
                                            if (char.IsDigit(telefonszam[7]))
                                            {
                                                if (char.IsDigit(telefonszam[8]))
                                                {
                                                    if (char.IsDigit(telefonszam[9]))
                                                    {
                                                        if (char.IsDigit(telefonszam[10]))
                                                        {
                                                            if (char.IsDigit(telefonszam[11]))
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
        /// <summary>
        /// Név validációja
        /// </summary>
        /// <param name="nev"></param>
        /// <returns>Hibát dob ha nem jol irta be a nevet vagy kis betüvel kezdte,jo esetben vissza tér hiba nélkül </returns>
        private bool isValidName(string nev)
        {
            if (nev == string.Empty)
                return false;
            if (!char.IsUpper(nev.ElementAt(0)))
                return false;
            for (int i = 1; i < nev.Length; i = i + 1)
                if (
                    !char.IsLetter(nev.ElementAt(i))
                        &&
                    (!char.IsWhiteSpace(nev.ElementAt(i)))

                    )
                    return false;
            return true;
        }
        //Setterek létrehozása és beállítása
        public void setID(int id)
        {
            this.id = id;
        }
        public void setNev(string nev)
        {
            this.nev = nev;
        }
        public void setTelefonszam(string telefonszam)
        {
            this.telefonszam = telefonszam;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setJelszo(string jelszo)
        {
            this.jelszo = jelszo;
        }

        //Getterek létrehozása és beállítása

        public int getId()
        {
            return id;
        }
        public string getNev()
        {
            return nev;
        }
        public string getTelefonszam()
        {
            return telefonszam;
        }
        public string getEmail()
        {
            return email;
        }
        public string getJelszo()
        {
            return jelszo;
        }
    }

}
