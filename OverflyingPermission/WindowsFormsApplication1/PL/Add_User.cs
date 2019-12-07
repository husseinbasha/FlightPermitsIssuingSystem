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
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty || txtPWD.Text == string.Empty
              || txtFullName.Text == string.Empty || txtPWDConfirm.Text == string.Empty)
            {

                MessageBox.Show("Please Enter All The Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
               
            }

            if (txtPWD.Text != txtPWDConfirm.Text)
            {
                MessageBox.Show("Please Passwords are not Matched", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSave.Text == "Add_New_User")
            {
                BL.Login_Class login = new BL.Login_Class();
                login.Add_User(txtID.Text, txtFullName.Text, txtPWD.Text, cmbType.Text);
                MessageBox.Show("User has successfully added ^-^", "Add New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }

            if (btnSave.Text == "Update_User")
            {
                BL.Login_Class login = new BL.Login_Class();
                login.Edit_User(txtID.Text, txtFullName.Text, txtPWD.Text, cmbType.Text);
                MessageBox.Show("User has  successfully updated ^-^", "Update_User", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            txtID.Clear();
            txtFullName.Clear();
            txtPWD.Clear();
            txtPWDConfirm.Clear();
            txtID.Focus();
            cmbType.Text = "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPWD_Validated(object sender, EventArgs e)
        {
            /*if (txtPWD.Text != txtPWDConfirm.Text)
            {
                MessageBox.Show("Please Passwords are not Matched", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
              */
        }
    }
}
