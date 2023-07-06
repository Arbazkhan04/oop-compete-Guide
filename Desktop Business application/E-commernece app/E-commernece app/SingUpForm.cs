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
    public partial class SingUpForm : Form
    {
        private List<string> role = new List<string>();

        public SingUpForm()
        {
            InitializeComponent();
            populateComboBox();
        }
        private void populateComboBox()
        {
            role.Add("admin");
            role.Add("user");
            roleComboxBox.DataSource = role;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*  string name = txtName.Text;
             string password = txtPassword.Text;
             string role = roleComboxBox.Text;
             MessageBox.Show(name + password + role);
             SingUp user = new SingUp(name, password, role);
             if(role=="admin")
             {

             }
             SingUpDL.adddUSerIntoUserLsit(user);*/

            SingUp user = getUserData();
            if (user != null)
            {
                SingUpDL.adddUSerIntoUserLsit(user);
                SingUpDL.storeLoginDataIntoTheFile();//store data into file
                MessageBox.Show("User Registered Successfully");
            }
            else
            {
                MessageBox.Show("Provide valid Data");
            }


        }

        private SingUp getUserData()
        {
            string name = txtName.Text;
            string password = txtPassword.Text;
            string role = roleComboxBox.Text;

            if (role == "admin")
            {

                SingUp admin = new SingUp(name, password, role);
                if (admin.setName(name) && admin.setPassword(password) && admin.setRole(role))
                {

                    if (SingUpDL.isAdminAlreadyResitered(admin))
                    {
                        return null;
                    }

                    return admin;
                }
                return null;
            }

            SingUp user = new SingUp(name, password);
            if (user.setName(name) && user.setPassword(password))
            {
                return user;
            }
            return null;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
            this.Hide();
        }
    }
}
