

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smart_Trucks_Kft.Repository;
using Smart_Trucks_Kft.Modell;


namespace Smart_Trucks_Kft
{
    public partial class SmartTruckkft : Form
    {

        private DataTable dolgozDT = new DataTable();


        private void buttonBetolt_Click_1(object sender, EventArgs e)
        {
            frissitAdatokkalDataGriedViewt();
            beallitDolgozoDataGriViewt();
        }
        
      

        

        private void beallitDolgozoDataGriViewt()
        {
            dolgozDT.Columns[0].ColumnName = "Azonosító";
            dolgozDT.Columns[0].Caption = "Dolgozó azonosító";
            dolgozDT.Columns[1].ColumnName = "Név";
            dolgozDT.Columns[1].Caption = "Dolgozó név";
            dolgozDT.Columns[2].ColumnName = "Telefonszám";
            dolgozDT.Columns[2].Caption = "Dolgozó Telefonszám";
            dolgozDT.Columns[3].ColumnName = "Email";
            dolgozDT.Columns[3].Caption = "Dolgozó Email";
            dolgozDT.Columns[4].ColumnName = "Jelszó";
            dolgozDT.Columns[4].Caption = "Dolgozó Jelszó";

            dataGridViewDolgozok.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDolgozok.ReadOnly = true;
            dataGridViewDolgozok.AllowUserToDeleteRows = false;
            dataGridViewDolgozok.AllowUserToAddRows = false;
            dataGridViewDolgozok.MultiSelect = false;
        }
        private void frissitAdatokkalDataGriedViewt()
        {
            //Adattáblát feltölti a repoba lévő pizza listából
            dolgozDT = repo.getDolgozoDataTableFromList();
            //Pizza DataGridView-nak a forrása a pizza adattábla
            dataGridViewDolgozok.DataSource = null;
           dataGridViewDolgozok.DataSource = dolgozDT;
        }
    }
}

