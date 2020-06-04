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

namespace Speech_Recognition
{
    public partial class Seat_reservation : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;database=database;username=root;password=root");
        public Seat_reservation()
        {
            InitializeComponent();
        }
        public void Available_Seats()
        {

        }

        private void CheckStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            this.Visible = false;
            info.ShowDialog();
        }

        private void ToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM schedule WHERE arrival="+arrival.Text;
            connection.Open();
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void Seat_reservation_Load(object sender, EventArgs e)
        {

        }
    }
}
