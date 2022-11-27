namespace SMS
{
    partial class Menu
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
            this.btnAddstd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVwCrs = new System.Windows.Forms.Button();
            this.btnAdCrs = new System.Windows.Forms.Button();
            this.btnVwStd = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucShwCrs1 = new SMS.UcShwCrs();
            this.ucAdCrs1 = new SMS.UcAdCrs();
            this.ucAddStd1 = new SMS.UcAddStd();
            this.ucShwStd1 = new SMS.UcShwStd();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddstd
            // 
            this.btnAddstd.Location = new System.Drawing.Point(12, 47);
            this.btnAddstd.Name = "btnAddstd";
            this.btnAddstd.Size = new System.Drawing.Size(110, 46);
            this.btnAddstd.TabIndex = 0;
            this.btnAddstd.Text = "Add Student";
            this.btnAddstd.UseVisualStyleBackColor = true;
            this.btnAddstd.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucShwCrs1);
            this.panel1.Controls.Add(this.ucAdCrs1);
            this.panel1.Controls.Add(this.ucAddStd1);
            this.panel1.Controls.Add(this.ucShwStd1);
            this.panel1.Location = new System.Drawing.Point(153, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 449);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 65);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Management System";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnVwCrs);
            this.panel3.Controls.Add(this.btnAdCrs);
            this.panel3.Controls.Add(this.btnVwStd);
            this.panel3.Controls.Add(this.btnAddstd);
            this.panel3.Location = new System.Drawing.Point(12, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 442);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnVwCrs
            // 
            this.btnVwCrs.Location = new System.Drawing.Point(12, 199);
            this.btnVwCrs.Name = "btnVwCrs";
            this.btnVwCrs.Size = new System.Drawing.Size(110, 42);
            this.btnVwCrs.TabIndex = 3;
            this.btnVwCrs.Text = "View Courses";
            this.btnVwCrs.UseVisualStyleBackColor = true;
            this.btnVwCrs.Click += new System.EventHandler(this.btnVwCrs_Click);
            // 
            // btnAdCrs
            // 
            this.btnAdCrs.Location = new System.Drawing.Point(12, 148);
            this.btnAdCrs.Name = "btnAdCrs";
            this.btnAdCrs.Size = new System.Drawing.Size(110, 45);
            this.btnAdCrs.TabIndex = 2;
            this.btnAdCrs.Text = "Add Courses";
            this.btnAdCrs.UseVisualStyleBackColor = true;
            this.btnAdCrs.Click += new System.EventHandler(this.btnAdCrs_Click);
            // 
            // btnVwStd
            // 
            this.btnVwStd.Location = new System.Drawing.Point(12, 99);
            this.btnVwStd.Name = "btnVwStd";
            this.btnVwStd.Size = new System.Drawing.Size(110, 43);
            this.btnVwStd.TabIndex = 1;
            this.btnVwStd.Text = "View Student";
            this.btnVwStd.UseVisualStyleBackColor = true;
            this.btnVwStd.Click += new System.EventHandler(this.btnVwStd_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::SMS.Properties.Resources.pixel_cells_g47183066f_1280;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Location = new System.Drawing.Point(153, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(695, 444);
            this.panel4.TabIndex = 4;
            // 
            // ucShwCrs1
            // 
            this.ucShwCrs1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ucShwCrs1.Location = new System.Drawing.Point(-1, 2);
            this.ucShwCrs1.Name = "ucShwCrs1";
            this.ucShwCrs1.Size = new System.Drawing.Size(700, 446);
            this.ucShwCrs1.TabIndex = 3;
            // 
            // ucAdCrs1
            // 
            this.ucAdCrs1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucAdCrs1.Location = new System.Drawing.Point(-1, 4);
            this.ucAdCrs1.Name = "ucAdCrs1";
            this.ucAdCrs1.Size = new System.Drawing.Size(698, 442);
            this.ucAdCrs1.TabIndex = 2;
            // 
            // ucAddStd1
            // 
            this.ucAddStd1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ucAddStd1.Location = new System.Drawing.Point(2, 2);
            this.ucAddStd1.Name = "ucAddStd1";
            this.ucAddStd1.Size = new System.Drawing.Size(696, 443);
            this.ucAddStd1.TabIndex = 1;
            // 
            // ucShwStd1
            // 
            this.ucShwStd1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ucShwStd1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ucShwStd1.Location = new System.Drawing.Point(3, 3);
            this.ucShwStd1.Name = "ucShwStd1";
            this.ucShwStd1.Size = new System.Drawing.Size(696, 443);
            this.ucShwStd1.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 596);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddstd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVwCrs;
        private System.Windows.Forms.Button btnAdCrs;
        private System.Windows.Forms.Button btnVwStd;
        private UcShwStd ucShwStd1;
        private UcAddStd ucAddStd1;
        private UcAdCrs ucAdCrs1;
        private UcShwCrs ucShwCrs1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
    }
}