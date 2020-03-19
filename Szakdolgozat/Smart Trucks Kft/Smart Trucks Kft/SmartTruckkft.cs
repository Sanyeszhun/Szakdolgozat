

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

        Repository1 repo = new Repository1();

        

        public SmartTruckkft()
        { 
            beallitKezdoFormot();
            InitializeComponent();
        }

        public void beallitKezdoFormot()
        {
            this.Size = new Size(1024, 768);
            this.Text = "Smart truck KFT.";
           
           
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dolgozókToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlKamion.SelectTab("tabPageDolgozok");
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kamionokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlKamion.SelectTab("tabPageKamion");
        }

        private void utvonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlKamion.SelectTab("tabPageUtvonal");
        }

        private void törliATáblákatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                torolHibauzenetet();
                rdDolgozo.deleteTableDolgozo();
              
            }
            catch (Exception ex)
            {
                kiirHibauzenetet("Táblák törlése sikertelen!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxKamionMotor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxKamionSuly_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SmartTruckkft_Load(object sender, EventArgs e)
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

        private void tabControlKamion_Selected(object sender, TabControlEventArgs e)
        {
            beallitUtvonalakTabPaAgeIndulaskor();
            feltoltComboBoxotDolgozokkal();//kesz
        }

        

       
    }
    }

