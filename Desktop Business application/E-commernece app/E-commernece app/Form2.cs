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
    public partial class Form2 : Form
    {
        private List<string> role = new List<string>();

        public Form2()
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
            string name = txtName.Text;
            string password = txtPassword.Text;
            string role = roleComboxBox.Text;
            MessageBox.Show(name + password + role);
            SingUp user = new SingUp(name, password, role);
            SingUpDL.adddUSerIntoUserLsit(user);
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
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
