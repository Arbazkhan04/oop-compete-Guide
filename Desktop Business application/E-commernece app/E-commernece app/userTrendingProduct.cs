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
    public partial class userTrendingProduct : Form
    {
        int index = 0;
        public userTrendingProduct()
        {
            InitializeComponent();
        }

        private void userTrendingProduct_Load(object sender, EventArgs e)
        {
            if (UserDL.userPurchasedProductList.Count > 3)
            {
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

                UserDL.userPurchasedProductList.Sort((x, y) => y.getProductPrice().CompareTo(x.getProductPrice()));//sort the product accoding to the highest price at starting indexs
                for (int i = 0; i < UserDL.userPurchasedProductList.Count; i++)

                {
                    if (i > 3)
                    {
                        break;
                    }
                    Product product = UserDL.userPurchasedProductList[i];
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

            else
            {
                Console.WriteLine("nothing in trend");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form = new UserModule();
            form.Show();
            this.Hide();
        }

        private void updateGrpBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productIndex = int.Parse(txtPIndex.Text);
            Product purchaseProduct = UserDL.getTrendingProduct(productIndex);
            if (purchaseProduct != null)
            {
                MessageBox.Show("Successfully Purchased product");
                UserDL.addPurchasedProduct(purchaseProduct);
                UserDL.storePurchasedProductIntoTheFile();
            }
            else
            {
                MessageBox.Show("Enter correct index");
            }
        }
    }
}
