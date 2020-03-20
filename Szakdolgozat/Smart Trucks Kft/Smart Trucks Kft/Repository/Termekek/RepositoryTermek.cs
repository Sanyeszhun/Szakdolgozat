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
    {  //Termék lista deklarálása
        List<Termek> termekek;

        //Termék visszadása a listának
        public List<Termek> getTemekek() 
        {
            return termekek;
        }

        /// <summary>
        /// Termék beállitása
        /// </summary>
        /// <param name="termekek"></param>
        public void setTermekek(List<Termek> termekek)
        {
            this.termekek = termekek;
        }

        /// <summary>
        /// Listából készítünk egy táblát
        /// </summary>
        /// <returns>A legyártott táblát kapjuk vissza.</returns>
        public DataTable getTermekekDataTableFromList() 
        {
            DataTable termekDT = new DataTable();
            termekDT.Columns.Add("teid", typeof(int));
            termekDT.Columns.Add("Mennyiseg", typeof(string));
            termekDT.Columns.Add("Suly", typeof(string));
            termekDT.Columns.Add("TermekNev", typeof(string));          
            foreach (Termek i in termekek)
            {
                termekDT.Rows.Add(i.getTermekId(), i.getTermekMennyiseg(), i.getTermekSuly(), i.getTermekNev());
            }
            return termekDT;


        }
    }
}
