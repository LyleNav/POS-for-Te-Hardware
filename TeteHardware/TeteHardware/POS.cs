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
    public partial class formPOS : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //Reference formEmployeeManage to this form
        public MySqlConnection conn; //connection
        Test func = new Test();
        bool myboolEdit = false;

        private void InitializeFormPOS()
        {
            //get screen
            int myScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int myScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            //MessageBox.Show(myScreenWidth.ToString(), "", MessageBoxButtons.OK);

            if(myScreenWidth<1300)
            {
                MessageBox.Show("Please select at least 1400 X 900 Scree Resolution");
                ReferenceToAfterLogin.Show();
                this.Dispose();
            }
            pnlTransact.Location = new Point((myScreenWidth - 1000 - pnlTransact.Width) / 2, 0);
            dataGridProduct.Location = new Point(pnlTransact.Location.X, dataGridProduct.Location.Y);
            pnlButtons2.Location = new Point(pnlTransact.Location.X, myScreenHeight - pnlButtons2.Height);
            pnlButtons.Location = new Point(pnlTransact.Location.X, myScreenHeight - pnlButtons2.Height - pnlButtons.Height);

            pnlgridProduct.Size = new Size(610, 600);
            pnlgridProduct.Controls.Add(dataGridProduct);
            pnlgridProduct.Controls.Add(lblSearchID);
            pnlgridProduct.Controls.Add(lblSearchName);
            pnlgridProduct.Controls.Add(txtSearchID);
            pnlgridProduct.Controls.Add(txtSearchName);
            lblSearchID.Location = new Point(5, 5);
            lblSearchName.Location = new Point(200, 5);
            txtSearchID.Location = new Point(5, 35);
            txtSearchName.Location = new Point(200, 35);
            dataGridProduct.Size = new Size(600, 500);
            dataGridProduct.Location = new Point(5,75);
            pnlgridProduct.Visible = false;
            dataGridOrdered.Size = new Size(1000, myScreenHeight-100);
            dataGridOrdered.Location = new Point(myScreenWidth - 1000, 50);
            txtGrandTot.Text = "0.00";
            dataGridProduct.ClearSelection();
            dataGridOrdered.ClearSelection();
            myboolEdit = false;
            lblHardware1.SendToBack();
            lblHardware2.SendToBack();
            pnlPay.Size = new Size(632, 379);
            pnlPay.Location = new Point((myScreenWidth - pnlPay.Width) / 2, (myScreenHeight - pnlPay.Height) / 2);
            pnlPay.Visible = false;
            btnClosePay.Location = new Point((myScreenWidth - btnClosePay.Width) / 2, (myScreenHeight - btnClosePay.Height - pnlPay.Height) / 2);
            btnClosePay.Visible = false;
            btnClosePay.BringToFront();
        }
        public formPOS()
        {
            InitializeComponent();
            InitializeFormPOS();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //form transition using timer
            timer1.Start(); //form transition using timer
            searchVisibility(false);
        }

        private void formPOS_Load(object sender, EventArgs e)
        {
            this.calTrans.Location = new Point(157, 351);
            clearFormTransact();
            initializeOrderedGrid();
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

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void Transcation_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void Transcation_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void Transcation_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        private void txtdateTransact_Enter(object sender, EventArgs e)
        {
            calTrans.Visible = true;
        }

        private void calTrans_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtdateTransact.Text = calTrans.SelectionRange.Start.ToShortDateString();
            txtTransDate2.Text = calTrans.SelectionRange.Start.ToShortDateString();
            calTrans.Visible = false;
        }
        public void refreshTable()
        {
            gridProductLoad("SELECT prodID AS 'ID', prodName AS 'Name', prodUPrice AS 'Price', prodStock AS 'Stock', prodUnit AS 'Unit' FROM tbl_product");
            txtdateTransact.Text = DateTime.Now.ToString();
            txtTransDate2.Text = DateTime.Now.ToString();
            //reset comboboxes
            comboDiscID.SelectedIndex = 0;
            comboDiscName.SelectedIndex = 0;
            comboDiscType.SelectedIndex = 0;
            comboDiscValue.SelectedIndex = 0;
            comboDiscPercent.SelectedIndex = 0;
            //clear text boxes
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtSearchID.Text = "";
            txtSearchName.Text = "";
            txtPrice.Text = "0";
            txtQty.Text = "0";
            txtSubTotPrice.Text = "0";
            txtDiscAmt.Text = "0";
            txtTotPrice.Text = "0";
            txtStatus.Text = "";
        }
        public void clearFormTransact()
        {
            gridProductLoad("SELECT prodID AS 'ID', prodName AS 'Name', prodUPrice AS 'Price', prodStock AS 'Stock', prodUnit AS 'Unit' FROM tbl_product");
            comboPromoLoad("SELECT promoName, promoID, promoType, promoValue, promoPercent FROM tbl_promo");
            txtdateTransact.Text = DateTime.Now.ToString();
            txtTransDate2.Text= DateTime.Now.ToString();
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtSearchID.Text = "";
            txtSearchName.Text = "";
            txtPrice.Text = "0";
            txtQty.Text = "0"; 
            txtSubTotPrice.Text = "0";
            txtDiscAmt.Text = "0";
            txtTotPrice.Text = "0";
            txtStatus.Text = "";
            dataGridProduct.ClearSelection();

        }
        public void clearForm()
        {
            //reset comboboxes
            comboDiscID.SelectedIndex = 0;
            comboDiscName.SelectedIndex = 0;
            comboDiscType.SelectedIndex = 0;
            comboDiscValue.SelectedIndex = 0;
            comboDiscPercent.SelectedIndex = 0;
            //set date
            txtdateTransact.Text = DateTime.Now.ToString();
            //clear text boxes
            txtItemID.Text = "";
            txtItemName.Text = "";
            txtSearchID.Text = "";
            txtSearchName.Text = "";
            txtPrice.Text = "0";
            txtQty.Text = "0";
            txtSubTotPrice.Text = "0";
            txtDiscAmt.Text = "0";
            txtTotPrice.Text = "0";
            txtStatus.Text = "";
        }

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
                dataGridProduct.Columns[0].Width = 100;
                dataGridProduct.Columns[1].Width = 350;
                dataGridProduct.Columns[2].Width = 75;
                dataGridProduct.Columns[3].Width = 75;

            }
            catch (Exception x)
            {
                MessageBox.Show("Error in dataLoad(): " + x).ToString(); //shows an error if there is one
                conn.Close(); // closes the connection
            }
        }


        public void comboPromoLoad(string selectCommand) //loads the data from the database
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand(selectCommand, conn);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    if(int.Parse(reader[2].ToString()) == 0)
                    {
                        comboDiscName.Items.Add(reader[0] + " - " + reader[4] + "%");
                    }
                    else
                    {
                        comboDiscName.Items.Add(reader[0] + " - " + reader[3] + " (Value)");
                    }
                    comboDiscID.Items.Add(reader[1]);
                    comboDiscType.Items.Add(reader[2]);
                    comboDiscValue.Items.Add(reader[3]);
                    comboDiscPercent.Items.Add(reader[4]);
                }
                conn.Close();
                comboDiscName.SelectedIndex = 0;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Load: " + x.ToString());
                conn.Close();
            }
        }
        private void comboDiscType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDiscID.SelectedIndex = comboDiscName.SelectedIndex;
            comboDiscType.SelectedIndex = comboDiscName.SelectedIndex;
            comboDiscValue.SelectedIndex = comboDiscName.SelectedIndex;
            comboDiscPercent.SelectedIndex = comboDiscName.SelectedIndex;
            if(comboDiscType.Text == "0") //0 = Percent
            {
                txtDiscAmt.Text = Convert.ToString((decimal.Parse(comboDiscPercent.Text) / 100) * decimal.Parse(txtSubTotPrice.Text));
            }
            else //Value
            {
                txtDiscAmt.Text = Convert.ToString(comboDiscValue.Text);
            }
            computeSubTot();
        }

        private void computeSubTot()
        {
            txtDiscAmt.Text = txtDiscAmt.Text + "000";
            txtTotPrice.Text = Convert.ToString(decimal.Round((decimal.Parse(txtSubTotPrice.Text) - decimal.Parse(txtDiscAmt.Text)), 2));
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //clearForm();
            getItemData();
            searchVisibility(false);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the form
            clearForm();
            //clear datagridOrdered
            dataGridOrdered.Rows.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addToOrdered();
        }

        private void addToOrdered()
        {
            //add prodID, prodName, Qty, UnitPrice, SubTotPrice, PromoID, DiscPrice and TotPrice to a grid
            if (float.Parse(txtTotPrice.Text) > 0)
            {
                if(myboolEdit)
                {
                    dataGridOrdered.Rows[myRowIndex].Cells["Qty"].Value = txtQty.Text;
                    dataGridOrdered.Rows[myRowIndex].Cells["SubTotal"].Value = txtSubTotPrice.Text;
                    dataGridOrdered.Rows[myRowIndex].Cells["Promo ID"].Value = comboDiscID.Text;
                    dataGridOrdered.Rows[myRowIndex].Cells["Discount"].Value = txtDiscAmt.Text;
                    dataGridOrdered.Rows[myRowIndex].Cells["Total Price"].Value = txtTotPrice.Text;
                }
                else
                {
                string[] myData = new string[]
                {txtItemID.Text, txtItemName.Text, txtQty.Text, txtPrice.Text, txtSubTotPrice.Text, comboDiscID.Text, txtDiscAmt.Text, txtTotPrice.Text};
                dataGridOrdered.Rows.Add(myData);
                }

                //clear the form
                clearForm();
                txtQty.Enabled = false;
                dataGridOrdered.ClearSelection();
            }
        }

        private void initializeOrderedGrid()
        {
            dataGridOrdered.ColumnCount = 8;
            dataGridOrdered.Columns[0].Name = "Item ID";
            dataGridOrdered.Columns[1].Name = "Item";
            dataGridOrdered.Columns[2].Name = "Qty";
            dataGridOrdered.Columns[3].Name = "U Price";
            dataGridOrdered.Columns[4].Name = "SubTotal";
            dataGridOrdered.Columns[5].Name = "Promo ID";
            dataGridOrdered.Columns[6].Name = "Discount";
            dataGridOrdered.Columns[7].Name = "Total Price";
            dataGridOrdered.Columns[0].Width = 75;
            dataGridOrdered.Columns[1].Width = 250;
            dataGridOrdered.Columns[2].Width = 100;
            dataGridOrdered.Columns[3].Width = 100;
            dataGridOrdered.Columns[4].Width = 100;
            dataGridOrdered.Columns[5].Width = 75;
            dataGridOrdered.Columns[6].Width = 100;
            dataGridOrdered.Columns[7].Width = 100;

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string myTransNum4 = "";
            string myTransNum = "";
            string myProdID = "";
            string myPromoID = "";
            string myTransDate = "";
            string myTransQty = "";
            string myTransTotPrice = "";
            string mytransDiscount = "";

            //compute for the total amount
            //Transfer items in the datagridOrder to tbl_Transact
            //insert newe row to tbl_transact - prodID, promoID, empID, transNum,transDate,transQty,transTotPrice, transDiscount
            //empID for the actual ebcode

            //set TransNum - first 4 char = year, next 7 char = transactions (can be up to 10,000,000 transactions)
            //get Year (4digit)

            myTransNum4 = Convert.ToString(DateTime.Parse(txtdateTransact.Text).Year);
            //check highest number for the year
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT RIGHT(transNum, 7) AS myTransNum FROM tbl_transact WHERE LEFT(transNum, 4) = '" + myTransNum4 + "' ORDER BY myTransNum", conn);
                MySqlDataReader reader = query.ExecuteReader();
                string myTransNum7 = "";
                int myTransNum7Int = 0;
                while (reader.Read())
                {
                    myTransNum7 = Convert.ToString(reader[0]);
                }
                conn.Close();

                if (myTransNum7 == "")
                {
                    myTransNum7Int = 0;
                }
                else
                {
                    myTransNum7Int = int.Parse(myTransNum7);
                }
                myTransNum7Int = myTransNum7Int + 10000001;
                myTransNum7 = myTransNum7Int.ToString().Substring(myTransNum7Int.ToString().Length - 7);
                myTransNum = myTransNum4 + myTransNum7;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Getting Data for TransNum " + x.ToString());
                conn.Close();
            }

            myTransDate = txtTransDate2.Text;

            //Get data from the datagridOrdered
            for (int myRow = 0; myRow < dataGridOrdered.Rows.Count; myRow++) //loop through the rows
            {
                myProdID = dataGridOrdered.Rows[myRow].Cells[0].Value.ToString();
                myPromoID = dataGridOrdered.Rows[myRow].Cells[5].Value.ToString();
                myTransQty = dataGridOrdered.Rows[myRow].Cells[2].Value.ToString();
                myTransTotPrice = dataGridOrdered.Rows[myRow].Cells[7].Value.ToString();
                mytransDiscount = dataGridOrdered.Rows[myRow].Cells[6].Value.ToString();

                //Save the Data to the table tbl_Transact - prodID, promoID, empID, transNum,transDate,transQty,transTotPrice, transDiscount

                try
                {
                    conn.Open();
                    MySqlCommand query = new MySqlCommand("INSERT INTO tbl_transact(prodID, promoID, empID, transNum, transDate, transQty, transTotPrice, transDiscount) VALUES('" + myProdID + "','" + myPromoID + "','" + TeteHardware.Properties.Settings.Default.loginID + "', '" + myTransNum + "', '" + myTransDate + "', '" + myTransQty + "','" + myTransTotPrice + "','" + mytransDiscount + "')", conn);
                    query.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error in Saving Transaction :" + x.ToString());
                    conn.Close();
                }


                //Update stock on tbl_Product
                string myStock;
                string myMOQ;
                try
                {
                    conn.Open();
                    myStock = "";
                    MySqlCommand query1 = new MySqlCommand("SELECT prodStock FROM tbl_product WHERE prodID = '" + myProdID + "'", conn);
                    MySqlDataReader reader = query1.ExecuteReader();
                    while (reader.Read())
                    {
                        myStock = Convert.ToString(reader[0]);
                    }
                    conn.Close();

                    conn.Open();
                    //update stock volume
                    MySqlCommand query = new MySqlCommand("UPDATE tbl_product SET prodStock = prodStock - '" + myTransQty + "' WHERE prodID = '" + myProdID + "'", conn);
                    query.ExecuteNonQuery();
                    conn.Close();
                    if (myRow == dataGridOrdered.Rows.Count - 1)
                    {
                        MessageBox.Show("Added Successfully!", "", MessageBoxButtons.OK);
                    }
                    func.ChangeLog("tbl_product", "prodStock", myStock);
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error in Updating Product - Stock :" + x.ToString());
                    conn.Close();
                }
                //check if MOQ is breached
                try
                { 
                    myMOQ = "";
                    myStock = "";
                    conn.Open();
                    MySqlCommand query2 = new MySqlCommand("SELECT prodStock, prodMOQ FROM tbl_product WHERE prodID = '" + myProdID + "'", conn);
                    MySqlDataReader reader1 = query2.ExecuteReader();
                    while (reader1.Read())
                    {
                        myStock = Convert.ToString(reader1[0]);
                        myMOQ = Convert.ToString(reader1[1]);
                    }
                    conn.Close();

                    if (decimal.Parse(myStock)<decimal.Parse(myMOQ))
                    {
                        conn.Open();
                        MySqlCommand query3 = new MySqlCommand("UPDATE tbl_product SET prodStatus = 'Stock is depleted, please make an order' WHERE prodID = '" + myProdID + "'", conn);
                        query3.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error in Updating Product - Status :" + x.ToString());
                    conn.Close();
                }
            }
            //Update changelog
            func.ChangeLog("tbl_transact", "All", "None");
            clearForm();
            //clear datagridOrdered
            dataGridOrdered.Rows.Clear();
            refreshTable();
            txtGrandTot.Text = "0";
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            Txtboxto2DecPlaces(txtPrice);
        }

        private void txtSubTotPrice_TextChanged(object sender, EventArgs e)
        {
            Txtboxto2DecPlaces(txtSubTotPrice);
        }

        private void txtDiscAmt_TextChanged(object sender, EventArgs e)
        {
            Txtboxto2DecPlaces(txtDiscAmt);
        }

        private void txtTotPrice_TextChanged(object sender, EventArgs e)
        {
            Txtboxto2DecPlaces(txtTotPrice);
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (!func.IsFloat(txtQty.Text))
            {
                //MessageBox.Show("Invalid Quantity", "", MessageBoxButtons.OK);
                txtQty.Text = "0";
                txtQty.SelectAll();
            }
            else
            {
                txtSubTotPrice.Text = Convert.ToString(decimal.Parse(txtPrice.Text) * decimal.Parse(txtQty.Text));
                txtSubTotPrice.Text = Convert.ToString(decimal.Round(decimal.Parse(txtSubTotPrice.Text + "000"), 2));
                if (txtDiscAmt.Text == "")
                {
                    txtDiscAmt.Text = "0.00";
                }
            }
            computeSubTot();
        }


        private void txtGrandTot_TextChanged(object sender, EventArgs e)
        {
            if(txtGrandTot.Text == "")
            {
                txtGrandTot.Text = "0";
            }
            Txtboxto2DecPlaces(txtGrandTot);
            lbltxtGrandTot.Text = txtGrandTot.Text;
        }

        private void Txtboxto2DecPlaces(TextBox myTextbox)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReferenceToAfterLogin.Show();
            this.Dispose();
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                comboDiscName.Focus();
            }
        }

        private void dataGridProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                getItemData();
                searchVisibility(false);
            }
        }

        private void comboDiscName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                computeSubTot();
                txtGrandTot.Text = Convert.ToString(decimal.Round((decimal.Parse(txtGrandTot.Text) + decimal.Parse(txtTotPrice.Text)), 2));
                addToOrdered();
                comboDiscName.Font = new Font("Tw Cen MT", 12);
                comboDiscName.ForeColor = Color.Black;
            }
        }

        private void getItemData()
        {
            //clearForm();

            int myRowIndex = dataGridProduct.CurrentRow.Index;

            try
            {
                txtItemName.Text = dataGridProduct.Rows[myRowIndex].Cells["Name"].Value.ToString();
                txtItemID.Text = dataGridProduct.Rows[myRowIndex].Cells["ID"].Value.ToString();
                txtPrice.Text = dataGridProduct.Rows[myRowIndex].Cells["Price"].Value.ToString();
                txtPrice.Text = Convert.ToString(decimal.Round(decimal.Parse(txtPrice.Text + "000"), 2));
            }
            catch (ArgumentOutOfRangeException) { }

            dataGridProduct.ClearSelection();
            dataGridProduct.CurrentCell = null;
            txtQty.Enabled = true;
            txtQty.Focus();
            txtQty.SelectAll();
            myboolEdit = false;
        }

        private void searchVisibility(Boolean myVisible)
        {
            pnlgridProduct.Visible = myVisible;
            dataGridProduct.Visible = myVisible;
            lblSearchID.Visible = myVisible;
            lblSearchName.Visible = myVisible;
            txtSearchID.Visible = myVisible;
            txtSearchName.Visible = myVisible;
        }


        
        //Hot Keys Handling
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                MessageBox.Show("You pressed the F1 key");
                return true;    // indicate that you handled this keystroke
            }
            else if(keyData == Keys.F12)   //Promo and Discounts
            {
                comboDiscName.Focus();
            }
            else if (keyData == Keys.F11)   //Clear
            {
                clearForm();
            }
            else if (keyData == Keys.F10)   //Select datagridOrdered
            {
                dataGridOrdered.Focus();
                dataGridOrdered.Rows[0].Selected = true;
            }
            else if (keyData == Keys.F9)   //Pay
            {
                pnlPay.Visible = true;
                txtPayCharge.Text = txtGrandTot.Text;
                txtPayCash.Text = "0.00";
                txtPayChange.Text = "0.00";
                txtPayCash.Focus();
                txtPayCash.SelectAll();
            }
            else if (keyData == Keys.F8)   //Select datagridProduct
            {
                searchVisibility(true);
                gridProductLoad("SELECT prodID AS 'ID', prodName AS 'Name', prodUPrice AS 'Price', prodStock AS 'Stock', prodUnit AS 'Unit' FROM tbl_product");
                dataGridProduct.Focus();
                dataGridProduct.Rows[0].Selected = true;
                dataGridProduct.CurrentCell.Selected = false;
            }
            else if (keyData == Keys.F7)   //Search Item ID
            {
                searchVisibility(true);
                txtSearchID.Text = "";
                txtSearchName.Focus();
            }
            else if (keyData == Keys.F6)   //Search Item Name
            {
                searchVisibility(true);
                txtSearchName.Text = "";
                txtSearchID.Focus();
            }
            else if(keyData==Keys.Escape)     //Close Window
            {
                ReferenceToAfterLogin.Show();
                this.Dispose();
            }
            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void dataGridOrdered_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                transferData();
                txtQty.Focus();
                txtGrandTot.Text = Convert.ToString(decimal.Round((decimal.Parse(txtGrandTot.Text) - decimal.Parse(txtSubTotPrice.Text)), 2));
                myboolEdit = true;
            }
        }

        public int myRowIndex;
        private void transferData()
        {
            clearForm();
            myRowIndex = dataGridOrdered.CurrentRow.Index;
            try
            {
                txtItemName.Text = dataGridOrdered.Rows[myRowIndex].Cells["Item"].Value.ToString();
                txtItemID.Text = dataGridOrdered.Rows[myRowIndex].Cells["Item ID"].Value.ToString();
                txtPrice.Text = dataGridOrdered.Rows[myRowIndex].Cells["U Price"].Value.ToString();
                txtPrice.Text = Convert.ToString(decimal.Round(decimal.Parse(txtPrice.Text + "000"), 2));
                txtQty.Text = dataGridOrdered.Rows[myRowIndex].Cells["Qty"].Value.ToString();
            }
            catch (ArgumentOutOfRangeException) { }
            txtQty.Enabled = true;
        }

        private void txtSearchID_TextChanged(object sender, EventArgs e)
        {
            gridProductLoad("SELECT prodID AS 'ID', prodName AS 'Name', prodUPrice AS 'Price', prodStock AS 'Stock', prodUnit AS 'Unit' FROM tbl_product where prodID like '%" + txtSearchID.Text + "%'");
        }
        private void txtSearchID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                dataGridProduct.Focus();
                dataGridProduct.Rows[0].Selected = true;
            }

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            gridProductLoad("SELECT prodID AS 'ID', prodName AS 'Name', prodUPrice AS 'Price', prodStock AS 'Stock', prodUnit AS 'Unit' FROM tbl_product where prodName like '%" + txtSearchName.Text + "%'");
        }
        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter || e.KeyCode==Keys.Up || e.KeyCode==Keys.Down)
            {
                dataGridProduct.Focus();
            }
        }

        private void txtPayCharge_TextChanged(object sender, EventArgs e)
        {
            Txtboxto2DecPlaces(txtPayCharge);
        }
        private void txtPayCharge_Enter(object sender, EventArgs e)
        {
            txtPayCash.Focus();
        }

        private void txtPayCash_TextChanged(object sender, EventArgs e)
        {
            if (!func.IsFloat(txtQty.Text))
            {
                //MessageBox.Show("Invalid Quantity", "", MessageBoxButtons.OK);
                txtQty.Text = "0";
                txtQty.SelectAll();
            }
        }
        private void txtPayCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPayChange.Text = Convert.ToString(decimal.Round((decimal.Parse(txtPayCash.Text) - decimal.Parse(txtPayCharge.Text)), 2));
                if ((decimal.Parse(txtPayChange.Text) < 0))
                {
                    MessageBox.Show("Payment is less than the Charge Amount!!", "", MessageBoxButtons.OK);
                    txtPayCash.Focus();
                    txtPayCash.SelectAll();
                }
                else
                {
                    Txtboxto2DecPlaces(txtPayCash);
                    btnClosePay.Visible = true;
                    btnClosePay.Focus();
                }
            }
        }

        private void txtPayChange_TextChanged(object sender, EventArgs e)
        {
            Txtboxto2DecPlaces(txtPayChange);
        }
        private void txtPayChange_Enter(object sender, EventArgs e)
        {
            txtPayCash.Focus();
        }

        private void btnClosePay_Click(object sender, EventArgs e)
        {
            pnlPay.Visible = false;
            btnClosePay.Visible = false;
            btnCheckout_Click(sender, e);
        }

        private void comboDiscName_Enter(object sender, EventArgs e)
        {
            comboDiscName.Font = new Font("Tw Cen MT", 20);
            comboDiscName.ForeColor = Color.Maroon;
        }

    }
}
