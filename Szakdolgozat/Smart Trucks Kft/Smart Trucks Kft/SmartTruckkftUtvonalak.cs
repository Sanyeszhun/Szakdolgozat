

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
            listViewRendelesek.Items.Clear();
            List<Order> megrendelok = repo.getOrders(megrendeloNev);
            foreach (Order megrendelo in megrendelok)
            {
                ListViewItem lvi = new ListViewItem(megrendelo.getOrderId().ToString());
                lvi.SubItems.Add(megrendelo.getCourierId().ToString());
                lvi.SubItems.Add(megrendelo.getCustomerId().ToString());
                lvi.SubItems.Add(megrendelo.getDate().Substring(0, 13).ToString());
                lvi.SubItems.Add(megrendelo.getTime().ToString().Replace(',', ':'));
                if (megrendelo.getDone())
                    lvi.SubItems.Add("Teljesítve");
                else
                    lvi.SubItems.Add("Nem teljesítve");
                listViewRendelesek.Items.Add(lvi);
            }
            listViewRendelesek.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRendelesek.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRendelesek.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRendelesek.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewRendelesek.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

    }
}

