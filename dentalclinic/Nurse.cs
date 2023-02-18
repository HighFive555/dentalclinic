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
using dentalclinic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dentalclinic
{
    public partial class Nurse : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");
        public Nurse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient pt = new patient();
            pt.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nname_txt_TextChanged(object sender, EventArgs e)
        {
            
            

           
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            payment pay = new payment();
            pay.Show();
            this.Hide();
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            ocr ocrr = new ocr();
            ocrr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n_appointments napp = new n_appointments();
            napp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            expenses1 inv = new expenses1();
            inv.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();   
            form.Show();
            this.Hide();
        }
    }
}
