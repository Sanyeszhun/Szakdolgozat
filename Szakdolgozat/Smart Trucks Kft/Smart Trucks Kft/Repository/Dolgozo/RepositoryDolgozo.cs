using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Smart_Trucks_Kft.Modell;

namespace Smart_Trucks_Kft.Repository
{
    partial class Repository1
    { //Dolgozó lista deklarálása
        List<Dolgozo> dolgozok;


        //Dolgozó visszadása a listának
        public List<Dolgozo> GetDolgozok()
        {
            return dolgozok;
        }
      /// <summary>
      /// listáza a dologozó neveket
      /// </summary>
      /// <returns>visszatér a dolgozó nevekkel</returns>
        public List<string> getDolgozokNev()
        {
            List<string> dolgozoNevek = new List<string>();
            foreach (Dolgozo dolgozo in dolgozok)
            {
                dolgozoNevek.Add(dolgozo.getNev());
            }
            return dolgozoNevek;
        }
        /// <summary>
        /// Dolgozó beállitása
        /// </summary>
        /// <param name="dolgozok"></param>
        public void setDolgozok(List<Dolgozo> dolgozok)
        {
            this.dolgozok = dolgozok;
        }

        /// <summary>
        /// Listából készítünk egy táblát
        /// </summary>
        /// <returns>A legyártott táblát kapjuk vissza.</returns>
        public DataTable getDolgozoDataTableFromList()
        {
            DataTable dolgozoDT = new DataTable();
            dolgozoDT.Columns.Add("id", typeof(int));
            dolgozoDT.Columns.Add("nev", typeof(string));
            dolgozoDT.Columns.Add("telefonszam", typeof(string));
            dolgozoDT.Columns.Add("email", typeof(string));
            dolgozoDT.Columns.Add("jelszo", typeof(string));
            foreach (Dolgozo d in dolgozok)
            {
                dolgozoDT.Rows.Add(d.getId(), d.getNev(), d.getTelefonszam(), d.getEmail(), d.getJelszo());
            }
            return dolgozoDT;
        }
        /// <summary>
        /// A listát feltöltjük a táblában lévő adatokkal
        /// </summary>
        /// <param name="dolgozodt">Maga a táblázat</param>
        private void fillDolgozoListFromDataTable(DataTable dolgozodt)
        {
            foreach (DataRow row in dolgozodt.Rows)
            {
                int id = Convert.ToInt32(row[0]);
                string nev = row[1].ToString();
                string telefonszam = row[2].ToString();
                string email = row[3].ToString();
                string jelszo = row[4].ToString();              
                Dolgozo d = new Dolgozo(id, nev, telefonszam, email, jelszo);
                dolgozok.Add(d);
            }
        }

        /// <summary>
        /// Dolgozó Törlése a listából id alapján ha nem jó hibát dob
        /// </summary>
        /// <param name="id">A dolgozó azzonosítója</param>
        public void deleteDolgozoFromList(int id)
        {
            Dolgozo d = dolgozok.Find(x => x.getId() == id);
            if (d != null)
                dolgozok.Remove(d);
            else
                throw new RepositoryExceptionCantDelete("A dolgozot nem lehetett törölni.");
        }


        /// <summary>
        /// Frissiti a lista adott id-jű elemét
        /// </summary>
        /// <param name="id"> A dolgozonak adott azzonosító</param>
        /// <param name="modified">A modosítás ami máshol van deklarálva</param>
        public void updateDolgozoInList(int id, Dolgozo modified)
        {
            Dolgozo d = dolgozok.Find(x => x.getId() == id);
            if (d != null)
                d.update(modified);
            else
                throw new RepositoryExceptionCantModified("A dologzok módosítása nem sikerült");
        }


        /// <summary>
        /// Uj Dolgozó hozzá adása
        /// </summary>
        /// <param name="ujDolgozo">Az uj Dolgozó</param>
        public void addDolgozoToList(Dolgozo ujDolgozo)
        {
            try
            {
                dolgozok.Add(ujDolgozo);
            }
            catch (Exception e)
            {
                throw new RepositoryExceptionCantAdd("A dolgozok hozzáadása nem sikerült");
            }
        }
        
        /// <summary>
        /// Visszaadja az azzonosítót
        /// </summary>
        /// <param name="id">Azzonosító értéke</param>
        /// <returns></returns>

        public Dolgozo getDolgozo(int id)
        {
            return dolgozok.Find(x => x.getId() == id);
        }
        /// <summary>
        ///  Új azonosított hozz létre és  mindig 1-el növeli az utolsó azonosító számát
        /// </summary>
        /// <returns>A megnövelt azzonósítóval tér vissza</returns>
        public int getNextDolgozoId()
        {
            if (dolgozok.Count == 0)
                return 1;
            else
                return dolgozok.Max(x => x.getId()) + 1;
        }

        
        
        public int getDolgozoSzama(string dolgozNev)
        {
            Dolgozo dolgozo = dolgozok.Find(c => c.getNev() == dolgozNev);
            return dolgozo.getId();
        }
    }
}
