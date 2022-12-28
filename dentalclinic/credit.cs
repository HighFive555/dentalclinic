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

    public partial class credit : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");
        public credit()
        {
            InitializeComponent();
        }

        private void credit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Credit values ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Credit Payment Added Successfuly");

            
            Nurse nn = new Nurse();
            nn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            payment pp1 = new payment();
            pp1.Show();
            this.Hide();
        }
    }
}
