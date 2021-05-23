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
    public partial class Form5 : Form
    {
        Model1 db;
        public Form5()
        {
            db = new Model1();
            InitializeComponent();
            dataGridView1.DataSource = db.Teachers.Select(n => new { ID = n.ID, Name = n.Name, Age = n.Age, Address = n.Address, GraduationYear = n.Graduation_Year }).ToList();
        }
        public void show()
        {
            dataGridView1.DataSource = db.Teachers.Select(n => new { ID = n.ID, Name = n.Name, Age = n.Age, Address = n.Address, GraduationYear = n.Graduation_Year }).ToList();

        }
        public void clear() 
        {
            txtage.Text = txtcity.Text = txtgradYear.Text = txtid.Text = txtname.Text = "";

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.ID = int.Parse(txtid.Text);
            t.Name = txtname.Text;
            t.Age = int.Parse(txtage.Text);
            t.Address = txtcity.Text;
            t.Graduation_Year = int.Parse(txtgradYear.Text);
            db.Teachers.Add(t);
            db.SaveChanges();
            clear();
            show();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int) dataGridView1.SelectedRows[0].Cells[0].Value;
            Teacher t = db.Teachers.Where(n => n.ID == id).FirstOrDefault();
            txtid.Text = t.ID.ToString();
            txtid.Enabled = false;
            txtage.Text = t.Age.ToString();
            txtcity.Text = t.Address;
            txtgradYear.Text = t.Graduation_Year.ToString();
            txtname.Text = t.Name;
        }

        private void btnedite_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtid.Text);
            Teacher t = db.Teachers.Where(n => n.ID == id).SingleOrDefault();
            t.Name = txtname.Text;
            t.Age = int.Parse(txtage.Text);
            t.Address = txtcity.Text;
            t.Graduation_Year = int.Parse(txtgradYear.Text);
            db.SaveChanges();
            show();
            clear();
            txtid.Enabled = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            Teacher t = db.Teachers.Where(n => n.ID == id).FirstOrDefault();
            db.Teachers.Remove(t);
            db.SaveChanges();
            show();
            clear();
            txtid.Enabled = true;

        }
    }
}
