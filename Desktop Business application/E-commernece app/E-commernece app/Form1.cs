using Business_Application.BL;
using Business_Application.DL;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace E_commernece_app
{
    public partial class Form1 : Form
    {
        private List<string> role = new List<string>();
        public Form1()
        {
            InitializeComponent();
            populateRoleIntoComboBox();
        }
        private void populateRoleIntoComboBox()
        {
            role.Add("admin");
            role.Add("user");
            txtRole.DataSource = role;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           if (SingUpDL.laodLoginDataFromFile())
            {
                MessageBox.Show("Path Exist");
            }
            else
            {
                MessageBox.Show("Path does not exist ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 forms2 = new Form2();
            forms2.Show();
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
            string name = txtUserName.Text;
            string password = txtUserPassword.Text;
            string role = txtRole.Text;
            userLogin user = new userLogin(name, password, role);
            MessageBox.Show(name + password + role);

            if (SingUpDL.userExist(user))
            {
                if (user.role == "user")
                {
                    // navigate toward user;
                    MessageBox.Show("Regualr User loged in");
                }
                else if (user.role == "admin")
                {
                    MessageBox.Show("Admin User loged in");

                    //navigate toward admin
                }
            }
            else
            {
                MessageBox.Show("Enter correct Crendentials");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 forms2 = new Form2();
            forms2.Show();
            this.Hide();
        }
    }
}