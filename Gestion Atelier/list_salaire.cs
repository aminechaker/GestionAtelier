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
    public partial class list_salaire : Form
    {
        SqlDataAdapter sda = new SqlDataAdapter();
        public list_salaire()
        {
            InitializeComponent();
        }

        private void list_salaire_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionDataSet.salaire' table. You can move, or remove it, as needed.
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=AMINE-PC\CHA;Initial Catalog=gestion;Persist Security Info=True;User ID=sa;Password=2510";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from salaire order by ID";
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
