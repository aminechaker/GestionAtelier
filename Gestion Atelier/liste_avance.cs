using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Atelier
{
    public partial class liste_avance : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = new SqlConnection();
        SqlDataReader dr;
        SqlDataAdapter sda = new SqlDataAdapter();
        public liste_avance()
        {
            InitializeComponent();
        }

        private void liste_avance_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from avance ";
            cmd.Connection = cnn;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            dataGridView1.DataSource = bSource;
            sda.Update(dt);
        }

        private void RetourPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
