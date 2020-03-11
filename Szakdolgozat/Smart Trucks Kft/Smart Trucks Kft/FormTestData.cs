

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
        private void buttonAdatbazisLetrehozas_Click(object sender, EventArgs e)
        {
            rdDolgozo.createTableDolgozo();
            rdDolgozo.fillDolgozoWithTestDataFromSQLCommand();
                  repo.setDolgozok(rdDolgozo.getDolgozoFromDatabaseTable());


        }
    }
}

