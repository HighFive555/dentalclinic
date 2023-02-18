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
using System.Windows.Markup;
using System.Data.SqlClient;
using System.IO;

namespace dentalclinic
{
    public partial class EMR : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP - DQGMNGN\SQLEXPRESS; Initial Catalog = Dental_Clinic; Integrated Security = True");
        
        
        public EMR()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void EMR_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-DQGMNGN\\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");
        SqlCommand cmd;
       

        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 7);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.AliceBlue;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 8);


        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {

                string sql = "SELECT Patient_ID, First_Name, Last_Name, Diabetes, Pressure, Kidney, Heart, Anemia, Sensitive, Braces, Injuries, Dry_Mouth, Denture, Allergies,Profile_Picture,Panorama FROM Patient_History WHERE Patient_ID ='" + textBox1.Text + "'";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    cmd = new SqlCommand(sql, conn);



                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();



                    if (reader.HasRows)
                    {
                        
                        byte[] img = (byte[])(reader["Profile_Picture"]);
                        byte[] img1 = (byte[])(reader["Panorama"]);
                        textBox2.Text = reader["First_Name"].ToString();
                        textBox4.Text = reader["Last_Name"].ToString();
                        textBox3.Text = reader["Diabetes"].ToString();
                        textBox6.Text = reader["Pressure"].ToString();
                        textBox5.Text = reader["Kidney"].ToString();
                        textBox9.Text = reader["Heart"].ToString();
                        textBox7.Text = reader["Anemia"].ToString();
                        textBox8.Text = reader["Sensitive"].ToString();
                        textBox12.Text = reader["Braces"].ToString();
                        textBox10.Text = reader["Injuries"].ToString();
                        textBox11.Text = reader["Dry_Mouth"].ToString();
                        textBox15.Text = reader["Denture"].ToString();
                        textBox13.Text = reader["Allergies"].ToString();



                        if (img == null)
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox1.Image = Image.FromStream(ms);
                        }

                        if (img1 == null)
                        {
                            pictureBox3.Image = null;
                        }
                        else
                        {
                            MemoryStream ms1 = new MemoryStream(img1);
                            pictureBox3.Image = Image.FromStream(ms1);
                        }
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("Image doesn't Exist!");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

            conn.Close();

            SetFontAndColors();
            conn.Open();
            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT tooth_no, problem, treatment, drug_dose, surface, action, risk, radiology_description, date FROM Progress WHERE Patient_ID  ='" + textBox1.Text + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();

            conn.Close();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Progress values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "' ,'" + comboBox8.Text + "' ,'" + comboBox7.Text + "','" + comboBox6.Text + "','" + richTextBox1.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBox1.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Progress Note Added Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Dentist den = new Dentist();
            den.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }

    
}
