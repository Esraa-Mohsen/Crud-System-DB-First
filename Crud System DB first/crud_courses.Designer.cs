namespace taske55
{
    partial class crud_courses
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_evaluation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_courseName = new System.Windows.Forms.ComboBox();
            this.DGV_courses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(523, 156);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(418, 156);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(321, 156);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course_Evaluation";
            // 
            // text_evaluation
            // 
            this.text_evaluation.Location = new System.Drawing.Point(352, 19);
            this.text_evaluation.Name = "text_evaluation";
            this.text_evaluation.Size = new System.Drawing.Size(154, 23);
            this.text_evaluation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Course_Name";
            // 
            // CB_courseName
            // 
            this.CB_courseName.FormattingEnabled = true;
            this.CB_courseName.Location = new System.Drawing.Point(355, 65);
            this.CB_courseName.Name = "CB_courseName";
            this.CB_courseName.Size = new System.Drawing.Size(151, 23);
            this.CB_courseName.TabIndex = 6;
            // 
            // DGV_courses
            // 
            this.DGV_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_courses.Location = new System.Drawing.Point(188, 246);
            this.DGV_courses.Name = "DGV_courses";
            this.DGV_courses.RowTemplate.Height = 25;
            this.DGV_courses.Size = new System.Drawing.Size(410, 137);
            this.DGV_courses.TabIndex = 7;
            this.DGV_courses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_courses_CellContentClick);
            this.DGV_courses.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_courses_RowHeaderMouseDoubleClick);
            // 
            // crud_courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_courses);
            this.Controls.Add(this.CB_courseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_evaluation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Name = "crud_courses";
            this.Text = "crud_courses";
            this.Load += new System.EventHandler(this.crud_courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_delete;
        private Button btn_add;
        private Button btn_update;
        private Label label1;
        private TextBox text_evaluation;
        private Label label2;
        private ComboBox CB_courseName;
        private DataGridView DGV_courses;
    }
}