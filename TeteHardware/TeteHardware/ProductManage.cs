using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TeteHardware
{
    public partial class formProductManage : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //reference formAfterLogin to this form
        public MySqlConnection conn; //connection
        public int productID, categoryID, supplierID, promoID, productStock, productStatus;
        public string prodName, prodDesc, prodUnit;
        public float prodPrice;
        public formProductManage()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //sets form opacity to 0
            timer1.Start(); //form transition using timer
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form, shows previous form
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form, shows previous form
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            formAddProduct formAP = new formAddProduct(); //variable reference to formAddPromo
            formAP.ReferenceToProdManage = this; //sets the reference form to this form
            formAP.Show(); //shows referenced form
            this.Hide(); //hides current form
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            btnAddProduct.Enabled = true;
            btnEditProduct.Enabled = false;
            btnViewDetails.Enabled = false;
            dataGridProduct.ClearSelection();
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void formProductManage_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formProductManage_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formProductManage_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formProductManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToAfterLogin.Show(); //shows the previous form upon exiting the current form
        }

        private void formProductManage_Load(object sender, EventArgs e)
        {
            dataLoad();
            btnEditProduct.Enabled = false;
            btnViewDetails.Enabled = false;
            dataGridProduct.ClearSelection();
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddProduct.Enabled = false;
            btnEditProduct.Enabled = true;
            btnViewDetails.Enabled = true;

            productID = int.Parse(dataGridProduct.Rows[e.RowIndex].Cells["productID"].Value.ToString());
            categoryID = int.Parse(dataGridProduct.Rows[e.RowIndex].Cells["pCatalogID"].Value.ToString());
            supplierID = int.Parse(dataGridProduct.Rows[e.RowIndex].Cells["pSupplierID"].Value.ToString());
            promoID = int.Parse(dataGridProduct.Rows[e.RowIndex].Cells["pPromoID"].Value.ToString());
            prodName = dataGridProduct.Rows[e.RowIndex].Cells["productName"].Value.ToString();
            prodDesc = dataGridProduct.Rows[e.RowIndex].Cells["productDesc"].Value.ToString();
            prodUnit = dataGridProduct.Rows[e.RowIndex].Cells["productUnit"].Value.ToString();
            prodPrice = float.Parse(dataGridProduct.Rows[e.RowIndex].Cells["productPrice"].Value.ToString());
            productStock = int.Parse(dataGridProduct.Rows[e.RowIndex].Cells["productStock"].Value.ToString());
            productStatus = int.Parse(dataGridProduct.Rows[e.RowIndex].Cells["productUnit"].Value.ToString());
            
        }
        public void dataLoad() //loads the data from the database
        {
           try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_product", conn); //query to select all entries in tbl_promo
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table

                dataGridProduct.DataSource = dt; //sets datasource to datatable
                dataGridProduct.Columns["productID"].Visible = false; //gets the productID and sets it's visibility to false
                dataGridProduct.Columns["productName"].HeaderText = "Name"; //gets the productName and sets it as a header
                dataGridProduct.Columns["productDesc"].HeaderText = "Description"; //gets the productDesc and sets it as a header
                dataGridProduct.Columns["pCatalogID"].HeaderText = "Category"; //gets the pCatalogID and sets it as a header
                dataGridProduct.Columns["pSupplierID"].HeaderText = "Supplier"; //gets the pSupplierID and sets it as a header
                dataGridProduct.Columns["pPromoID"].HeaderText = "Promo"; //gets the pPromoID and sets it as a header
                dataGridProduct.Columns["productStock"].HeaderText = "Stock"; //gets the productStock and sets it as a header
                dataGridProduct.Columns["productPrice"].HeaderText = "Price"; //gets the productPrice and sets it as a header
                dataGridProduct.Columns["productUnit"].HeaderText = "Unit"; //gets the productUnit and sets it as a header
                dataGridProduct.Columns["productStatus"].HeaderText = "Status"; //gets the productStatus and sets it as a header

                conn.Close(); //closes the connection
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in dataLoad(): " + x).ToString(); //shows an error if there is one
                conn.Close(); // closes the connection
            }
        }

        public void getData() //gets the data from the database
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_product", conn); //query to select all entries in tbl_product
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table
                dataGridProduct.DataSource = dt; //sets datasource to data table
                conn.Close(); //closes the connection
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in getData(): " + x.ToString()); //shows and error if there is one
                conn.Close(); //closes the connection
            }
        }
    }
}
