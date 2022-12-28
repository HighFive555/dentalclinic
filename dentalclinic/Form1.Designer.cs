namespace dentalclinic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login_cmb = new System.Windows.Forms.ComboBox();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.SignUp_btn = new System.Windows.Forms.Button();
            this.login_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.login_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_cmb
            // 
            this.Login_cmb.AllowDrop = true;
            this.Login_cmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_cmb.ForeColor = System.Drawing.Color.SteelBlue;
            this.Login_cmb.FormattingEnabled = true;
            this.Login_cmb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Login_cmb.Items.AddRange(new object[] {
            "Dentist",
            "Nurse"});
            this.Login_cmb.Location = new System.Drawing.Point(773, 400);
            this.Login_cmb.Name = "Login_cmb";
            this.Login_cmb.Size = new System.Drawing.Size(132, 28);
            this.Login_cmb.TabIndex = 0;
            this.Login_cmb.Text = "Login as:";
            this.Login_cmb.SelectedIndexChanged += new System.EventHandler(this.Login_cmb_SelectedIndexChanged);
            // 
            // Username_txt
            // 
            this.Username_txt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Username_txt.Location = new System.Drawing.Point(773, 269);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(315, 26);
            this.Username_txt.TabIndex = 1;
            this.Username_txt.TextChanged += new System.EventHandler(this.Username_txt_TextChanged);
            // 
            // Password_txt
            // 
            this.Password_txt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Password_txt.Location = new System.Drawing.Point(773, 338);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(315, 26);
            this.Password_txt.TabIndex = 2;
            // 
            // SignUp_btn
            // 
            this.SignUp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp_btn.ForeColor = System.Drawing.Color.SteelBlue;
            this.SignUp_btn.Location = new System.Drawing.Point(925, 400);
            this.SignUp_btn.Name = "SignUp_btn";
            this.SignUp_btn.Size = new System.Drawing.Size(147, 36);
            this.SignUp_btn.TabIndex = 3;
            this.SignUp_btn.Text = "SignUp";
            this.SignUp_btn.UseVisualStyleBackColor = true;
            this.SignUp_btn.Click += new System.EventHandler(this.SignUp_btn_Click);
            // 
            // login_pic
            // 
            this.login_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_pic.Cursor = System.Windows.Forms.Cursors.Default;
            this.login_pic.Image = ((System.Drawing.Image)(resources.GetObject("login_pic.Image")));
            this.login_pic.Location = new System.Drawing.Point(35, 94);
            this.login_pic.Name = "login_pic";
            this.login_pic.Size = new System.Drawing.Size(659, 395);
            this.login_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.login_pic.TabIndex = 4;
            this.login_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(150, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 81);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dental Clinic";
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Username_lbl.Location = new System.Drawing.Point(772, 246);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(87, 20);
            this.Username_lbl.TabIndex = 6;
            this.Username_lbl.Text = "Username:";
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.ForeColor = System.Drawing.Color.SteelBlue;
            this.Password_lbl.Location = new System.Drawing.Point(772, 315);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(82, 20);
            this.Password_lbl.TabIndex = 7;
            this.Password_lbl.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(839, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 58);
            this.label2.TabIndex = 8;
            this.label2.Text = "Den-Tech";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(772, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Welcome back! Please Login to your account.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 491);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_lbl);
            this.Controls.Add(this.Username_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_pic);
            this.Controls.Add(this.SignUp_btn);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.Login_cmb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Login_cmb;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Button SignUp_btn;
        private System.Windows.Forms.PictureBox login_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

