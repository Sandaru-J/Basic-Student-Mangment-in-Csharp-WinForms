namespace SMS
{
    partial class UcAddStd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCncl = new System.Windows.Forms.Button();
            this.txtCrs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStdname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Students";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCncl);
            this.panel1.Controls.Add(this.txtCrs);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDob);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNic);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtStdname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(78, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 332);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(315, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 42);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCncl
            // 
            this.btnCncl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCncl.Location = new System.Drawing.Point(191, 218);
            this.btnCncl.Name = "btnCncl";
            this.btnCncl.Size = new System.Drawing.Size(118, 42);
            this.btnCncl.TabIndex = 8;
            this.btnCncl.Text = "Cancel";
            this.btnCncl.UseVisualStyleBackColor = true;
            this.btnCncl.Click += new System.EventHandler(this.btnCncl_Click);
            // 
            // txtCrs
            // 
            this.txtCrs.Location = new System.Drawing.Point(191, 161);
            this.txtCrs.Multiline = true;
            this.txtCrs.Name = "txtCrs";
            this.txtCrs.Size = new System.Drawing.Size(244, 20);
            this.txtCrs.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Course";
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(191, 116);
            this.txtDob.Multiline = true;
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(244, 20);
            this.txtDob.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of Birth";
            // 
            // txtNic
            // 
            this.txtNic.Location = new System.Drawing.Point(191, 77);
            this.txtNic.Multiline = true;
            this.txtNic.Name = "txtNic";
            this.txtNic.Size = new System.Drawing.Size(244, 20);
            this.txtNic.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIC";
            // 
            // txtStdname
            // 
            this.txtStdname.Location = new System.Drawing.Point(191, 35);
            this.txtStdname.Multiline = true;
            this.txtStdname.Name = "txtStdname";
            this.txtStdname.Size = new System.Drawing.Size(244, 20);
            this.txtStdname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Name";
            // 
            // UcAddStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UcAddStd";
            this.Size = new System.Drawing.Size(696, 443);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCncl;
        private System.Windows.Forms.TextBox txtCrs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStdname;
        private System.Windows.Forms.Label label2;
    }
}
