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
    public partial class updateProductForm : Form
    {
        public updateProductForm()
        {
            InitializeComponent();
        }

        private void pDataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateProductForm_Load(object sender, EventArgs e)
        {
            
            if(ProductDL.laodProductDataFromFile())
            {
                MessageBox.Show("Data loaded successfully");
            }

            pDataGV.Columns.Add("Product Name", "Product Name");

            pDataGV.Columns["Product Name"].Width = 200;

            pDataGV.Columns.Add("Product Price", "Product Price");

            pDataGV.Columns["Product Price"].Width = 200;

            pDataGV.Columns.Add("Product Quantity", "Product Quantity");
            pDataGV.Columns["Product Quantity"].Width = 200;

            pDataGV.Columns.Add("Product Catagory", "Product Catagory");
            pDataGV.Columns["Product Catagory"].Width = 200;

            pDataGV.Columns.Add("Product Tax", "Product Tax");
            pDataGV.Columns["Product Tax"].Width = 200;

            foreach (Product product in AdminDL.productList)
            {

                DataGridViewRow row = new DataGridViewRow();


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
                nameCell4.Value = product.catagory;
                row.Cells.Add(nameCell4);

                DataGridViewCell nameCell5 = new DataGridViewTextBoxCell();
                nameCell5.Value = product.taxPerProduct;
                row.Cells.Add(nameCell5);

                pDataGV.Rows.Add(row);


            }
            pDataGV.ReadOnly = true;

        }
    }
}
