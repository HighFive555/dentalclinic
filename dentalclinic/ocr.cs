using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;

namespace dentalclinic
{
    public partial class ocr : Form
    {
        public ocr()
        {
            InitializeComponent();
        }

        private void ocr_Load(object sender, EventArgs e)
        {

        }

        private void Upload_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg| PNG files (*.png)|*.png| All Files (*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    imageLocation = dialog.FileName;
                    pictarget.ImageLocation = imageLocation;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ButtonClick1_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);

                string plainText = objOcr.GetTextFromImage(pictarget.ImageLocation);

                textBox1.Text = plainText;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nurse nn = new Nurse();
            nn.Show();
            this.Hide();
        }
    }
}
