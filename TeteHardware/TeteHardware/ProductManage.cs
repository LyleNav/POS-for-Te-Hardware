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
        public int employeeID;
        public string productID, prodName, prodDesc, prodUnit, prodStatus;
        public float prodPrice, prodStock, prodMOQ;
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
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_product", conn); //query to select all entries in tbl_supplier
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table

                formEditProduct formEP = new formEditProduct(); //variable reference to formEditSupplier
                formEP.ReferenceToProdManage = this; //sets the reference form to this form
                formEP.prodID = productID;
                formEP.empID = employeeID;
                formEP.prodName = prodName;
                formEP.prodMOQ = prodMOQ;
                formEP.prodDesc = prodDesc;
                formEP.prodStock = prodStock;
                formEP.prodPrice = prodPrice;
                formEP.prodUnit = prodUnit;
                formEP.prodStatus = prodStatus;

                formEP.Show(); //shows referenced form
                this.Hide(); //hides current form
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.ToString());
                conn.Close();
            }
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
            try
            {
                btnAddProduct.Enabled = false;
                btnEditProduct.Enabled = true;
                btnViewDetails.Enabled = true;

                productID = dataGridProduct.Rows[e.RowIndex].Cells["prodID"].Value.ToString();
                employeeID = int.Parse(dataGridProduct.Rows[e.RowIndex].Cells["empID"].Value.ToString());
                prodName = dataGridProduct.Rows[e.RowIndex].Cells["prodName"].Value.ToString();
                prodMOQ = int.Parse(dataGridProduct.Rows[e.RowIndex].Cells["prodMOQ"].Value.ToString());
                prodDesc = dataGridProduct.Rows[e.RowIndex].Cells["prodDesc"].Value.ToString();
                prodStock = int.Parse(dataGridProduct.Rows[e.RowIndex].Cells["prodStock"].Value.ToString());
                prodPrice = float.Parse(dataGridProduct.Rows[e.RowIndex].Cells["prodUPrice"].Value.ToString());
                prodUnit = dataGridProduct.Rows[e.RowIndex].Cells["prodUnit"].Value.ToString();
                prodStatus = dataGridProduct.Rows[e.RowIndex].Cells["prodStatus"].Value.ToString();
            }
            catch (ArgumentOutOfRangeException) { }
            
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
                dataGridProduct.Columns["prodID"].HeaderText = "Product ID"; //gets the productID and sets it's visibility to false
                dataGridProduct.Columns["autoID"].Visible = false;
                dataGridProduct.Columns["prodName"].HeaderText = "Name"; //gets the productName and sets it as a header
                dataGridProduct.Columns["prodDesc"].HeaderText = "Description"; //gets the pCatalogID and sets it as a header
                dataGridProduct.Columns["prodStock"].HeaderText = "Stock"; //gets the pSupplierID and sets it as a header
                dataGridProduct.Columns["prodUnit"].HeaderText = "Unit"; //gets the pPromoID and sets it as a header
                dataGridProduct.Columns["prodUPrice"].HeaderText = "Unit Price"; //gets the productStock and sets it as a header
                dataGridProduct.Columns["prodMOQ"].HeaderText = "MOQ"; //gets the productDesc and sets it as a header
                dataGridProduct.Columns["prodStatus"].HeaderText = "Status"; //gets the productPrice and sets it as a header
                dataGridProduct.Columns["empID"].HeaderText = "Emp ID";

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
