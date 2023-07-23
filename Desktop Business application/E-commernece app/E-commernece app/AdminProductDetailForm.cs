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
    public partial class AdminProductDetailForm : Form
    {
        private List<string> catagory = new List<string>();
        int index = 0;
        public AdminProductDetailForm()
        {
            InitializeComponent();
            populateDataIntoComboxBox();
        }

        private void populateDataIntoComboxBox()
        {
            catagory.Add("Mobiles");
            catagory.Add("clothes");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void updateGrpBox_Enter(object sender, EventArgs e)
        {

        }

        private void AdminProductDetailForm_Load(object sender, EventArgs e)
        {
            cbxUpdateProduct.DataSource = catagory;

            pDataGV.Columns.Add("Product Index", "Product Index");

            pDataGV.Columns["Product Index"].Width = 80;

            pDataGV.Columns.Add("Product Name", "Product Name");

            pDataGV.Columns["Product Name"].Width = 80;

            pDataGV.Columns.Add("Product Price", "Product Price");

            pDataGV.Columns["Product Price"].Width = 80;

            pDataGV.Columns.Add("Product Quantity", "Product Quantity");
            pDataGV.Columns["Product Quantity"].Width = 80;

            pDataGV.Columns.Add("Product Catagory", "Product Catagory");
            pDataGV.Columns["Product Catagory"].Width = 80;

            pDataGV.Columns.Add("Product Tax", "Product Tax");
            pDataGV.Columns["Product Tax"].Width = 80;

            pDataGV.Columns.Add("Product Status", "Product Status");
            pDataGV.Columns["Product Status"].Width = 80;

            foreach (Product product in AdminDL.productList)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell indexCell = new DataGridViewTextBoxCell();
                indexCell.Value = index;
                row.Cells.Add(indexCell);

                DataGridViewCell nameCell = new DataGridViewTextBoxCell();
                nameCell.Value = product.getProductName();
                row.Cells.Add(nameCell);

                DataGridViewCell nameCell2 = new DataGridViewTextBoxCell();
                nameCell2.Value = product.getProductPrice();
                row.Cells.Add(nameCell2);

                DataGridViewCell nameCell3 = new DataGridViewTextBoxCell();
                nameCell3.Value = product.getproductQuantity();
                row.Cells.Add(nameCell3);

                DataGridViewCell nameCell4 = new DataGridViewTextBoxCell();
                nameCell4.Value = product.catagory();
                row.Cells.Add(nameCell4);

                DataGridViewCell nameCell5 = new DataGridViewTextBoxCell();
                nameCell5.Value = product.taxPerProduct().ToString();
                row.Cells.Add(nameCell5);

                string productStock = product.getproductQuantity() > 0 ? "In Stock" : "Out of Stock";
                DataGridViewCell nameCell6 = new DataGridViewTextBoxCell();
                nameCell6.Value = productStock;

                row.Cells.Add(nameCell6);
                pDataGV.Rows.Add(row);

                index++;
            }
            pDataGV.ReadOnly = true;
        }


        private Product getProduct()
        {
            string pName = txtUpdatePName.Text;
            int price = int.Parse(txtUpdatedPPrice.Text);
            int quantity = int.Parse(txtUpdatedPquantity.Text);
            string qatagory = cbxUpdateProduct.Text;

            if (qatagory == "Mobiles")
            {
                Mobiles mobile = new Mobiles(pName, price, quantity);
                if (mobile.setProductName(pName) && mobile.setProductPrice(price) && mobile.setProductQunatity(quantity))
                {
                    return mobile;
                }
                return null;
            }
            else if (qatagory == "clothes")
            {
                Clothes cloht = new Clothes(pName, price, quantity);
                if (cloht.setProductName(pName) && cloht.setProductPrice(price) && cloht.setProductQunatity(quantity))
                {
                    return cloht;
                }
                return null;

            }
            return null;
        }

        private int indexOfItem()
        {
            int index = int.Parse(txtPIndex.Text);
            return index;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indesIsValid = indexOfItem();
            Product product = getProduct();
            if (product != null)
            {
                if (ProductDL.checkProductExist(indesIsValid))
                {
                    ProductDL.upDateProduct(product, indesIsValid);
                    ProductDL.storeProductDataIntoTheFile();
                    MessageBox.Show("Product updated successfully ");
                }
                else
                {
                    MessageBox.Show("Product does not exist ");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form = new AdminModule();
            form.Show();
            this.Hide();
        }
    }
}
