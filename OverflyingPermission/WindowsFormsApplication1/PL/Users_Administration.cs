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
    public partial class Users_Administration : Form
    {
        BL.Login_Class login = new BL.Login_Class();
        public Users_Administration()
        {
            InitializeComponent();
            this.dgvUsers.DataSource = login.SearchUsers("");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Users_Administration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_User add = new Add_User();
            add.btnSave.Text = "Add_New_User";
            add.ShowDialog();
            this.dgvUsers.DataSource = login.SearchUsers("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_User add = new Add_User();
            add.txtID.Text = dgvUsers.CurrentRow.Cells[0].Value.ToString();
            add.txtFullName.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
            add.txtPWD.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            add.txtPWDConfirm.Text = dgvUsers.CurrentRow.Cells[2].Value.ToString();
            add.cmbType.Text = dgvUsers.CurrentRow.Cells[3].Value.ToString();
            add.btnSave.Text = "Update_User";
            add.ShowDialog();
            this.dgvUsers.DataSource = login.SearchUsers("");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to delete this user", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                login.Delete_User(dgvUsers.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("User has successfully deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvUsers.DataSource = login.SearchUsers("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.dgvUsers.DataSource = login.SearchUsers(txtSearch.Text);
        }
    }
}
