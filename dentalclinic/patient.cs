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
    public partial class patient : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");
        public patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Patient_History values ('" + textBox3.Text+ "','" + textBox1.Text + "','" + textBox2.Text + "', '" + dateTimePicker1.MaxDate+ "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + dateTimePicker2.MaxDate + "','" + checkBox1.Checked + "','" + checkBox5.Checked + "','" + checkBox4.Checked + "','" + checkBox3.Checked + "','" + checkBox2.Checked+ "','" + comboBox2.Text+ "','" + checkBox6.Checked+ "','" + checkBox9.Checked+ "','" + checkBox8.Checked+ "','" + checkBox7.Checked+ "','" + checkBox10.Checked+"')";
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("New Patient Added Successfuly");

            Nurse N = new Nurse();
            N.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();

            textBox4.Clear();

            textBox7.Clear();
            textBox9.Clear();
            textBox8.Clear();

        }
    }
}
