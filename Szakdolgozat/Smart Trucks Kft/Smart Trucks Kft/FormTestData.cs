

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
        RepositoryDatabase rd = new RepositoryDatabase();
        RepositoryDatabaseTableDolgozo rdDolgozo = new RepositoryDatabaseTableDolgozo();
       

        private void torolHibauzenetet()
        {
            toolStripLabelHibauzenet.ForeColor = Color.Black;
            toolStripLabelHibauzenet.Text = "";
        }
        private void kiirHibauzenetet(string hibauzenet)
        {
            toolStripLabelHibauzenet.ForeColor = Color.Red;
            toolStripLabelHibauzenet.Text = hibauzenet;
        }
        private void buttonAdatbazisletrehozas_Click(object sender, EventArgs e)
        {
            rd.createDatabase();
            rdDolgozo.createTableDolgozo();
            rdDolgozo.fillDolgozoWithTestDataFromSQLCommand();
            repo.setDolgozok(rdDolgozo.getDolgozoFromDatabaseTable());
           
        }

       
        
        private void dataGridViewDolgozok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = this.dataGridViewDolgozok.Rows[e.RowIndex];
                textBoxDolgozoID.Text = row.Cells[0].Value.ToString();
                textBoxDolgozoNev.Text = row.Cells[1].Value.ToString();
                textBoxDolgozoTel.Text = row.Cells[2].Value.ToString();
                textBoxDolgozoEmail.Text = row.Cells[3].Value.ToString();
                textBoxDologozJel.Text = row.Cells[4].Value.ToString();

            }
        }

        private void törliAzAdatbázistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                torolHibauzenetet();
                rd.deleteDatabase();

            }
            catch (Exception ex)
            {
                kiirHibauzenetet("Adatbázis törlési hiba!");
            }


        }
            

       

    }
}

