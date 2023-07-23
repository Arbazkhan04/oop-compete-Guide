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
    public partial class AdminEditProfileSetting : Form
    {
        private List<string> role = new List<string>();
        userLogin previousUser;
        public AdminEditProfileSetting(userLogin previousUser)
        {
            InitializeComponent();
            populateComboBox();
            this.previousUser = previousUser;
        }


        private void populateComboBox()
        {
            role.Add("admin");
            role.Add("user");
            cbxUserRole.DataSource = role;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            isValidCrendentialsForUsers form = new isValidCrendentialsForUsers();
            userLogin latestUser = getUpdatedUserVerificationData();
            if (SingUpDL.updateTheUser(previousUser, latestUser))
            {
                MessageBox.Show("Crendentaisl updatd successfuly");
                SingUpDL.storeLoginDataIntoTheFile();
            }
            else
            {
                MessageBox.Show("Crendentaisl are not updatd successfuly");
            }

        }

        private userLogin getUpdatedUserVerificationData()
        {
            string name = txtUserName.Text;
            string password = txtUserPassword.Text;
            string role = cbxUserRole.Text;
            userLogin user = new userLogin(name, password, role);
            return user;
        }

        private void AdminEditProfileSetting_Load(object sender, EventArgs e)
        {

        }

        private void updateGrpBox_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form = new AdminModule();
            form.Show();
            this.Hide();
        }
    }
}
