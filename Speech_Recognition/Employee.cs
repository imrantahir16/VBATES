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
    public partial class Employee : Form
    {
        MySqlConnection connection=new MySqlConnection("datasource=localhost;port=3306;username=root;password=root");
        public Employee()
        {
            InitializeComponent();
           
        }
        
        private void Save_Changes_Click(object sender, EventArgs e)
        {

            string insertQuery = "INSERT INTO database.schedule (busID, trevalingclass, departure, arrival) VALUES ('" + bus_id.Text + "','" + trevaling_class.Text + "','" + departure.Text + "','" + arrival.Text + "')";
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            connection.Open();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Inserted");
                }
                else
                {
                    MessageBox.Show("Data Not Inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            connection.Close();
        }
    }
}
