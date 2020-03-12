

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

        private DataTable dolgozDT = new DataTable();
        bool ujAdatfelvitel = false;


        private void buttonBetolt_Click_1(object sender, EventArgs e)
        {
            frissitAdatokkalDataGriedViewt();
            beallitDolgozoDataGriViewt();
            beallitGombokatIndulaskor();
            dataGridViewDolgozok.SelectionChanged += DataGriedViewDolgozok_SelectionChanged;
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

        private void buttonDolgozoTorol_Click(object sender, EventArgs e)
        {
            torolHibauzenetet();
            if ((dataGridViewDolgozok.Rows == null) ||
                (dataGridViewDolgozok.Rows.Count == 0))
                return;
            //A felhasználó által kiválasztott sor a DataGridView-ban            
            int sor =dataGridViewDolgozok.SelectedRows[0].Index;
            if (MessageBox.Show(
                "Valóban törölni akarja a sort?",
                "Törlés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //1. törölni kell a listából
                int id = -1;
                if (!int.TryParse(
                        dataGridViewDolgozok.SelectedRows[0].Cells[0].Value.ToString(),
                         out id))
                    return;
                try
                {
                    repo.deleteDolgozoFromList(id);
                }
                catch (RepositoryExceptionCantDelete recd)
                {
                    kiirHibauzenetet(recd.Message);
                    Debug.WriteLine("A pizza törlés nem sikerült, nincs a listába!");
                }
                //2. törölni kell az adatbázisból
               RepositoryDatabaseTableDolgozo rdtd = new RepositoryDatabaseTableDolgozo();
                try
                {
                    rdtd.deleteDolgozoFromDatabase(id);
                }
                catch (Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                }
                //3. frissíteni kell a DataGridView-t  
                frissitAdatokkalDataGriedViewt();
                if (dataGridViewDolgozok.SelectedRows.Count <= 0)
                {
                    buttonUjDolgozo.Visible = true;
                   
                }
                beallitDolgozoDataGriViewt();


               
            }
           
        }

        private void buttonDolgozoMod_Click(object sender, EventArgs e)
        {
            torolHibauzenetet();
            //errorProviderPizzaName.Clear();
            //errorProviderPizzaPrice.Clear();
            try
            {
                Dolgozo modosult = new Dolgozo(
                    Convert.ToInt32(textBoxDolgozoID.Text),
                    textBoxDolgozoNev.Text,
                    textBoxDolgozoTel.Text,
                    textBoxDolgozoEmail.Text,
                    textBoxDologozJel.Text
                    );
                int azonosito = Convert.ToInt32(textBoxDolgozoID.Text);
                //1. módosítani a listába
                try
                {
                    repo.updateDolgozoInList(azonosito, modosult);
                }
                catch (Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                    return;
                }
                //2. módosítani az adatbáziba
                RepositoryDatabaseTableDolgozo rdtd = new RepositoryDatabaseTableDolgozo();
                try
                {
                    rdtd.updateDolgozoInDatabase(azonosito, modosult);
                }
                catch (Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                }
                //3. módosítani a DataGridView-ban           
                frissitAdatokkalDataGriedViewt();
            }
            //catch (ModelPizzaNotValidNameExeption nvn)
            //{
            //    errorProviderPizzaName.SetError(textBoxPizzaNev, nvn.Message);
            //}
            //catch (ModelPizzaNotValidPriceExeption nvp)
            //{
            //    errorProviderPizzaName.SetError(textBoxPizzaAr, nvp.Message);
            //}
            catch (RepositoryExceptionCantModified recm)
            {
                kiirHibauzenetet(recm.Message);
                Debug.WriteLine("Módosítás nem sikerült, a pizza nincs a listába!");
            }
            catch (Exception ex)
            { }
        }
        private void beallitGombokatIndulaskor()
        {
            panel1.Visible = false;
            
            if (dataGridViewDolgozok.SelectedRows.Count != 0)
             buttonUjDolgozo.Visible = false;
            else
                buttonUjDolgozo.Visible = true;
        }


        private void DataGriedViewDolgozok_SelectionChanged(object sender, EventArgs e)
        {

            if (ujAdatfelvitel)
            {
                beallitGombokatKattintaskor();
            }
            if (dataGridViewDolgozok.SelectedRows.Count == 1)
            {
                panel1.Visible = true;
               
                buttonUjDolgozo.Visible = true;
               textBoxDolgozoID.Text =
                    dataGridViewDolgozok.SelectedRows[0].Cells[0].Value.ToString();
                textBoxDolgozoNev.Text =
                   dataGridViewDolgozok.SelectedRows[0].Cells[1].Value.ToString();
               textBoxDolgozoTel.Text =
                    dataGridViewDolgozok.SelectedRows[0].Cells[2].Value.ToString();
               textBoxDolgozoEmail.Text =
                   dataGridViewDolgozok.SelectedRows[0].Cells[3].Value.ToString();
                textBoxDologozJel.Text =
                   dataGridViewDolgozok.SelectedRows[0].Cells[4].Value.ToString();
            }
            else
            {
                panel1.Visible = false;
               
                buttonUjDolgozo.Visible = false;
            }
        }

        private void beallitGombokatKattintaskor()
        {
            ujAdatfelvitel = false;
            buttonUjDolgozo.Visible = false;
            buttonDologozMEg.Visible = false;
         
            //errorProviderPizzaName.Clear();
            //errorProviderPizzaPrice.Clear();
        }
    }
}

