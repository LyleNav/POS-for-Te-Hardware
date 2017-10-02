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
    public partial class formReturns : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //Reference formEmployeeManage to this form
        public MySqlConnection conn; //connection

        Test func = new Test();

        public formReturns()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0;
            timer1.Start();
        }

        private void formReturns_Load(object sender, EventArgs e)
        {
            populatecomboSupplier();
            txtCalReturn.Text = DateTime.Now.ToString("d");
            calReturned.Location = txtCalReturn.Location;
            calReturned.MaxDate = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }
        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse

        private void formReturns_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formReturns_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formReturns_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        //Hot Keys Handling - put any special keys with special functions here
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)     //Close Window
            {
                ReferenceToAfterLogin.Show();
                this.Dispose();
            }
            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Buttons Handling - put all codes for any buttons here
        private void btnClose_Click(object sender, EventArgs e)
        {
            ReferenceToAfterLogin.Show();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtReference.Text == "" || comboSupplier.Text == "" || txtQty.Text == "" || txtCalReturn.Text == "")
            {
                MessageBox.Show("Please supply all necessary fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows a message box if textboxes are blank
            }
            else
            {
                saveToDatabase();
            }
        }

        private void txtCalReturn_Click(object sender, EventArgs e)
        {
            calReturned.Show();
        }

        //textbox handling
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (!func.IsFloat(txtQty.Text))
            {
                //MessageBox.Show("Invalid Quantity", "", MessageBoxButtons.OK);
                txtQty.Text = "0";
                txtQty.SelectAll();
            }
        }

        private void calReturned_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtCalReturn.Text = calReturned.SelectionRange.Start.ToShortDateString();
            calReturned.Hide();
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            int myRowIndex = dataGridProduct.CurrentRow.Index;
            if (int.Parse(txtQty.Text) > int.Parse(dataGridProduct.Rows[myRowIndex].Cells["Quantity"].Value.ToString()))
            {
                MessageBox.Show("Quantity returned is greater than the defective quantity!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQty.Focus();
                txtQty.SelectAll();
            }
        }

        //combo handling
        private void comboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            combosupID.SelectedIndex = comboSupplier.SelectedIndex;
            populateDataGridProducts();
        }

        private void populatecomboSupplier()
        {
            comboSupplier.Items.Clear();
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT supID, supName FROM tbl_supplier", conn);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    combosupID.Items.Add(Convert.ToString(reader[0]));
                    comboSupplier.Items.Add(Convert.ToString(reader[1]));
                }
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in populating comboSupplier: " + x.ToString());
                conn.Close();
            }
        }

        private void populateDataGridProducts()
        {
            dataGridProduct.DataSource = null;      //remove datasource link for datagridProduct
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT a.prodID, b.prodName, a.Quantity, a.DateArrival, a.Status FROM tbl_arrdef a, tbl_product b WHERE a.supID = '" + combosupID.Text + "' AND a.prodID = b.prodID AND a.Quantity > 0", conn); //query to select all entries in tbl_productcatalog
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                BindingSource bs = new BindingSource();
                dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adp.Fill(dt);
                bs.DataSource = dt;
                dataGridProduct.DataSource = bs;
                conn.Close();
                dataGridProduct.AutoResizeColumns();
                dataGridProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in populating datagridTable : " + x.ToString());
                conn.Close();
            }
        }
       
        private void saveToDatabase()
        {
            //insert to tbl_returnto
            int myRowIndex = dataGridProduct.CurrentRow.Index;
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("INSERT INTO tbl_returnto(retRef, prodID, supID, retQty, retDate, retDefect, empID) VALUES('" + txtReference.Text + "','" + dataGridProduct.Rows[myRowIndex].Cells["prodID"].Value.ToString() + "','" + combosupID.Text + "','" + txtQty.Text + "','" + txtCalReturn.Text + "', '" + txtRemarks.Text + "', " + TeteHardware.Properties.Settings.Default.loginID + ")", conn);
                query.ExecuteNonQuery();
                conn.Close();
                func.ChangeLog("tbl_returnto", "All", "None");

                MessageBox.Show("Added Successfully!", "", MessageBoxButtons.OK);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Adding to ReturnTo table :" + x.ToString());
                conn.Close();
            }

            //update tbl_arrdef
            int newQuantity = int.Parse(dataGridProduct.Rows[myRowIndex].Cells["Quantity"].Value.ToString()) - int.Parse(txtQty.Text);

            //MessageBox.Show("UPDATE tbl_arrdef SET Quantity = '" + newQuantity + "', retDate = '" + txtCalReturn.Text + "' WHERE prodID = '" + dataGridProduct.Rows[myRowIndex].Cells["prodID"].Value.ToString() + "'");
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("UPDATE tbl_arrdef SET Quantity = '" + newQuantity + "', retDate = '" + txtCalReturn.Text + "', retQty = " + txtQty.Text + " WHERE prodID = '" + dataGridProduct.Rows[myRowIndex].Cells["prodID"].Value.ToString() + "'", conn);
                query.ExecuteNonQuery();
                conn.Close();
                func.ChangeLog("tbl_arrdef", "Quantity", dataGridProduct.Rows[myRowIndex].Cells["Quantity"].Value.ToString());

            }
            catch (Exception x)
            {
                MessageBox.Show("Error in saveToDatabase: " + x.ToString());
                conn.Close();
            }
            //refresh dataGridProduct
            populateDataGridProducts();
            txtCalReturn.Text = "";
            txtRemarks.Text = "";
            txtQty.Text = "0";
            
        }

        private void Strto2DecPlaces(TextBox myTextbox)
        {
            if (myTextbox.Text.Contains("."))
            {
                myTextbox.Text = Convert.ToString(decimal.Round(decimal.Parse(myTextbox.Text + "000"), 2));
            }
            else
            {
                myTextbox.Text = Convert.ToString(decimal.Round(decimal.Parse(myTextbox.Text + ".000"), 2));
            }
        }

    }
}
