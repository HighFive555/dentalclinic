using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dentalclinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          

            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Rows.Add("Nurse");
            dt.Rows.Add("Dentist");



            DataRow dr = dt.NewRow();
            dr["Title"] = "Login as";
            dt.Rows.InsertAt(dr, 0);
            Login_cmb.DataSource = dt;
            Login_cmb.DisplayMember = "Title";
            Login_cmb.ValueMember = "Title";


            


        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DQGMNGN\SQLEXPRESS;Initial Catalog=Dental_Clinic;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String username, password, login_as;
            username = Username_txt.Text;
            password = Password_txt.Text;
            login_as = Login_cmb.Text;




            try
            {
                string querry = "SELECT * FROM Login where username = '" + Username_txt.Text + "' AND password = '" + Password_txt.Text + "' AND login_as = '"+Login_cmb.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                


                if (dtable.Rows.Count > 0)
                {
                    username = Username_txt.Text;
                    password = Password_txt.Text;
                    login_as = Login_cmb.Text;

                    if (Login_cmb.SelectedValue.ToString() == "Nurse" & Login_cmb.Text == "Nurse")
                    {
                        if (Application.OpenForms.OfType<Nurse>().Count() == 1)
                            Application.OpenForms.OfType<Nurse>().First().Close();
                        Nurse frm = new Nurse();
                        frm.Show();
                        this.Hide();



                    }
                    else if (Login_cmb.SelectedValue.ToString() == "Dentist" & Login_cmb.Text == "Dentist")
                    {
                        if (Application.OpenForms.OfType<Dentist>().Count() == 1)
                            Application.OpenForms.OfType<Dentist>().First().Close();
                        Dentist frm = new Dentist();
                        frm.Show();
                        this.Hide();
                    }




                }
                else
                {
                   
                    Username_txt.Clear();
                    Password_txt.Clear();

                    Username_txt.Focus();
                    
                }
            }

            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                conn.Close();
            }

           

        }

        private void SignUp_btn_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
            this.Hide();
        }

        private void Username_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

       
           
    }



