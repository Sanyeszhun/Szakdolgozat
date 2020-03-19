using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Modell
{
    partial class Kuldes
    {
        private int sid;
        private int kid;
        private int heid;
        private int teid;
        private int did;
        private string kikuldes;
        private string visszaerkezes;


        public Kuldes(int sid, int kid, int heid, int teid, int did, string kikuldes, string visszaerkezes)
        {

            this.sid = sid;
            this.kid = kid;
            this.heid = heid;
            this.teid = teid;
            this.did = did;
            this.kikuldes = kikuldes;
            this.visszaerkezes = visszaerkezes;
        }

        public int getKikuldesId()
        {
            return sid;
        }
        public int getKamionId()
        {
            return kid;
        }
        public int getHelyId()
        {
            return heid;
        }
        public int getTermekId()
        {
            return teid;
        }
        public string getKikuldes()
        {
            return kikuldes;
        }
        public string getVisszaerkezes()
        {
            return visszaerkezes;
        }
       
    


}
}
