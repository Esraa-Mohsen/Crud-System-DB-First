namespace taske55
{
    partial class crud_topic
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
            this.text_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_topic = new System.Windows.Forms.DataGridView();
            this.btn_course = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_topic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(435, 138);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(333, 138);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(242, 138);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(242, 36);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(194, 23);
            this.text_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Topic_Name";
            // 
            // DGV_topic
            // 
            this.DGV_topic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_topic.Location = new System.Drawing.Point(242, 204);
            this.DGV_topic.Name = "DGV_topic";
            this.DGV_topic.RowTemplate.Height = 25;
            this.DGV_topic.Size = new System.Drawing.Size(252, 234);
            this.DGV_topic.TabIndex = 5;
            this.DGV_topic.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_topic_RowHeaderMouseDoubleClick);
            // 
            // btn_course
            // 
            this.btn_course.Location = new System.Drawing.Point(637, 336);
            this.btn_course.Name = "btn_course";
            this.btn_course.Size = new System.Drawing.Size(108, 39);
            this.btn_course.TabIndex = 6;
            this.btn_course.Text = "go to courses";
            this.btn_course.UseVisualStyleBackColor = true;
            this.btn_course.Click += new System.EventHandler(this.btn_course_Click);
            // 
            // crud_topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_course);
            this.Controls.Add(this.DGV_topic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_delete);
            this.Name = "crud_topic";
            this.Text = "crud_topic";
            this.Load += new System.EventHandler(this.Topic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_topic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_delete;
        private Button btn_add;
        private Button btn_update;
        private TextBox text_name;
        private Label label1;
        private DataGridView DGV_topic;
        private Button btn_course;
    }
}