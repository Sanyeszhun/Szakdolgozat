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
    partial class KMRepository
    {
        List<Kamion> kamionok;

        public List<Kamion> GetKamions()
        {
            return kamionok;
        
        
        }
        public void setKamionok(List<Kamion> kamionok) 
        {

            this.kamionok = kamionok;
        }

        public DataTable getKamionDataTableFromList() 
        {
            DataTable kamionDT = new DataTable();
            kamionDT.Columns.Add("Azonosito", typeof(int));
            kamionDT.Columns.Add("MuszakiErv", typeof(int));
            kamionDT.Columns.Add("Rendszam", typeof(string));
            kamionDT.Columns.Add("Motor", typeof(string));
            kamionDT.Columns.Add("Uzemanyag", typeof(string));
            kamionDT.Columns.Add("Suly", typeof(int));
            kamionDT.Columns.Add("Hajtas", typeof(string));
            foreach (Kamion k in kamionok) 
            {

                kamionDT.Rows.Add(k.getId(), k.getDate(), k.getRend(), k.getMotor(), k.getUzemanyag(), k.getSuly(), k.getHajtas());
            
            }
            return kamionDT;
        }

        private void fillKamionListFromDataTable(DataTable kamiondt) 
        {
            foreach (DataRow row in kamiondt.Rows) 
            {
                int tid = Convert.ToInt32(row[0]);
                int date = Convert.ToInt32(row[1]);///datumm ido hogy kell???
                string rendszam = row[2].ToString();
                string motor = row[3].ToString();
                string uzemanyag= row[4].ToString();
                int suly = Convert.ToInt32(row[5]);
                string hajtas = row[6].ToString();
                Kamion k = new Kamion(tid, date, rendszam, motor, uzemanyag, suly, hajtas);
                kamionok.Add(k);

            }
 
        }
        public deletKamionFromlistByID(int tid)
        {
            Kamion k = kamionok.Find(x => x.getId() == tid);
            if (k != null)
            {
                kamionok.Remove(k);

            }
            else 
            {
                throw new RepositoryExceptionCantDelete("a Kamiont nem lehet törölni");
            }
            
        
        }
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

        public Kamion GetKamion(int tid) 
        {
            return kamionok.Find(x => x.getId() == tid);
        }

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
    }
}
