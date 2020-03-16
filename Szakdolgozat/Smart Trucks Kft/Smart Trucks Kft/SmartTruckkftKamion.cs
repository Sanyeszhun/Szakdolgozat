

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
        private DataTable kamionDT = new DataTable();
        bool ujAdatfelvitelkamion = false;


        private void buttonBetolteskamionok_Click(object sender, EventArgs e)
        {
            frissitAdatokkalDataGriedViewtKamiont();
            beallitKamionDataGriViewt();
            beallitGombokatIndulaskorKamion();
            dataGridViewKamionok.SelectionChanged += dataGridViewKamionok_SelectionChanged;
        }
        private void frissitAdatokkalDataGriedViewtKamiont()
        {
            //Adattáblát feltölti a repoba lévő pizza listából
            kamionDT = repo.getKamionDataTableFromList();
            //Pizza DataGridView-nak a forrása a pizza adattábla
            dataGridViewKamionok.DataSource = null;
            dataGridViewKamionok.DataSource = kamionDT;
        }

        private void beallitKamionDataGriViewt()
        {
            dolgozDT.Columns[0].ColumnName = "Azonosító";
            dolgozDT.Columns[0].Caption = "Kamion azonosító";
            dolgozDT.Columns[1].ColumnName = "Muszakierv";
            dolgozDT.Columns[1].Caption = "Kamion Muszakierv";
            dolgozDT.Columns[2].ColumnName = "Rendszam";
            dolgozDT.Columns[2].Caption = "Kamion Rendszam";
            dolgozDT.Columns[3].ColumnName = "Motor";
            dolgozDT.Columns[3].Caption = "Kamion Motor";
            dolgozDT.Columns[4].ColumnName = "Uzemanyag";
            dolgozDT.Columns[4].Caption = "Kamion Uzemanyag";
            dolgozDT.Columns[4].ColumnName = "Suly";
            dolgozDT.Columns[4].Caption = "Kamion Suly";
            dolgozDT.Columns[4].ColumnName = "Hajtas";
            dolgozDT.Columns[4].Caption = "Kamion Hajtas";

            dataGridViewKamionok.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridViewKamionok.ReadOnly = true;
            dataGridViewKamionok.AllowUserToDeleteRows = false;
            dataGridViewKamionok.AllowUserToAddRows = false;
            dataGridViewKamionok.MultiSelect = false;
        }
        private void beallitGombokatIndulaskorKamion()
        {
            panel2.Visible = false;

            if (dataGridViewKamionok.SelectedRows.Count != 0)
                buttonUjKamion.Visible = false;
            else
                buttonUjKamion.Visible = true;
        }

        private void dataGridViewKamionok_SelectionChanged(object sender, EventArgs e)
        {
            if (ujAdatfelvitelkamion)
            {
                beallitGombokatKattintaskorKamion();
            }
            if (dataGridViewKamionok.SelectedRows.Count == 1)
            {
                panel2.Visible = true;

                buttonUjKamion.Visible = true;
                textBoxKamionID.Text =
                     dataGridViewKamionok.SelectedRows[0].Cells[0].Value.ToString();
                maskedTextBoxKamionMuszaki.Text =
                   dataGridViewKamionok.SelectedRows[0].Cells[1].Value.ToString();
                maskedTextBoxKamionRend.Text =
                      dataGridViewKamionok.SelectedRows[0].Cells[2].Value.ToString();
                textBoxKamionMotor.Text =
                     dataGridViewKamionok.SelectedRows[0].Cells[3].Value.ToString();
                textBoxKamionUzem.Text =
                    dataGridViewKamionok.SelectedRows[0].Cells[4].Value.ToString();
                textBoxKamionSuly.Text =
                     dataGridViewKamionok.SelectedRows[0].Cells[5].Value.ToString();
                textBoxKamionHajtas.Text =
                    dataGridViewKamionok.SelectedRows[0].Cells[6].Value.ToString();
            }
            else
            {
                panel2.Visible = false;

                buttonUjKamion.Visible = false;
            }


        }

       
        private void beallitGombokatKattintaskorKamion()
        {
            ujAdatfelvitel = false;
            buttonUjKamion.Visible = false;
            

            //errorProviderDolgozName.Clear();
            //errorProviderDolgozoTel.Clear();
            //errorProviderDolgozoEmail.Clear();
        }


        private void buttonKamionTorles_Click(object sender, EventArgs e)
        {
            torolHibauzenetet();
            if ((dataGridViewKamionok.Rows == null) ||
                (dataGridViewKamionok.Rows.Count == 0))
                return;
            //A felhasználó által kiválasztott sor a DataGridView-ban            
            int sor = dataGridViewKamionok.SelectedRows[0].Index;
            if (MessageBox.Show(
                "Valóban törölni akarja a sort?",
                "Törlés",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                //1. törölni kell a listából
                int tid = -1;
                if (!int.TryParse(
                        dataGridViewKamionok.SelectedRows[0].Cells[0].Value.ToString(),
                         out tid))
                    return;
                try
                {
                    repo.deleteKamionFromList(tid);
                }
                catch (RepositoryExceptionCantDelete recd)
                {
                    kiirHibauzenetet(recd.Message);
                    Debug.WriteLine("A pizza törlés nem sikerült, nincs a listába!");
                }
                //2. törölni kell az adatbázisból
                RepositoryKamionDatabaseTable rdtk = new RepositoryKamionDatabaseTable();
                try
                {
                    rdtk.deleteKamionFromDatabase(tid);
                }
                catch (Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                }
                //3. frissíteni kell a DataGridView-t  
                frissitAdatokkalDataGriedViewtKamiont();
                if (dataGridViewKamionok.SelectedRows.Count <= 0)
                {
                    buttonUjKamion.Visible = true;

                }
                beallitKamionDataGriViewt();



            }
        }

        private void buttonKamionModosit_Click(object sender, EventArgs e)
        {
            torolHibauzenetet();
            //errorProviderDolgozName.Clear();
            //errorProviderDolgozoTel.Clear();
            //errorProviderDolgozoEmail.Clear();
            try
            {
                Kamion modosult = new Kamion(
                    Convert.ToInt32(textBoxKamionID.Text),
                   maskedTextBoxKamionMuszaki.Text,
                   maskedTextBoxKamionRend.Text,
                    textBoxKamionMotor.Text,
                    textBoxKamionUzem.Text,
                    textBoxKamionSuly.Text,
                    textBoxKamionHajtas.Text
                    );
                int azonosito = Convert.ToInt32(textBoxKamionID.Text);
                //1. módosítani a listába
                try
                {
                    repo.updateKamionInList(azonosito, modosult);
                }
                catch (Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                    return;
                }
                //2. módosítani az adatbáziba
               RepositoryKamionDatabaseTable rdtk = new RepositoryKamionDatabaseTable();
                try
                {
                    rdtk.updateInDatabase(azonosito, modosult);
                }
                catch (Exception ex)
                {
                    kiirHibauzenetet(ex.Message);
                }
                //3. módosítani a DataGridView-ban           
                frissitAdatokkalDataGriedViewtKamiont();
            }
            //catch (ModelDolgozoNotValidNevExeption nvn)
            //{
            //    errorProviderDolgozName.SetError(textBoxDolgozoNev, nvn.Message);
            //}
            //catch (ModelDolgozoNotValidNTelExeption nvt)
            //{
            //    errorProviderDolgozoTel.SetError(textBoxDolgozoTel, nvt.Message);
            //}
            //catch (ModelDolgozoNotValidEmailExeption nve)
            //{
            //    errorProviderDolgozoEmail.SetError(textBoxDolgozoEmail, nve.Message);
            //}
            catch (RepositoryExceptionCantModified recm)
            {
                kiirHibauzenetet(recm.Message);
                Debug.WriteLine("Módosítás nem sikerült, a kamion nincs a listába!");
            }
            catch (Exception ex)
            { }
        }
    }
}

