using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taske55.Models;
using Microsoft.EntityFrameworkCore;


namespace taske55
{
    public partial class crud_topic : Form
    {
        int cId;
        //crud_courses c = new crud_courses();

        ITIContext DB;
        public crud_topic(int cId)
        {
            InitializeComponent();
            DB = new ITIContext();
            this.cId = cId;
        }

        private void Topic_Load(object sender, EventArgs e)
        {
            DGV_topic.DataSource = DB.Topics.ToList();
            btn_delete.Visible = false;
            btn_update.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Topic top = new Topic()
            {
                Top_Name = text_name.Text
            };

            DB.Add(top);
            DB.SaveChanges();

            DGV_topic.DataSource = DB.Topics.ToList();

            text_name.Text = "";
        }

        int id;
        private void DGV_topic_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)DGV_topic.SelectedRows[0].Cells[0].Value;

            Topic top = DB.Topics.Where(t => t.Top_Id== id).SingleOrDefault();
            text_name.Text = top.Top_Name;

            btn_add.Visible= false;
            btn_delete.Visible=true;
            btn_update.Visible = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Topic top = DB.Topics.Where(t => t.Top_Id == id).SingleOrDefault();

            top.Top_Name = text_name.Text;

            DB.SaveChanges();

            text_name.Text = "";

            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;


            DGV_topic.DataSource = DB.Topics.ToList();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("sure to delete this Course?", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                Topic top = DB.Topics.Where(t => t.Top_Id == id).SingleOrDefault();

                 DB.Remove(top);
                 DB.SaveChanges();

                 btn_add.Visible = true;
                 btn_update.Visible = false;
                 btn_delete.Visible = false;

                 text_name.Text = "";

                 DGV_topic.DataSource = DB.Topics.ToList();

            }

        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            crud_courses c = new crud_courses(this.cId);
            c.Show();
           

           
        }
    }
}
