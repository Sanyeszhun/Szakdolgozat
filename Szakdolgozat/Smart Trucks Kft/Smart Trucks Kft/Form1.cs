using Smart_Trucks_Kft.Repository.Kamionn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Trucks_Kft
{
    public partial class Form1 : Form
    {
        private DataTable kamionDT = new DataTable();

        private KMRepository kr = new KMRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void buttonBetolt_Click(object sender, EventArgs e)
        {
            //Adatbázisban pizza tábla kezelése
            RepositoryKamionDatabaseTable rtp = new RepositoryKamionDatabaseTable();
            //A repo-ba lévő pizza listát feltölti az adatbázisból
            repo.setPizzas(rtp.getPizzasFromDatabaseTable());
            frissitAdatokkalDataGriedViewt();
            beallitPizzaDataGriViewt();
            beallitGombokatIndulaskor();
            dataGridViewPizzak.SelectionChanged += DataGridViewPizzak_SelectionChanged;
        }
    }
    }

