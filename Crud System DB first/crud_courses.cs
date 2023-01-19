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
using System.Collections.Immutable;

namespace taske55
{
    public partial class crud_courses : Form
    {
        int ci_id;
        ITIContext DB;
        public crud_courses(int ci_id)
        {
            InitializeComponent();

            DB = new ITIContext();
            this.ci_id = ci_id;
        }

        private void crud_courses_Load(object sender, EventArgs e)
        {
            DGV_courses.DataSource = DB.Ins_Courses.Include(t => t.Crs).Include(s=>s.Ins).Where(i=>i.Ins_Id==this.ci_id).Select(c => new { ins_id = c.Ins.Ins_Id,c.Crs_Id, Course_Name = c.Crs.Crs_Name, c.Evaluation }).ToList();

            CB_courseName.DataSource = DB.Courses.ToList();
            CB_courseName.DisplayMember = "Crs_Name";
            CB_courseName.ValueMember = "Crs_Id";

            btn_update.Visible = false;
            btn_delete.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Ins_Course i = new Ins_Course()
            {
                
                Crs_Id = (int)CB_courseName.SelectedValue,
                Evaluation  = text_evaluation.Text,
                Ins_Id = ci_id

            };

            DB.Ins_Courses.Add(i);
            DB.SaveChanges();
            text_evaluation.Text = "";
            MessageBox.Show("Added");
            DGV_courses.DataSource = DB.Ins_Courses.Where(i => i.Ins_Id == ci_id).Include(t => t.Crs);

            
        }
      
        private void DGV_courses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int i_id;
        int cr_id;
        private void DGV_courses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           i_id = (int)DGV_courses.SelectedRows[0].Cells[0].Value;
           cr_id = (int)DGV_courses.SelectedRows[0].Cells[1].Value;


           Ins_Course s = DB.Ins_Courses.Where(n=>n.Crs_Id == cr_id && n.Ins_Id == i_id).Single();

            text_evaluation.Text = s.Evaluation;
         
            CB_courseName.SelectedValue = s.Crs_Id;

            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            Ins_Course s = DB.Ins_Courses.Where(n => n.Crs_Id == cr_id && n.Ins_Id == i_id).Single();

            s.Evaluation = text_evaluation.Text;
            s.Crs_Id = (int)CB_courseName.SelectedValue;

            //s.Ins_Id = id;
            DB.SaveChanges();

            text_evaluation.Text = "";

            btn_add.Visible = true;
            btn_update.Visible = false;
            btn_delete.Visible = false;


            DGV_courses.DataSource = DB.Ins_Courses.Include(t => t.Crs).Include(s => s.Ins).Where(i => i.Ins_Id == this.ci_id).Select(n => new { ins_id = n.Ins.Ins_Id,n.Crs_Id, Course_Name = n.Crs.Crs_Name, n.Evaluation }).ToList();
        }
        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("delete this course?", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Ins_Course s = DB.Ins_Courses.Where(n => n.Crs_Id == cr_id && n.Ins_Id == i_id).SingleOrDefault();
                DB.Ins_Courses.Remove(s);
                DB.SaveChanges();


                text_evaluation.Text = "";
                btn_add.Visible = true;
                btn_update.Visible = false;
                btn_delete.Visible = false;


                DGV_courses.DataSource = DB.Ins_Courses.Include(t => t.Crs).Include(s => s.Ins).Where(i => i.Ins_Id == this.ci_id).Select(n => new { ins_id = n.Ins.Ins_Id,n.Crs_Id, Course_Name = n.Crs.Crs_Name, n.Evaluation }).ToList();
            }
        }
    }

}
