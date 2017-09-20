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
    public partial class formInStoreDamages : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //Reference formEmployeeManage to this form
        public MySqlConnection conn; //connection
        float myStock = 0;

        Test func = new Test();

        public formInStoreDamages()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0;
            timer1.Start();
        }

        private void formInStoreDamages_Load(object sender, EventArgs e)
        {
            dataGridProduct.Size = new Size(350, 350);
            dataGridProduct.Location = new Point(97, 18);
            dataGridProduct.Visible = false;
            txtDate.Text = DateTime.Now.ToString();
            calMon.Location = txtDate.Location;
            calMon.Visible = false;
            gridProductLoad("SELECT prodName, prodID FROM tbl_product");
            clearForm();
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
            if (keyData == Keys.F1)
            {
                MessageBox.Show("You pressed the F1 key");
                return true;    // indicate that you handled this keystroke
            }
            if (keyData == Keys.F6)
            {
                dataGridProduct.Visible = true;
                gridProductLoad("SELECT prodName, prodID FROM tbl_product");

                return true;    // indicate that you handled this keystroke
            }
            else if (keyData == Keys.Escape)     //Close Window
            {
                ReferenceToAfterLogin.Show();
                this.Dispose();
            }
            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //buttons handling
        private void btnClose_Click(object sender, EventArgs e)
        {
            ReferenceToAfterLogin.Show();
            this.Dispose();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            dataGridProduct.Visible = true;
            gridProductLoad("SELECT prodName, prodID FROM tbl_product");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtQty.Text=="0")
            {
                MessageBox.Show("No quantity!", "", MessageBoxButtons.OK);
            }
            if (txtDate.Text == "" || txtName.Text == "" || txtProdName.Text == "" || txtQty.Text == "") //DATA VALIDATION
            {
                MessageBox.Show("Please supply all necessary fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows a message box if textboxes are blank
            }
            else
            {
                saveData();
                updateTableProduct();
                clearForm();
            }
        }
        private void txtProdName_Enter(object sender, EventArgs e)
        {
            dataGridProduct.Visible = true;
            gridProductLoad("SELECT prodName, prodID, prodStock FROM tbl_product WHERE prodStock > 0");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        //controls handling
        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getItemData();
        }

        private void dataGridProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getItemData();
            }
        }

        private void txtDate_Enter(object sender, EventArgs e)
        {
            calMon.Visible = true;
        }

        private void calMon_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = calMon.SelectionRange.Start.ToShortDateString();
            calMon.Visible = false;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtQty.Text, "  ^ [0-9]")) //textbox only accepts numbers
            {
                txtQty.Text = "";
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) //with decimals
            {
                e.Handled = true;
            }
        }

        //Subroutines
        public void gridProductLoad(string selectCommand) //loads the data from the database
        {
            try
            {
                dataGridProduct.DataSource = null;      //remove datasource link for datagridProduct
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
                dataGridProduct.AutoResizeColumns();
                dataGridProduct.Focus();
                dataGridProduct.Rows[0].Selected = true;
                dataGridProduct.CurrentCell.Selected = false;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in dataLoad(): " + x).ToString(); //shows an error if there is one
                conn.Close(); // closes the connection
            }
        }

        private void getItemData()
        {
            //clearForm();

            int myRowIndex = dataGridProduct.CurrentRow.Index;

            try
            {
                txtProdName.Text = dataGridProduct.Rows[myRowIndex].Cells["prodName"].Value.ToString();
                txtProdID.Text = dataGridProduct.Rows[myRowIndex].Cells["prodID"].Value.ToString();
                myStock = float.Parse(dataGridProduct.Rows[myRowIndex].Cells["prodStock"].Value.ToString());
            }
            catch (ArgumentOutOfRangeException) { }

            txtQty.Enabled = true;
            txtQty.Focus();
            txtQty.SelectAll();
            dataGridProduct.Visible = false;
        }

        private void clearForm()
        {
            txtName.Text = "";
            txtProdName.Text = "";
            txtProdID.Text = "";
            txtQty.Text = "0";
            txtRem.Text = "";
           
        }

        private void saveData()
        {
            //get all data needed by table
            //dateDamaged - txtDate, Name - txtName, prodID - txtprodID, Qty - txtQty, Remarks - txtRem
            //save to tbl_damage
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("INSERT INTO tbl_damage(damDate, damBy, prodID, damQty, damRemarks, empID) VALUES('" + Convert.ToDateTime(txtDate.Text).ToString("d") + "', '" + txtName.Text + "', '" + txtProdID.Text + "', '" + txtQty.Text + "', '" + txtRem.Text + "', '" + TeteHardware.Properties.Settings.Default.loginID + "')", conn);
                query.ExecuteNonQuery();
                conn.Close();
                func.ChangeLog("tbl_damage", "All", "None");
                MessageBox.Show("Added Successfully!", "", MessageBoxButtons.OK);
            }
            catch (MySqlException x)
            {
                MessageBox.Show("Error in saving : " + x.Message);
                conn.Close();
            }
            
        }

        private void updateTableProduct()
        {
            //MessageBox.Show("UPDATE tbl_product SET prodStock = VALUE(prodStock) - " + int.Parse(txtQty.Text) + " WHERE prodID = '" + txtProdID.Text + "'", "", MessageBoxButtons.OK);
            conn.Open();
            MySqlCommand query = new MySqlCommand("UPDATE tbl_product SET prodStock = '" + (myStock - float.Parse(txtQty.Text)) + "' WHERE prodID = '" + txtProdID.Text + "'", conn);
            query.ExecuteNonQuery();
            conn.Close();
            func.ChangeLog("tbl_product", "prodStock", myStock.ToString());
        }

    }
}

