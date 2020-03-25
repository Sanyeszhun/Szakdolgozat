using Smart_Trucks_Kft.Modell;
using Smart_Trucks_Kft.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Trucks_Kft.Repository
{/// <summary>
/// A kamion lista deklarálása
/// </summary>
    partial class Repository1
    {
        List<Kamion> kamionok;

        /// <summary>
        /// A kamion lista visszadása
        /// </summary>
        /// <returns></returns>
        public List<Kamion> GetKamions()
        {
            return kamionok;
        
        
        }
       
        /// <summary>
        /// Kamion beállítása
        /// </summary>
        /// <param name="kamionok"></param>
        public void setKamionok(List<Kamion> kamionok) 
        {

            this.kamionok = kamionok;
        }


        // <summary>
        /// Listából készítünk egy táblát
        /// </summary>
        /// <returns>A legyártott táblát kapjuk vissza.</returns>
        public DataTable getKamionDataTableFromList() 
        {
            DataTable kamionDT = new DataTable();
            kamionDT.Columns.Add("Azonosito", typeof(int));
            kamionDT.Columns.Add("MuszakiErv", typeof(string));
            kamionDT.Columns.Add("Rendszam", typeof(string));
            kamionDT.Columns.Add("Motor", typeof(string));
            kamionDT.Columns.Add("Uzemanyag", typeof(string));
            kamionDT.Columns.Add("Suly", typeof(string));
            kamionDT.Columns.Add("Hajtas", typeof(string));
            foreach (Kamion k in kamionok) 
            {

                kamionDT.Rows.Add(k.getId(), k.getDate(), k.getRend(), k.getMotor(), k.getUzemanyag(), k.getSuly(), k.getHajtas());
            
            }
            return kamionDT;
        }


        /// <summary>
        /// A listát feltöltjük a téblában lévő adatokkal
        /// </summary>
        /// <param name="kamiondt">Maga a táblázat</param>
        private void fillKamionListFromDataTable(DataTable kamiondt) 
        {
            foreach (DataRow row in kamiondt.Rows) 
            {
                int tid = Convert.ToInt32(row[0]);
                string date = row[1].ToString(); ;///datumm ido hogy kell???
                string rendszam = row[2].ToString();
                string motor = row[3].ToString();
                string uzemanyag= row[4].ToString();
                string suly = row[5].ToString();
                string hajtas = row[6].ToString();
                Kamion k = new Kamion(tid, date, rendszam, motor, uzemanyag, suly, hajtas);
                kamionok.Add(k);

            }


            

        }


        public List<int> getKamionID()
        {
            List<int> kamionid = new List<int>();
            foreach (Kamion kamion in kamionok)
            {
                kamionid.Add(kamion.getId());
            }
            return kamionid;
        }


        /// <summary>
        /// Frissiti a lista adott id-jű elemét
        /// </summary>
        /// <param name="tid"> A dkamionak adott azzonosító</param>
        /// <param name="modified">A modosítás ami máshol van deklarálva</param>
        public void updateKamionInList(int tid, Kamion modified)
        {
            Kamion k = kamionok.Find(x => x.getId() == tid);
            if (k != null)
            {
                k.update(modified);
            }
            else
            {
                throw new RepositoryExceptionCantModified("A Kamion módosítása nem sikerült");
            }
        }

        /// <summary>
        /// Uj Kamion hozzá adása
        /// </summary>
        /// <param name="ujKamion">Az uj Kamion</param>
        public void addKamionToList(Kamion ujkamion) 
        {

            try
            {
                kamionok.Add(ujkamion);
            }
            catch (Exception ex) 
            {
                throw new RepositoryExceptionCantAdd("A kamion hozzá adása nem sikerült");
            }
                
        }
        /// <summary>
        /// Visszaadja az azzonosítót
        /// </summary>
        /// <param name="tid">Azzonosító értéke</param>
        /// <returns></returns>
        public Kamion GetKamion(int tid) 
        {
            return kamionok.Find(x => x.getId() == tid);
        }

        /// <summary>
        ///  Új azonosított hozz létre és  mindig 1-el növeli az utolsó azonosító számát
        /// </summary>
        /// <returns>A megnövelt azzonósítóval tér vissza</returns>

        public int getNextKamionId() 
        {
            if (kamionok.Count == 0)
            {
                return 1;

            }
            else 
            {
                return kamionok.Max(x => x.getId()) + 1;
            }
        
        }

        /// <summary>
        /// Kamion Törlése a listából id alapján ha nem jó hibát dob
        /// </summary>
        /// <param name="tid">A kamion azzonosítója</param>
        public void deleteKamionFromList(int tid)
        {
            Kamion k = kamionok.Find(x => x.getId() == tid);
            if (k != null)
                kamionok.Remove(k);
            else
                throw new RepositoryExceptionCantDelete("A dolgozot nem lehetett törölni.");
        }
    }
}
