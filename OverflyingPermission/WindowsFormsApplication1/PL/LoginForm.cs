using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL
{
    public partial class LoginForm : Form
    {
        BL.Login_Class log = new BL.Login_Class();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(txt_ID.Text, txt_password.Text);
            if (Dt.Rows.Count > 0)
            {
                if (Dt.Rows[0][2].ToString() == "Manager")
                {
                    MainForm.getMainForm.PermissionsToolStripMenuItem.Enabled = true;
                    MainForm.getMainForm.UsersToolStripMenuItem.Enabled = true;
                    MainForm.getMainForm.BackUsToolStripMenuItem.Enabled = true;
                    MainForm.getMainForm.RestoreToolStripMenuItem.Enabled = true;
                    MainForm.getMainForm.UsersToolStripMenuItem.Visible = true;
                    this.Close();

                }
                else
                    if (Dt.Rows[0][2].ToString() == "Employee")
                    {
                        MainForm.getMainForm.PermissionsToolStripMenuItem.Enabled = true;
                        MainForm.getMainForm.UsersToolStripMenuItem.Enabled = true;
                        MainForm.getMainForm.BackUsToolStripMenuItem.Enabled = true;
                        MainForm.getMainForm.RestoreToolStripMenuItem.Enabled = true;
                        MainForm.getMainForm.UsersToolStripMenuItem.Visible = false;
                        this.Close();

                    }      
            }
            else
            {
                MessageBox.Show("Login failed !");
            }
        }
    }
}
