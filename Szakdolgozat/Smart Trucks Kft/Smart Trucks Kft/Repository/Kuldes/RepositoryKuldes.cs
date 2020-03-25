using Smart_Trucks_Kft.Modell;
using Smart_Trucks_Kft.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Repository
{
    partial class Repository1
    {
        // Kuldesek Lista deklarálása
        List<Kuldes> kuldesek;

        //Kuldes visszadása a listának
        public List<Kuldes> getKuldesek() 
        {
            return  kuldesek;
        }

        /// <summary>
        /// Kuldes beállitása
        /// </summary>
        /// <param name="kuldesek"></param>
        public void setKuldesek(List<Kuldes> kuldesek)
        {
            this.kuldesek = kuldesek;
        }


        /// <summary>
        /// Listából készítünk egy táblát
        /// </summary>
        /// <returns>A legyártott táblát kapjuk vissza.</returns>

        public DataTable getKuldesDataTableFromList() 
        {
            DataTable kuldesDT = new DataTable();
            kuldesDT.Columns.Add("sid", typeof(int));
            kuldesDT.Columns.Add("kid", typeof(int));
            kuldesDT.Columns.Add("heid", typeof(int));
            kuldesDT.Columns.Add("teid", typeof(int));
            kuldesDT.Columns.Add("did", typeof(int));
            kuldesDT.Columns.Add("Kikuldes", typeof(string));
            kuldesDT.Columns.Add("Visszaerkezes", typeof(string));
            foreach (Kuldes h in kuldesek)
            {
                kuldesDT.Rows.Add(h.getKikuldesId(), h.getKamionId(), h.getHelyId(), h.getTermekId(),h.getDolgozoId(),  h.getKikuldes(),h.getVisszaerkezes());
            }
            return kuldesDT;

        
        }


        public List<Kuldes> getKudlesek(string Dolgozoneve)
        {
            int DolgozoId = dolgozok.Find(x => x.getNev() == Dolgozoneve).getId();
            return kuldesek.FindAll(x => x.getDolgozoId() == DolgozoId);
        }
    }
}
