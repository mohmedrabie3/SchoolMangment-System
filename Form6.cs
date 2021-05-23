using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school
{
    public partial class Form6 : Form
    {
        Model1 db;
        public Form6()
        {
            db = new Model1();
            InitializeComponent();
            //dataGridView1.DataSource = db.Students.ToList();
            dataGridView1.DataSource = db.Students.Select(n=> new {id=n.ID , Name =n.Name , Age = n.Age , City = n.City , teacherName=n.Teacher.Name , subjectname =n.Subject.Name }).ToList();
            comteacher.DisplayMember = "name";
            comteacher.ValueMember = "id";
            comteacher.DataSource = db.Teachers.ToList();
            comsub.DisplayMember = "name";
            comsub.ValueMember = "id";
            comsub.DataSource = db.Subjects.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Student st = new Student();

            try
            {
                st.ID = txtid.Text;
                st.Name = txtname.Text;
                st.Age = int.Parse(txtage.Text);
                st.City = txtcity.Text;
                st.SubjectID = (int)comsub.SelectedValue;
                st.TeacherID = (int)comteacher.SelectedValue;
                db.Students.Add(st);
                db.SaveChanges();

            }
            catch (Exception)
            {
                MessageBox.Show(st.ID.ToString());
            

            }
            dataGridView1.DataSource = db.Students.Select(n => new { id = n.ID, Name = n.Name, Age = n.Age, City = n.City, teacherName = n.Teacher.Name, subjectname = n.Subject.Name }).ToList();
            txtage.Text = txtcity.Text = txtid.Text = txtname.Text = "";
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id =  dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Student st = db.Students.Where(n => n.ID == id.ToString()).SingleOrDefault();
            txtage.Text = st.Age.ToString();
            txtname.Text = st.Name;
            txtid.Text = st.ID.ToString();
            txtcity.Text = st.City;
            comsub.SelectedValue = st.SubjectID;
            comteacher.SelectedValue = st.TeacherID;
            txtid.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string id = txtid.Text;
            Student st = db.Students.Where(n => n.ID == id).FirstOrDefault();
            st.Name = txtname.Text;
            st.Age = int.Parse(txtage.Text);
            st.City = txtcity.Text;
            st.SubjectID = (int)comsub.SelectedValue;
            st.TeacherID = (int)comteacher.SelectedValue;
            db.SaveChanges();
            dataGridView1.DataSource = db.Students.Select(n => new { id = n.ID, Name = n.Name, Age = n.Age, City = n.City, teacherName = n.Teacher.Name, subjectname = n.Subject.Name }).ToList();
            txtid.Enabled = true;
            txtage.Text = txtcity.Text = txtid.Text = txtname.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string id = txtid.Text;
            Student st = db.Students.Where(n => n.ID == id).SingleOrDefault();
            db.Students.Remove(st);
            db.SaveChanges();
            dataGridView1.DataSource = db.Students.Select(n => new { id = n.ID, Name = n.Name, Age = n.Age, City = n.City, teacherName = n.Teacher.Name, subjectname = n.Subject.Name }).ToList();
            txtage.Text = txtcity.Text = txtid.Text = txtname.Text = "";
            txtid.Enabled = true;

        }
    }
}
