using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dentalclinic;

namespace dentalclinic
{
    public partial class requestden : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");
        public requestden()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Request (product,quantity) values ('" + textBox1.Text + "','" + comboBox1.Text + "')";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update Request set Request.price = Prices.price FROM (select Prices.price from Prices where product_name = '" + textBox1.Text + "') Prices  where product = '" + textBox1.Text + "'";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update Request set total = price*quantity where product = '" + textBox1.Text + "'";
            cmd2.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Supplies Added Successfuly");

            Dentist f4 = new Dentist();
            f4.Show();
            this.Hide();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dentist den = new Dentist();
            den.Show();
            this.Hide();
        }
    }
}
