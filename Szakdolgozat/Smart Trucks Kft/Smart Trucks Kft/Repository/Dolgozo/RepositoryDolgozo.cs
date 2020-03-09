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
    {
        List<Dolgozo> dolgozok;

        public List<Dolgozo> GetDolgozok()
        {
            return dolgozok;
        }

        public List<string> getDolgozokNev()
        {
            List<string> dolgozoNevek = new List<string>();
            foreach (Dolgozo d in dolgozok)
            {
                dolgozoNevek.Add(d.getNev());
            }
            return dolgozoNevek;
        }

        public void setDolgozok(List<Dolgozo> dolgozok)
        {
            this.dolgozok = dolgozok;
        }

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

        public void deleteDolgozoFromList(int id)
        {
            Dolgozo d = dolgozok.Find(x => x.getId() == id);
            if (d != null)
                dolgozok.Remove(d);
            else
                throw new RepositoryExceptionCantDelete("A dolgozot nem lehetett törölni.");
        }

        public void updateDolgozoInList(int id, Dolgozo modified)
        {
            Dolgozo d = dolgozok.Find(x => x.getId() == id);
            if (d != null)
                d.update(modified);
            else
                throw new RepositoryExceptionCantModified("A dologzok módosítása nem sikerült");
        }
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

        public Dolgozo getDolgozo(int id)
        {
            return dolgozok.Find(x => x.getId() == id);
        }

        public int getNextDolgozoId()
        {
            if (dolgozok.Count == 0)
                return 1;
            else
                return dolgozok.Max(x => x.getId()) + 1;
        }
    }
}
