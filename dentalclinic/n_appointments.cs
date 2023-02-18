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
    public partial class n_appointments : Form
    {
        public n_appointments()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Appointments values ('" + textBox13.Text + "','" + textBox1.Text + "','" + textBox2.Text + "', '" + dateTimePicker1.Value.ToString() + "','" + comboBox2.Text + "' ,'" + comboBox3.Text + "' ,'" + comboBox1.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Appointment Added Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox13.Clear();
            textBox13.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            textBox11.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete FROM Appointments where Patient_ID = '" + textBox11.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Appointment deleted Successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "SELECT Patient_name,Dentist_name,Date, Start, Finish, Status FROM Appointments WHERE Patient_ID ='" + textBox3.Text + "'";
                if (conn.State != ConnectionState.Open)
                {

                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd = new SqlCommand(sql, conn);



                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();



                    if (reader.HasRows)
                    {
                        textBox4.Text = reader["Patient_name"].ToString();
                        textBox5.Text = reader["Dentist_name"].ToString();
                        textBox7.Text = reader["Date"].ToString();
                        textBox8.Text = reader["Status"].ToString();
                        textBox9.Text = reader["Start"].ToString();
                        textBox10.Text = reader["Finish"].ToString();



                    }
                    conn.Close();

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
         
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox3.Clear();
            textBox3.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Appointments set Dentist_name ='" + textBox14.Text + "' where Patient_ID = '" + textBox12.Text + "'";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update Appointments set Status ='" + comboBox4.Text + "' where Patient_ID = '" + textBox12.Text + "'";
            cmd1.ExecuteNonQuery();


            SqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update Appointments set Start ='" + comboBox8.Text + "' where Patient_ID = '" + textBox12.Text + "'";
            cmd2.ExecuteNonQuery();


            SqlCommand cmd3 = conn.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "update Appointments set Finish ='" + comboBox7.Text + "' where Patient_ID = '" + textBox12.Text + "'";
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = conn.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "update Appointments set Date ='" + dateTimePicker2.Value.ToString() + "' where Patient_ID = '" + textBox12.Text + "'";
            cmd4.ExecuteNonQuery();

            MessageBox.Show("Appointment updated successfully");
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox12.Clear();
            textBox12.Focus();
            textBox14.Clear();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Nurse nu = new Nurse();
            nu.Show();
            this.Hide();
        }
    }
}
