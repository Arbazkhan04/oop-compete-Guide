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
    public partial class editUserCredentials : Form
    {
        private List<string> role = new List<string>();
        userLogin previousUser;
        public editUserCredentials(userLogin user)
        {
            InitializeComponent();
            populateComboBox();
            this.previousUser = user;
        }
        private void populateComboBox()
        {
            role.Add("admin");
            role.Add("user");
            cbxUserRole.DataSource = role;
        }
        private void updateGrpBox_Enter(object sender, EventArgs e)
        {

        }

        private userLogin getUpdatedUserVerificationData()
        {
            string name = txtUserName.Text;
            string password = txtUserPassword.Text;
            string role = cbxUserRole.Text;
            userLogin user = new userLogin(name, password, role);
            return user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // isValidCrendentialsForUsers form = new isValidCrendentialsForUsers();
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

        private void editUserCredentials_Load(object sender, EventArgs e)
        {

        }
    }
}
