
namespace school
{
    partial class Form1
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
            this.Name = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.signUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(207, 116);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(86, 31);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(154, 166);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(139, 31);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "PassWord";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(317, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 38);
            this.txtName.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(317, 233);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(129, 46);
            this.btn.TabIndex = 3;
            this.btn.Text = "Sign in";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signUpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // signUpToolStripMenuItem
            // 
            this.signUpToolStripMenuItem.Name = "signUpToolStripMenuItem";
            this.signUpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.signUpToolStripMenuItem.Text = "Sign Up";
            this.signUpToolStripMenuItem.Click += new System.EventHandler(this.signUpToolStripMenuItem_Click);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(317, 166);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(231, 38);
            this.txtpass.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem signUpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtpass;
    }
}

