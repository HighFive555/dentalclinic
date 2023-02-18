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
    public partial class appointment : Form
    {
        public appointment()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");

        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 10);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.AliceBlue;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 11);


        }
        private void appointment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetFontAndColors();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Patient_ID, Patient_name, Date, Start, Finish, Status FROM Appointments";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dentist den = new Dentist();
            den.Show();
            this.Hide();
        }
    }
}
