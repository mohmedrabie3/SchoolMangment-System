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
    public partial class Form2 : Form
    {
        Model1 db = new Model1();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User uss = new User();
            uss.ID = txtid.Text;
            uss.Name = txtname.Text;
            uss.PassWord = int.Parse(txtpass.Text);
            uss.Phone = int.Parse(txtphone.Text);
            List<User> u = db.Users.ToList();
            foreach (var item in u)
            {
                if (item.ID == txtid.Text) 
                {
                    MessageBox.Show("ID is exists");
                }
            }
            
                db.Users.Add(uss);
                db.SaveChanges();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Form2 f2 = new Form2();
            f2.Hide();
        }
    }
}
