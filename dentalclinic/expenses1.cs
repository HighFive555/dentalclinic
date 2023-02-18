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
    public partial class expenses1 : Form
    {
        private string Date;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");
        public expenses1()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("d/M/yyyy");
        }

        private void pictureBoxPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPrint, "Print");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panelPrint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {

        }

        private void expenses1_Load(object sender, EventArgs e)
        {
            label15.Text = Date;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            try
            {


                string sql1 = "SELECT product,quantity,price,total FROM Request WHERE Request_ID ='" + textBox1.Text + "'";
                if (conn.State != ConnectionState.Open)
                {

                    conn.Open();
                    SqlCommand cmd1 = conn.CreateCommand();
                    cmd1 = new SqlCommand(sql1, conn);
                    SqlDataReader reader1 = cmd1.ExecuteReader();
                    reader1.Read();


                    if (reader1.HasRows)
                    {
                        textBox3.Text = reader1["product"].ToString();
                        textBox4.Text = reader1["quantity"].ToString();
                        textBox5.Text = reader1["price"].ToString();
                        textBox6.Text = reader1["total"].ToString();
                    }



                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nurse nn = new Nurse();
            nn.Show();
            this.Hide();
        }
    }
}
