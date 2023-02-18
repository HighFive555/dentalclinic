using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace dentalclinic
{
    public partial class patient : Form
    {
        
        
        public patient()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");
        string imglocation = "";
        string imglocation1 = "";
        SqlCommand cmd;

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                byte[] images1 = null;
                
                FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                FileStream stream1 = new FileStream(imglocation1, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                BinaryReader brs1 = new BinaryReader(stream1);
                images = brs.ReadBytes((int)stream.Length);
                images1 = brs1.ReadBytes((int)stream1.Length);
                conn.Open();
                
              
                string SqlQuery = "insert into Patient_History(Patient_ID,First_Name,Last_Name ,DOB ,Address,City ,Phone_No,Email ,National_ID,Entrance_Date,Diabetes,Pressure,Kidney,Heart,Anemia,Allergies,Sensitive,Braces,Injuries,Dry_Mouth,Denture,Profile_Picture,Panorama) values ('" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "', '" + dateTimePicker1.MaxDate + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + dateTimePicker2.MaxDate + "','" + checkBox1.Checked + "','" + checkBox5.Checked + "','" + checkBox4.Checked + "','" + checkBox3.Checked + "','" + checkBox2.Checked + "','" + comboBox2.Text + "','" + checkBox6.Checked + "','" + checkBox9.Checked + "','" + checkBox8.Checked + "','" + checkBox7.Checked + "','" + checkBox10.Checked + "',@Profile_Picture,@Panorama)";
                cmd = new SqlCommand(SqlQuery, conn);
                cmd.Parameters.Add(new SqlParameter("@Profile_Picture", images));
                cmd.Parameters.Add(new SqlParameter("@Panorama", images1));
                int n = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(n.ToString() + "Data Saved Successfully.......");

          

                MessageBox.Show("New Patient Added Successfuly");

                Nurse N = new Nurse();
                N.Show();
                this.Hide();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "SELECT Profile_Picture FROM Patient_History WHERE Patient_ID ='" + textBox3.Text + "'";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    cmd = new SqlCommand(sql, conn);



                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();



                    if (reader.HasRows)
                    {

                        byte[] img = (byte[])(reader["Profile_Picture"]);



                        if (img == null)
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox1.Image = Image.FromStream(ms);
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation1 = dialog.FileName.ToString();
                pictureBox2.ImageLocation= imglocation1;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void patient_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nurse nu = new Nurse();
            nu.Show();
            this.Hide();
        }
    }
}

