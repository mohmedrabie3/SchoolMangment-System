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
    public partial class Form4 : Form
    {
        Model1 db;
        public Form4()
        {
            db = new Model1();
            InitializeComponent();
            dataGridView1.DataSource = db.Subjects.Select(n => new { ID = n.ID , Name = n.Name }).ToList();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                Subject st = new Subject();
                st.ID = int.Parse(txti.Text);
                st.Name = name.Text;
                db.Subjects.Add(st);
                db.SaveChanges();
                dataGridView1.DataSource = db.Subjects.Select(n => new { ID = n.ID, Name = n.Name }).ToList();
                txti.Text = name.Text = "";
            }
            catch 
            {
                MessageBox.Show("ID is inValid", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int) dataGridView1.SelectedRows[0].Cells[0].Value;
            Subject sb = db.Subjects.Where(n => n.ID == id).SingleOrDefault();
            txti.Text = sb.ID.ToString();
            txti.Enabled = false;
            name.Text = sb.Name;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txti.Text);
            Subject sb = db.Subjects.Where(n => n.ID == id).FirstOrDefault();
            sb.ID = int.Parse(txti.Text);
            sb.Name = name.Text;
            db.SaveChanges();
            dataGridView1.DataSource = db.Subjects.Select(n => new { ID = n.ID, Name = n.Name }).ToList();
            txti.Enabled = true;
            txti.Text = name.Text = "";

        }

        private void btnRe_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txti.Text);
            Subject sb = db.Subjects.Where(n => n.ID == id).SingleOrDefault();
            db.Subjects.Remove(sb);
            db.SaveChanges();
            txti.Enabled = true;
            txti.Text = name.Text = "";
            dataGridView1.DataSource = db.Subjects.Select(n => new { ID = n.ID, Name = n.Name }).ToList();

        }
    }
}
