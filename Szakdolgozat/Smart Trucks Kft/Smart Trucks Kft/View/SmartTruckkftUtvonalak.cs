

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
using System.Diagnostics;

namespace Smart_Trucks_Kft
{
    public partial class SmartTruckkft : Form
    {

        private void feltoltComboBoxotDolgozokkal()
        {
            comboBoxDolgozok.DataSource = repo.getDolgozokNev();
           
        }

        private void comboBoxDolgozok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDolgozok.SelectedIndex < 0)
                return;
           listViewDolgozoUtvonalak.Visible = true;
           labelDolgozoUtvonalak.Visible = true;

            string dolgozoNev = comboBoxDolgozok.Text;
            feltoltListViewtAdatokkal(dolgozoNev);
        }

        private void feltoltListViewtAdatokkal(string dolgozoNev)
        {
            listViewDolgozoUtvonalak.Items.Clear();
            List<Kuldes> dolgozok = repo.getKudlesek(dolgozoNev);
            foreach (Kuldes dolgozo in dolgozok)
            {
                ListViewItem lvi = new ListViewItem(dolgozo.getKikuldesId().ToString());
                lvi.SubItems.Add(dolgozo.getKamionId().ToString());
                lvi.SubItems.Add(dolgozo.getHelyId().ToString());
                lvi.SubItems.Add(dolgozo.getTermekId().ToString());
                lvi.SubItems.Add(dolgozo.getDolgozoId().ToString());               
                lvi.SubItems.Add(dolgozo.getKikuldes().ToString());
                lvi.SubItems.Add(dolgozo.getVisszaerkezes().ToString());
                
                       
                listViewDolgozoUtvonalak.Items.Add(lvi);
            }
            listViewDolgozoUtvonalak.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDolgozoUtvonalak.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDolgozoUtvonalak.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDolgozoUtvonalak.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDolgozoUtvonalak.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDolgozoUtvonalak.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDolgozoUtvonalak.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void beallitUtvonalakTabPaAgeIndulaskor()
        {
           listViewDolgozoUtvonalak.Visible = false;
            labelDolgozoUtvonalak.Visible = false;



            listViewDolgozoUtvonalak.GridLines = true;
            listViewDolgozoUtvonalak.View = View.Details;
            listViewDolgozoUtvonalak.FullRowSelect = true;

            listViewDolgozoUtvonalak.Columns.Add("Azonosító");
            listViewDolgozoUtvonalak.Columns.Add("Kamion");
            listViewDolgozoUtvonalak.Columns.Add("Hely");
            listViewDolgozoUtvonalak.Columns.Add("Termek");
            listViewDolgozoUtvonalak.Columns.Add("Dolgozó");
            listViewDolgozoUtvonalak.Columns.Add("kikuldes");
            listViewDolgozoUtvonalak.Columns.Add("Visszaerkezes");


            listViewDolgozoUtvonalak.Columns[1].TextAlign = HorizontalAlignment.Right;
            listViewDolgozoUtvonalak.Columns[2].TextAlign = HorizontalAlignment.Right;
            listViewDolgozoUtvonalak.Columns[3].TextAlign = HorizontalAlignment.Right;
            listViewDolgozoUtvonalak.Columns[4].TextAlign = HorizontalAlignment.Right;
            listViewDolgozoUtvonalak.Columns[5].TextAlign = HorizontalAlignment.Right;
            listViewDolgozoUtvonalak.Columns[6].TextAlign = HorizontalAlignment.Right;
            
        }

    }
}

