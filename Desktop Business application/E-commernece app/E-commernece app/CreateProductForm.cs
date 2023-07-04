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
    public partial class CreateProductForm : Form
    {
        private List<string> catagory = new List<string>();

        public CreateProductForm()
        {
            InitializeComponent();
            populateDataIntoComboxBox();
        }

        private void CreateProductForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = catagory;
        }
        private void populateDataIntoComboxBox()
        {
            catagory.Add("Mobiles");
            catagory.Add("clothes");
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pName = txtPName.Text;
            int price = int.Parse(txtPPrice.Text);
            int quantity = int.Parse(txtPQuantity.Text);
            string qatagory = comboBox1.Text;

            if(qatagory == "Mobiles")
            {
                Mobiles mobile = new Mobiles(pName, price, quantity);
                ProductDL.addProduct(mobile);
            }
            else if(qatagory == "clothes")
            {
                Clothes cloht = new Clothes(pName, price, quantity);
                ProductDL.addProduct(cloht);
            }

        }
    }
}
