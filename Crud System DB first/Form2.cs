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
    public partial class Form2 : Form
    {
        

        ITIContext DB;
        public Form2()
        {
            InitializeComponent();
            DB = new ITIContext();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        int id;
        private void btn_login_Click(object sender, EventArgs e)
        {

            Instructor inst = DB.Instructors.Where(i => i.Email == text_mail.Text && i.password == text_password.Text).SingleOrDefault();
            id = inst.Ins_Id;
            if(inst != null)
            {
                crud_topic t = new crud_topic(id);
                t.Show();
               

            }
            else
            {
                MessageBox.Show("Invalid Data");
            }

        }
    }
}
