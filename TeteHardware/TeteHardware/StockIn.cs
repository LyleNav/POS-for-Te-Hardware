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
    public partial class formArrival : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //reference formAfterLogin to this form
        public MySqlConnection conn; //connection
        Test func = new Test();
        public formArrival()
        {   
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            InitializeComponent();
            this.Opacity = 0; //sets form opacity to 0
            timer1.Start(); //form transition using timer
        }

        public void gridProductLoad(string selectCommand) //loads the data from the database
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand(selectCommand, conn); //query to select all entries in tbl_productcatalog
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                BindingSource bs = new BindingSource();
                dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adp.Fill(dt);
                bs.DataSource = dt;
                dataGridProduct.DataSource = bs;
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in dataLoad(): " + x).ToString(); //shows an error if there is one
                conn.Close(); // closes the connection
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        private void formArrival_Load(object sender, EventArgs e)
        {
            this.calArrival.Location = new Point(172, 334);
            clearFormArrival();
            populateSupCombos();
        }

        private void populateSupCombos()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("Select supName, supID from tbl_supplier", conn);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    comboSupName.Items.Add(reader[0]);
                    comboSupID.Items.Add(reader[1]);
                }
                conn.Close();
                comboSupName.SelectedIndex = 0;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in populating Supplier Choices: " + x.ToString());
                conn.Close();
            }

        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            gridProductLoad("SELECT prodID AS 'Product ID', prodName AS 'Product Name' FROM tbl_product WHERE prodID LIKE '%"+ txtSearchID.Text + "%'");
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            gridProductLoad("SELECT prodID AS 'Product ID', prodName AS 'Product Name' FROM tbl_product WHERE prodName LIKE '%" + txtSearchName.Text + "%'");
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtItemName.Text = dataGridProduct.Rows[e.RowIndex].Cells["Product Name"].Value.ToString();
                txtItemID.Text = dataGridProduct.Rows[e.RowIndex].Cells["Product ID"].Value.ToString();
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!func.IsNumeric(txtQty.Text))
                {
                    MessageBox.Show("Invalid Quantity", "", MessageBoxButtons.OK);
                }
                else if (float.Parse(txtQty.Text) == 0)
                {
                    MessageBox.Show("Cannot be Saved", "", MessageBoxButtons.OK);
                }
                else
                {
                    Add();
                    clearFormArrival();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("Error in Add(): " + x.ToString());
            }
        }
       private void Add()
        {
            try
            {
                //for tbl_arr or tbl_arrdef
                conn.Open();
                MySqlCommand query = new MySqlCommand("INSERT INTO " + txtTable.Text + "(prodID, empID, Quantity, dateEncoded, dateArrival, Status, supID) VALUES('" + txtItemID.Text + "', '" + TeteHardware.Properties.Settings.Default.loginID + "', '" + txtQty.Text + "', '" + DateTime.Now.ToString() + "', '" + txtdateArrival.Text + "', '" + txtStatus.Text + "','" + comboSupID.Text + "')", conn);
                query.ExecuteNonQuery();
                func.ChangeLog(txtTable.Text, "All", "None");
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Add() :" + x.ToString());
                conn.Close();
            }
            if (txtTable.Text == "tbl_arr")
            {
                //update tbl_products if items arrived are in good condition ("tbl_arr")
                string myStock;
                try
                {
                    conn.Open();
                    myStock = "";
                    MySqlCommand query1 = new MySqlCommand("SELECT prodStock FROM tbl_product WHERE prodID = '" + txtItemID.Text + "'", conn);
                    MySqlDataReader reader = query1.ExecuteReader();
                    while (reader.Read())
                    {
                        myStock = Convert.ToString(reader[0]);
                    }
                    conn.Close();
                    conn.Open();
                    MySqlCommand query = new MySqlCommand("UPDATE tbl_product SET prodStock = prodStock + '" + txtQty.Text + "' WHERE prodID = '" + txtItemID.Text + "'", conn);
                    query.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Added Successfully!", "", MessageBoxButtons.OK);
                    func.ChangeLog("tbl_product", "prodStock", myStock);
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error in Add() :" + x.ToString());
                    conn.Close();
                }
            }
            else if (txtTable.Text == "tbl_arrdef")
            {
                MessageBox.Show("Added Successfully to defective database!", "", MessageBoxButtons.OK);
            }

        }
        private void clearFormArrival()
        {
            gridProductLoad("SELECT prodID AS 'Product ID', prodName AS 'Product Name' FROM tbl_product");
            txtSearchID.Text = "";
            txtSearchName.Text = "";
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtQty.Text = "0";
            txtdateArrival.Text = "";
            txtStatus.Text = "";
            dataGridProduct.ClearSelection();
        }
        private void txtdateArrival_Enter(object sender, EventArgs e)
        {
            calArrival.Visible = true;
        }

        private void calArrival_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtdateArrival.Text = calArrival.SelectionRange.Start.ToShortDateString();
            calArrival.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReferenceToAfterLogin.Show();
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ReferenceToAfterLogin.Show();
            this.Dispose();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchID.Text = "";
            txtSearchName.Text = "";
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtQty.Text = "0";
            txtdateArrival.Text = "";
            txtStatus.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReferenceToAfterLogin.Show();
            this.Dispose();
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void formArrival_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formArrival_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formArrival_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void comboSupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSupID.SelectedIndex = comboSupName.SelectedIndex;
        }
    }
}
