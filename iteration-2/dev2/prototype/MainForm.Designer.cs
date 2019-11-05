namespace prototype
{
    partial class MainForm
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
            this.addStudentB = new System.Windows.Forms.Button();
            this.searchB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            // 
            // addStudentB
            // 
            this.addStudentB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addStudentB.Location = new System.Drawing.Point(276, 233);
            this.addStudentB.Name = "addStudentB";
            this.addStudentB.Size = new System.Drawing.Size(210, 50);
            this.addStudentB.TabIndex = 0;
            this.addStudentB.Text = "ADD STUDENT";
            this.addStudentB.UseVisualStyleBackColor = true;
            this.addStudentB.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchB
            // 
            this.searchB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchB.Location = new System.Drawing.Point(273, 338);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(212, 50);
            this.searchB.TabIndex = 1;
            this.searchB.Text = "SEARCH ";
            this.searchB.UseVisualStyleBackColor = true;
            this.searchB.Click += new System.EventHandler(this.searchB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 71);
            this.label1.TabIndex = 6;
            this.label1.Text = "ERDb";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(285, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 71);
            this.label2.TabIndex = 2;
            this.label2.Text = "ERDb";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(796, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.addStudentB);
            this.Name = "MainForm";
            this.Text = "MainForm";

        }

        #endregion

        private System.Windows.Forms.Button addStudentB;
        private System.Windows.Forms.Button searchB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}