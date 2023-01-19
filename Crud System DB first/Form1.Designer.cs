namespace taske55
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_salary = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_degree = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_dept = new System.Windows.Forms.ComboBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_salary
            // 
            this.text_salary.Location = new System.Drawing.Point(312, 78);
            this.text_salary.Name = "text_salary";
            this.text_salary.Size = new System.Drawing.Size(153, 23);
            this.text_salary.TabIndex = 0;
            // 
            // text_email
            // 
            this.text_email.Location = new System.Drawing.Point(312, 124);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(153, 23);
            this.text_email.TabIndex = 1;
            // 
            // text_pass
            // 
            this.text_pass.Location = new System.Drawing.Point(312, 162);
            this.text_pass.Name = "text_pass";
            this.text_pass.Size = new System.Drawing.Size(153, 23);
            this.text_pass.TabIndex = 2;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(312, 35);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(153, 23);
            this.text_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Degree";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password";
            // 
            // CB_degree
            // 
            this.CB_degree.FormattingEnabled = true;
            this.CB_degree.Location = new System.Drawing.Point(310, 204);
            this.CB_degree.Name = "CB_degree";
            this.CB_degree.Size = new System.Drawing.Size(153, 23);
            this.CB_degree.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Department";
            // 
            // CB_dept
            // 
            this.CB_dept.FormattingEnabled = true;
            this.CB_dept.Location = new System.Drawing.Point(310, 249);
            this.CB_dept.Name = "CB_dept";
            this.CB_dept.Size = new System.Drawing.Size(151, 23);
            this.CB_dept.TabIndex = 11;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(334, 320);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(84, 26);
            this.btn_register.TabIndex = 12;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.CB_dept);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CB_degree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.text_salary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text_salary;
        private TextBox text_email;
        private TextBox text_pass;
        private TextBox text_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox CB_degree;
        private Label label6;
        private ComboBox CB_dept;
        private Button btn_register;
    }
}