namespace dentalclinic
{
    partial class ocr
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
            this.Upload = new System.Windows.Forms.Button();
            this.pictarget = new System.Windows.Forms.PictureBox();
            this.ButtonClick1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictarget)).BeginInit();
            this.SuspendLayout();
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Upload.Location = new System.Drawing.Point(38, 442);
            this.Upload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(567, 61);
            this.Upload.TabIndex = 8;
            this.Upload.Text = "Upload Image";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // pictarget
            // 
            this.pictarget.Location = new System.Drawing.Point(38, 26);
            this.pictarget.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictarget.Name = "pictarget";
            this.pictarget.Size = new System.Drawing.Size(567, 381);
            this.pictarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictarget.TabIndex = 7;
            this.pictarget.TabStop = false;
            // 
            // ButtonClick1
            // 
            this.ButtonClick1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonClick1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClick1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ButtonClick1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonClick1.Location = new System.Drawing.Point(38, 511);
            this.ButtonClick1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonClick1.Name = "ButtonClick1";
            this.ButtonClick1.Size = new System.Drawing.Size(567, 59);
            this.ButtonClick1.TabIndex = 6;
            this.ButtonClick1.Text = "Convert image to text";
            this.ButtonClick1.UseVisualStyleBackColor = false;
            this.ButtonClick1.Click += new System.EventHandler(this.ButtonClick1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(640, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(489, 606);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(38, 578);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ocr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.pictarget);
            this.Controls.Add(this.ButtonClick1);
            this.Controls.Add(this.textBox1);
            this.Name = "ocr";
            this.Text = "ocr";
            this.Load += new System.EventHandler(this.ocr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.PictureBox pictarget;
        private System.Windows.Forms.Button ButtonClick1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}