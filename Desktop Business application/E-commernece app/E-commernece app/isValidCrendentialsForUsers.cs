using Business_Application.BL;
using Business_Application.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commernece_app
{
    public partial class isValidCrendentialsForUsers : Form
    {
        private List<string> role = new List<string>();
        public isValidCrendentialsForUsers()
        {
            InitializeComponent();
            populateRoleIntoComboBox();
        }

        private void populateRoleIntoComboBox()
        {
            role.Add("admin");
            role.Add("user");
            cbxUserRole.DataSource = role;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void updateGrpBox_Enter(object sender, EventArgs e)
        {

        }

        public userLogin getUserVerificationData()
        {
            string name = txtUserName.Text;
            string password = txtUserPassword.Text;
            string role = cbxUserRole.Text;
            userLogin user = new userLogin(name, password, role);
            return user;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            userLogin user = getUserVerificationData();

            if (SingUpDL.userExist(user))
            {
                MessageBox.Show("Now update your crednetials");
                if(user.role=="user")
                {
                    editUserCredentials user1 = new editUserCredentials(user);
                    user1.Show();
                    this.Hide();
                }
                else
                {
                AdminEditProfileSetting form = new AdminEditProfileSetting(user);
                form.Show();
                this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Enter correct Crendentials");
            }

        }

        private void isValidCrendentialsForUsers_Load(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
