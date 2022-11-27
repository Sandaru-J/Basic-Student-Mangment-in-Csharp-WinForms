namespace SMS
{
    partial class UcAdCrs
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
            this.txtCrsCord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCrsDur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCrsName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Cources";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCncl);
            this.panel1.Controls.Add(this.txtCrsCord);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCap);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCrsDur);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCrsName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(71, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 332);
            this.panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(315, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 42);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Course";
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
            // txtCrsCord
            // 
            this.txtCrsCord.Location = new System.Drawing.Point(191, 161);
            this.txtCrsCord.Multiline = true;
            this.txtCrsCord.Name = "txtCrsCord";
            this.txtCrsCord.Size = new System.Drawing.Size(244, 20);
            this.txtCrsCord.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Course Cordinator";
            // 
            // txtCap
            // 
            this.txtCap.Location = new System.Drawing.Point(191, 116);
            this.txtCap.Multiline = true;
            this.txtCap.Name = "txtCap";
            this.txtCap.Size = new System.Drawing.Size(244, 20);
            this.txtCap.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Capacity";
            // 
            // txtCrsDur
            // 
            this.txtCrsDur.Location = new System.Drawing.Point(191, 77);
            this.txtCrsDur.Multiline = true;
            this.txtCrsDur.Name = "txtCrsDur";
            this.txtCrsDur.Size = new System.Drawing.Size(244, 20);
            this.txtCrsDur.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Duration";
            // 
            // txtCrsName
            // 
            this.txtCrsName.Location = new System.Drawing.Point(191, 35);
            this.txtCrsName.Multiline = true;
            this.txtCrsName.Name = "txtCrsName";
            this.txtCrsName.Size = new System.Drawing.Size(244, 20);
            this.txtCrsName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "In Months";
            // 
            // UcAdCrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UcAdCrs";
            this.Size = new System.Drawing.Size(698, 442);
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
        private System.Windows.Forms.TextBox txtCrsCord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCrsDur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCrsName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}
