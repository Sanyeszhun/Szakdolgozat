﻿using Smart_Trucks_Kft.Modell;
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
    {/// <summary>
    /// Hely Lista deklarálása
    /// </summary>
        List<Hely> helyek;

        //Hely listának vissza adása
        public List<Hely> getHelyek() 
        {
            return helyek;
        }
        /// <summary>
        /// Hely beállitása
        /// </summary>
        /// <param name="helyek"></param>
        public void setHelyek(List<Hely> helyek)
        {
            this.helyek = helyek;
        }


        /// <summary>
        /// Listából készítünk egy táblát
        /// </summary>
        /// <returns>A legyártott táblát kapjuk vissza.</returns>
        public DataTable getHelyekDataTableFromList() 
        {
            DataTable helyDT = new DataTable();
            helyDT.Columns.Add("hid", typeof(int));
            helyDT.Columns.Add("Felvetelezohely", typeof(string));
            helyDT.Columns.Add("Tavolsag", typeof(string));
            helyDT.Columns.Add("Ido", typeof(string));
            helyDT.Columns.Add("Lerakohely", typeof(string));
            foreach (Hely h in helyek)
            {
                helyDT.Rows.Add(h.getHelyId(), h.getFelvetelezohely(), h.getTavolsag(), h.getIdo(),h.GetLerakohely());
            }
            return helyDT;


        }
    }
}
