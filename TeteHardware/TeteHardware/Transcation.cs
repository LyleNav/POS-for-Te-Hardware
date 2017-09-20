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
    public partial class formTranscation : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //Reference formEmployeeManage to this form
        public MySqlConnection conn; //connection
        Test func = new Test();

        public formTranscation()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //form transition using timer
            timer1.Start(); //form transition using timer
        }

        private void Transcation_Load(object sender, EventArgs e)
        {
            this.calTrans.Location = new Point(655, 12);
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
            txtDiscAmt.Text = txtDiscAmt.Text + "000";
            txtTotPrice.Text = Convert.ToString(decimal.Round((decimal.Parse(txtSubTotPrice.Text) - decimal.Parse(txtDiscAmt.Text)), 2));

        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearForm();
            try
            {
                txtItemName.Text = dataGridProduct.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtItemID.Text = dataGridProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtPrice.Text = dataGridProduct.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                txtPrice.Text = Convert.ToString(decimal.Round(decimal.Parse(txtPrice.Text + "000"),2));
            }
            catch (ArgumentOutOfRangeException) { }
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
            //add prodID, prodName, Qty, UnitPrice, SubTotPrice, PromoID, DiscPrice and TotPrice to a grid
            string[] myData = new string[]
            {txtItemID.Text, txtItemName.Text, txtQty.Text, txtPrice.Text, txtSubTotPrice.Text, comboDiscID.Text, txtDiscAmt.Text, txtTotPrice.Text};
            dataGridOrdered.Rows.Add(myData);
            //clear the form
            clearForm();
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
                MySqlCommand query = new MySqlCommand("SELECT RIGHT(transNum, 7) AS myTranNum FROM tbl_transact WHERE LEFT(prodID, 4) = '" + myTransNum4 + "' ORDER BY transNum", conn);
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
                    if (decimal.Parse(myStock) < decimal.Parse(myMOQ))
                    {
                        conn.Open();
                        MySqlCommand query3 = new MySqlCommand("UPDATE tbl_product SET prodStatus = 'Stock is depleted, please make an order' WHERE prodID = '" + myProdID + "'", conn);
                        query3.ExecuteNonQuery();
                        conn.Close();
                    }
                    else{}
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
        }
        public string str2Dec(string myString, int myType)
        {
            string myValueStr = "";

            return myValueStr;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            Strto2DecPlaces(txtPrice);
        }

        private void txtSubTotPrice_TextChanged(object sender, EventArgs e)
        {
            Strto2DecPlaces(txtSubTotPrice);
        }

        private void txtDiscAmt_TextChanged(object sender, EventArgs e)
        {
            Strto2DecPlaces(txtDiscAmt);
        }

        private void txtTotPrice_TextChanged(object sender, EventArgs e)
        {
            Strto2DecPlaces(txtTotPrice);
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (!func.IsFloat(txtQty.Text))
            {
                MessageBox.Show("Invalid Quantity", "", MessageBoxButtons.OK);
            }
            else
            {
                txtSubTotPrice.Text = Convert.ToString(decimal.Parse(txtPrice.Text) * decimal.Parse(txtQty.Text));
                txtSubTotPrice.Text = Convert.ToString(decimal.Round(decimal.Parse(txtSubTotPrice.Text + "000"), 2));
                if (txtDiscAmt.Text == "")
                {
                    txtDiscAmt.Text = "0.00";
                }
                txtDiscAmt.Text = txtDiscAmt.Text + "000";
                txtTotPrice.Text = Convert.ToString(decimal.Round((decimal.Parse(txtSubTotPrice.Text) - decimal.Parse(txtDiscAmt.Text)), 2));
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReferenceToAfterLogin.Show();
            this.Dispose();
        }
    }
}
