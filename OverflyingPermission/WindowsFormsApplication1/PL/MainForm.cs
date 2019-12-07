using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        private static MainForm frm; // handler
        static void frm_closed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static MainForm getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new MainForm();
                    frm.FormClosed += new FormClosedEventHandler(frm_closed);

                }
                return frm;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.PermissionsToolStripMenuItem.Enabled = false;
            this.UsersToolStripMenuItem.Enabled = false;

            this.BackUsToolStripMenuItem.Enabled = false;
            this.RestoreToolStripMenuItem.Enabled = false;
            


        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.LoginForm login = new PL.LoginForm();
            login.ShowDialog();
        }

        private void إضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Add_User add = new PL.Add_User();
            add.ShowDialog();
        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Users_Administration users = new PL.Users_Administration();
            users.ShowDialog();
        }

        private void getPermissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.Landing_Permits_Form frm = new PL.Landing_Permits_Form();
            frm.ShowDialog();
        }

        private void landingTakeOffPermitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.LandingTakeOffPermitsForm frm = new PL.LandingTakeOffPermitsForm();
            frm.ShowDialog();
        }

        private void overFlyPermitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL.OverFlyPermitForm frm = new PL.OverFlyPermitForm();
            frm.ShowDialog();
        }
    }
}
