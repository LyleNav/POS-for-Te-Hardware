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
    public partial class formSupplierManage : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //reference formAfterLogin to this form
        public MySqlConnection conn; //connection
        public int supplierID;
        public string supplierName, supplierDesc, supplierContact;
        public formSupplierManage()
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

        private void formSupplierManage_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formSupplierManage_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formSupplierManage_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formSupplierManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToAfterLogin.Show(); //shows the previous form upon exiting the current form
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            formAddSupplier formAS = new formAddSupplier(); //variable reference to formAddSupplier
            formAS.ReferenceToSupManage = this; //sets the reference form to this form
            formAS.Show(); //shows referenced form
            this.Hide(); //hides current form
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_supplier", conn); //query to select all entries in tbl_supplier
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table

                formEditSupplier formES = new formEditSupplier(); //variable reference to formEditSupplier
                formES.ReferenceToSupManage = this; //sets the reference form to this form
                formES.supName = supplierName;
                formES.supDesc = supplierDesc;
                formES.supContact = supplierContact;
                formES.supID = supplierID;
                formES.Show(); //shows referenced form
                this.Hide(); //hides current form
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.ToString());
                conn.Close();
            }
        }
        private void dataLoad() //loads the data from the database
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_supplier", conn); //query to select all entries in tbl_supplier
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table

                dataGridSupplier.DataSource = dt; //sets datasource to datatable
                dataGridSupplier.Columns["supplierID"].Visible = false; //gets the supplierID and sets it's visibility to false
                dataGridSupplier.Columns["supplierName"].HeaderText = "Supplier Name"; //gets the supplierName and sets it as a header
                dataGridSupplier.Columns["supplierDesc"].HeaderText = "Supplier Desc."; //gets the supplierDesc and sets it as a header
                dataGridSupplier.Columns["supplierContactInfo"].HeaderText = "Supplier Contact Info"; //gets the supplierDesc and sets it as a header
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
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_supplier", conn); //query to select all entries in tbl_supplier
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table
                dataGridSupplier.DataSource = dt; //sets datasource to data table
                conn.Close(); //closes the connection
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in getData(): " + x.ToString()); //shows and error if there is one
                conn.Close(); //closes the connection
            }
        }

        private void formSupplierManage_Load(object sender, EventArgs e)
        {
            dataLoad();
            btnEditSupplier.Enabled = false;
            btnDeleteSupplier.Enabled = false;
            dataGridSupplier.ClearSelection();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            Delete();
            dataGridSupplier.ClearSelection();
            btnEditSupplier.Enabled = false;
            btnAddSupplier.Enabled = true;
            btnDeleteSupplier.Enabled = false;
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            btnEditSupplier.Enabled = false;
            btnAddSupplier.Enabled = true;
            btnDeleteSupplier.Enabled = false;
            dataGridSupplier.ClearSelection();
        }

        private void dataGridSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddSupplier.Enabled = false;
            btnEditSupplier.Enabled = true;
            btnDeleteSupplier.Enabled = true;

            supplierName = dataGridSupplier.Rows[e.RowIndex].Cells["supplierName"].Value.ToString();
            supplierDesc = dataGridSupplier.Rows[e.RowIndex].Cells["supplierDesc"].Value.ToString();
            supplierContact = dataGridSupplier.Rows[e.RowIndex].Cells["supplierContactInfo"].Value.ToString();
            supplierID = int.Parse(dataGridSupplier.Rows[e.RowIndex].Cells["supplierID"].Value.ToString());
        }

        private void Delete()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_supplier WHERE supplierID = '" + supplierID + "'", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("DELETE FROM tbl_supplier WHERE supplierID ='" + supplierID + "'", conn);
                query1.ExecuteNonQuery();
                conn.Close();
                getData();

                MessageBox.Show("Deleted Successfully!", "", MessageBoxButtons.OK);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Delete: " + x.ToString());
                conn.Close();
            }
        }
    }
}
