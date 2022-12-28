using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentalclinic
{
    public partial class cash : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");
        public cash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Cash values ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Cash Payment Added Successfuly");




            Nurse n2 = new Nurse();
            n2.Show();
            this.Hide();
                
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            payment pp = new payment();
            pp.Show();
            this.Hide();
        }
    }
}
