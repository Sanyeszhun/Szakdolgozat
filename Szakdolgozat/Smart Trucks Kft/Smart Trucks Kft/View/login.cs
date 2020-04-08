using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Smart_Trucks_Kft.Modell;
using Smart_Trucks_Kft.Repository;


namespace Smart_Trucks_Kft
{
    public partial class login : Form
    {
       
        private readonly string connectionString;

     

        public login()
        {
            InitializeComponent();
            ConnectionString cs = new ConnectionString();
            connectionString = cs.getConnectionString();
        }

        private void NevLabel_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {




          
           




        }
      

        private void buttonlogin_Click(object sender, EventArgs e)
        {

            MySqlConnection connection = new MySqlConnection(connectionString);
            string query = "SELECT * FROM `dolgozok` WHERE email = '" + textBox1.Text.Trim() + "' AND jelszo = '" + textBox2.Text.Trim() + "'";
            MySqlDataAdapter msda = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                SmartTruckkft f1 = new SmartTruckkft();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Hibás e-mail cím vagy jelszó!");
            }

        }
    }
}
