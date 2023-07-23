using Business_Application.BL;
using Business_Application.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_commernece_app
{
    public partial class UserListForm : Form
    {
        int index = 0;
        public UserListForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            uDataGV.Columns.Add("User Index", "User Index");

            uDataGV.Columns["User Index"].Width = 80;

            uDataGV.Columns.Add("User Name", "User Name");

            uDataGV.Columns["User Name"].Width = 80;

            uDataGV.Columns.Add("User Password", "User Password");

            uDataGV.Columns["User Password"].Width = 80;

            uDataGV.Columns.Add("User Role", "User Role");
            uDataGV.Columns["User Role"].Width = 80;



            foreach (var user in SingUpDL.userList)
            {


                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell indexCell = new DataGridViewTextBoxCell();
                indexCell.Value = index;
                row.Cells.Add(indexCell);

                DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                nameCell.Value = user.getName();
                row.Cells.Add(nameCell);

                DataGridViewCell nameCell2 = new DataGridViewTextBoxCell();
                nameCell2.Value = user.getPassword();
                row.Cells.Add(nameCell2);

                DataGridViewCell nameCell3 = new DataGridViewTextBoxCell();
                nameCell3.Value = user.getRole();
                row.Cells.Add(nameCell3);
                uDataGV.Rows.Add(row);

                index++;
            }
            uDataGV.ReadOnly = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form = new AdminModule();
            form.Show();
            this.Hide();
        }
    }
}
