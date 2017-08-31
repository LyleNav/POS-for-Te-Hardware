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
    public partial class formCatalogManage : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //reference formAfterLogin to this form
        public MySqlConnection conn; //connection
        public string catalogID, catalogName, catalogDesc;
        public formCatalogManage()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse

        private void formCatalogManage_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formCatalogManage_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formCatalogManage_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formCatalogManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToAfterLogin.Show(); //shows the previous form upon exiting the current form
        }

        private void btnAddCatalog_Click(object sender, EventArgs e)
        {
            formAddCatalog formAC = new formAddCatalog(); //variable reference to formAddCatalog
            formAC.ReferenceToCatManage = this; //sets the reference form to this form
            formAC.Show(); //shows referenced form
            this.Hide(); //hides current form
        }

        private void btnEditCatalog_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_productcatalog", conn); //query to select all entries in tbl_productcatalog
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table

                formEditCatalog formEC = new formEditCatalog(); //variable reference to formEditCatalog
                formEC.ReferenceToCatManage = this; //sets the reference form to this form
                formEC.catName = catalogName;
                formEC.catDesc = catalogDesc;
                formEC.catID = catalogID;
                formEC.Show(); //shows referenced form
                this.Hide(); //hides current form
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.ToString());
                conn.Close();
            }
        }

        public void dataLoad() //loads the data from the database
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_productcatalog", conn); //query to select all entries in tbl_productcatalog
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table

                dataGridCatalog.DataSource = dt; //sets datasource to datatable
                dataGridCatalog.Columns["catID"].Visible = false; //gets the productCatalogID and sets it's visibility to false
                dataGridCatalog.Columns["autoID"].Visible = false;
                dataGridCatalog.Columns["catName"].HeaderText = "Name"; //gets the productCatalogName and sets it as a header
                dataGridCatalog.Columns["catDesc"].HeaderText = "Description"; //gets the productCatalogDesc and sets it as a header
                conn.Close(); //closes the connection
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in dataLoad(): " + x).ToString(); //shows an error if there is one
                conn.Close(); // closes the connection
            }
        }

        private void formCatalogManage_Load(object sender, EventArgs e) //loads the data during form load
        {
            dataLoad();
            btnEditCatalog.Enabled = false;
            btnViewDetails.Enabled = false;
            dataGridCatalog.ClearSelection();
        }

        private void dataGridCatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAddCatalog.Enabled = false;
                btnEditCatalog.Enabled = true;
                btnViewDetails.Enabled = true;

                catalogName = dataGridCatalog.Rows[e.RowIndex].Cells["catName"].Value.ToString();
                catalogDesc = dataGridCatalog.Rows[e.RowIndex].Cells["catDesc"].Value.ToString();
                catalogID = dataGridCatalog.Rows[e.RowIndex].Cells["catID"].Value.ToString();
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            btnAddCatalog.Enabled = true;
            btnEditCatalog.Enabled = false;
            btnViewDetails.Enabled = false;
            dataGridCatalog.ClearSelection();
        }

        private void btnDeleteCatalog_Click(object sender, EventArgs e)
        {
        }

        public void getData() //gets the data from the database
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_productcatalog", conn); //query to select all entries in tbl_productcatalog
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table
                dataGridCatalog.DataSource = dt; //sets datasource to data table
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
