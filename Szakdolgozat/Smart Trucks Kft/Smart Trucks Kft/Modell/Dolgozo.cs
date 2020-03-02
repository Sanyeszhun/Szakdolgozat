using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
   partial class Dolgozo
    {
        private int id;
        private string nev;
        private string telefonszam;
        private string email;
        private string jelszo;

        public Dolgozo(int id, string nev, string telefonszam, string email, string jelszo)
        {
            this.id = id;
            this.nev = nev;
            if (!isValidName(nev))
                throw new ModelDolgozoNotValidNevExeption("A dolgozo neve nem megfelelő!");
            this.telefonszam = telefonszam;
            if (!isValidTel(telefonszam))
            {
                throw new ModelDolgozoNotValidNevExeption("A telefonszám nem megfelelő (pl: +36705462345) !");
            }
            this.email = email;
            this.jelszo = jelszo;
        }
       
        public void update(Dolgozo modified)
        {
            this.nev = modified.getNev();
            this.telefonszam= modified.getTelefonszam();
            this.email = modified.getEmail();
            this.jelszo = modified.getJelszo();
        }

       
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
