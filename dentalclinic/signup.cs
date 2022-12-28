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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace dentalclinic
{
    public partial class signup : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");
        public signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Login values ('" + Name_txt.Text + "','" + Email_txt.Text + "','" + DOB_dt.MaxDate + "', '" + Phone_txt.Text + "','" + Gender_cmb.Text + "','" + Username_txt.Text + "','" + Password_txt.Text + "','" + Position_cmb.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
       
            MessageBox.Show("Record Added Successfuly");

            Form1 login = new Form1();
            login.Show();
            this.Hide();

        }

        private void Phone_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
