using taske55.Models;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace taske55
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();

        ITIContext DB;
        public Form1()
        {
            InitializeComponent();
            DB= new ITIContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataI.DataSource= DB.Instructors.ToList();
            CB_dept.DataSource= DB.Departments.ToList();
            CB_dept.DisplayMember = "Dept_Name";
            CB_dept.ValueMember = "Dept_Id";


           CB_degree.DataSource = DB.Instructors.Distinct().ToList();
           CB_degree.DisplayMember = "Ins_Degree";
           CB_degree.ValueMember = "Ins_Degree";

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Instructor i = new Instructor()
            {
                Ins_Name = text_name.Text,
                Ins_Degree = CB_degree.SelectedValue.ToString(),
                Salary = int.Parse(text_salary.Text),
                Dept_Id = (int)CB_dept.SelectedValue,
                Email = text_email.Text,
                password = text_pass.Text
            };

            DB.Instructors.Add(i);
            DB.SaveChanges();
            MessageBox.Show("Registered");

            text_email.Text = text_name.Text = text_pass.Text = text_salary.Text = "";

            if (f2 == null)
            {
                f2 = new Form2();
                f2.Show();
            }
            else
            {
                f2.Show();
                f2.Focus();
            }

        }
    }
}