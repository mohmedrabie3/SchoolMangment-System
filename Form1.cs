using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school
{
    public partial class Form1 : Form
    {
         Model1 db = new Model1();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            List<User> us = db.Users.ToList();
            int flag = 0;
            foreach (var item in us)
            {
                if (txtName.Text == item.Name || int.Parse(txtpass.Text) == item.PassWord)
                {
                    Form3 f3 = new Form3();
                    f3.ShowDialog();
                   // Form1 f1 = new Form1();
                    this.Hide();
                    flag = 1;
                }
            }
            if (flag == 0) 
            {
                MessageBox.Show("Password and Name invalid");

            }

        }

        private void signUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            //Form1 f1 = new Form1();
            Hide();
        }
    }
}
