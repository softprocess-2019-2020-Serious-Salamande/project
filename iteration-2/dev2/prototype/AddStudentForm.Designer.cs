namespace prototype
{
    partial class AddStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.backB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.universityTB = new System.Windows.Forms.TextBox();
            this.facultyNumberTB = new System.Windows.Forms.TextBox();
            this.saveB = new System.Windows.Forms.Button();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(282, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "ERDb";
            // 
            // backB
            // 
            this.backB.Location = new System.Drawing.Point(65, 90);
            this.backB.Name = "backB";
            this.backB.Size = new System.Drawing.Size(75, 23);
            this.backB.TabIndex = 1;
            this.backB.Text = "BACK";
            this.backB.UseVisualStyleBackColor = true;
            this.backB.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(82, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(308, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(567, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(82, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(324, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "University";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(545, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Faculty Number";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(40, 227);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(176, 23);
            this.firstNameTB.TabIndex = 9;
            // 
            // middleNameTB
            // 
            this.middleNameTB.Location = new System.Drawing.Point(282, 227);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(176, 23);
            this.middleNameTB.TabIndex = 10;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(533, 227);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(176, 23);
            this.lastNameTB.TabIndex = 11;
            this.lastNameTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // countryTB
            // 
            this.countryTB.Location = new System.Drawing.Point(40, 329);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(176, 23);
            this.countryTB.TabIndex = 12;
            // 
            // universityTB
            // 
            this.universityTB.Location = new System.Drawing.Point(282, 329);
            this.universityTB.Name = "universityTB";
            this.universityTB.Size = new System.Drawing.Size(176, 23);
            this.universityTB.TabIndex = 13;
            // 
            // facultyNumberTB
            // 
            this.facultyNumberTB.Location = new System.Drawing.Point(533, 329);
            this.facultyNumberTB.Name = "facultyNumberTB";
            this.facultyNumberTB.Size = new System.Drawing.Size(176, 23);
            this.facultyNumberTB.TabIndex = 15;
            // 
            // saveB
            // 
            this.saveB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveB.Location = new System.Drawing.Point(297, 422);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(137, 64);
            this.saveB.TabIndex = 16;
            this.saveB.Text = "SAVE";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 563);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.facultyNumberTB);
            this.Controls.Add(this.universityTB);
            this.Controls.Add(this.countryTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backB);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox middleNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.TextBox universityTB;
        private System.Windows.Forms.TextBox facultyNumberTB;
        private System.Windows.Forms.Button saveB;
    }
}