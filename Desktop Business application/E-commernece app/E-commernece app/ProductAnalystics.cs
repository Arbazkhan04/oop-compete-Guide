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
    public partial class ProductAnalystics : Form
    {
        int index = 0;
        public ProductAnalystics()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form form = new AdminModule();
            form.Show();
            this.Hide();
        }

        private void ProductAnalystics_Load(object sender, EventArgs e)
        {
            List<Product> topThreeProduct = UserDL.getTopThreeSoldProduct();
            if (topThreeProduct == null)
            {
                MessageBox.Show("Due to the less data We can't commpare");
            }
            else
            {
                for (int i = 0; i < topThreeProduct.Count; i++)
                {
                    if (i == 3)
                    {
                        break;
                    }
                    if (i == 0)
                    {
                        label1.Text = topThreeProduct[i].getProductName();
                        label2.Text = topThreeProduct[i + 1].getProductName();
                        label3.Text = topThreeProduct[i].getProductName();

                    }

                }
            }

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

            foreach (Product product in UserDL.userPurchasedProductList)
            {
                if(index==3)
                {
                    break;
                }

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

                pDataGV.Rows.Add(row);

                index++;
            }
            pDataGV.ReadOnly = true;
        }
    }
}
