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
    public partial class buyProductForm : Form
    {
        int index1 = 0;
        public buyProductForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form = new UserModule();
            form.Show();
            this.Hide();
        }

        private void buyProductForm_Load(object sender, EventArgs e)
        {
            pDataGV.Columns.Add("Product Index", "Product Index");

            pDataGV.Columns["Product Index"].Width = 100;

            pDataGV.Columns.Add("Product Name", "Product Name");

            pDataGV.Columns["Product Name"].Width = 100;

            pDataGV.Columns.Add("Product Price", "Product Price");

            pDataGV.Columns["Product Price"].Width = 100;

            pDataGV.Columns.Add("Product Quantity", "Product Quantity");
            pDataGV.Columns["Product Quantity"].Width = 100;

            pDataGV.Columns.Add("Product Catagory", "Product Catagory");
            pDataGV.Columns["Product Catagory"].Width = 100;

            pDataGV.Columns.Add("Product Tax", "Product Tax");
            pDataGV.Columns["Product Tax"].Width = 100;

            foreach (Product product in AdminDL.productList)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell indexCell = new DataGridViewTextBoxCell();
                indexCell.Value = index1;
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

                pDataGV.Rows.Add(row);
                index1++;
            }
            pDataGV.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = int.Parse(txtPIndex.Text);
            int quantity = int.Parse(txtUpdatedPquantity.Text);
            Product ExistProduct = ProductDL.getProdcutByIndex(index);
            if (ExistProduct != null)
            {
                if (ExistProduct.catagory() == "clothes")
                {
                    Clothes cloth = new Clothes(ExistProduct.getProductName(), ExistProduct.getProductPrice(), quantity);
                    MessageBox.Show("Product Purchased Successfully");
                    UserDL.addPurchasedProduct(cloth);
                    UserDL.storePurchasedProductIntoTheFile();
                }
                else if (ExistProduct.catagory() == "Mobiles")
                {
                    Mobiles moboile = new Mobiles(ExistProduct.getProductName(), ExistProduct.getProductPrice(), quantity);
                    MessageBox.Show("Product Purchased Successfully");
                    UserDL.addPurchasedProduct(moboile);
                    UserDL.storePurchasedProductIntoTheFile();
                }

                //update the product list as well bexause the quantity is deascreing
                ProductDL.updateProductListQuantity(index, quantity);
                ProductDL.storeProductDataIntoTheFile();
            }
            else
            {
                MessageBox.Show("Enter correct index");
            }

        }
    }
}
