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
    public partial class UserModule : Form
    {
        userLogin user;
        public UserModule()
        {
            InitializeComponent();
        }
        public UserModule(userLogin user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void UserModule_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserViewProductForm form = new UserViewProductForm();
            form.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buyProductForm form = new buyProductForm();
            form.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            filterProductForm form = new filterProductForm();
            form.Show();
            this.Hide();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewCartForm form = new ViewCartForm();
            form.Show();
            this.Hide();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userTrendingProduct form = new userTrendingProduct();
            form.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            isValidCrendentialsForUsers form = new isValidCrendentialsForUsers();
            form.Show();
            this.Hide();

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < SingUpDL.userList.Count; i++)
            {
                SingUp user1 = SingUpDL.userList[i];
                if (user1.getName() == user.name && user1.getPassword() == user.pasword && user1.getRole() == user.role)
                {
                    SingUpDL.userList.RemoveAt(i);
                    SingUpDL.storeLoginDataIntoTheFile();
                    MessageBox.Show("Account is deletd");
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
            }
        }
    }
}
