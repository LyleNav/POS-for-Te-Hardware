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
using System.Collections;
using System.Drawing.Printing;


namespace TeteHardware
{
    public partial class formReports : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //Reference formEmployeeManage to this form
        public MySqlConnection conn; //connection
        public string myType;
        Test func = new Test();
        string myParent = "";
        string myChild = "";
        float myGroupDiscount = 0;
        float myTotDiscount = 0;
        float myGroupSales = 0;
        float myTotSales = 0;
        //string myParentTable = "";
        string mySelectSQLParent = "";
        string mySelectSQLChild = "";
        string myID = "";
        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        int myCounter;

        public formReports()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //form transition using timer
            timer1.Start(); //form transition using timer
        }

        private void formReports_Load(object sender, EventArgs e)
        {
            int myScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int myScreenHeight = Screen.PrimaryScreen.Bounds.Height;
//            this.Size = new Size(530, 300);
            this.Location = new Point((myScreenWidth - this.Width) / 2, (myScreenHeight - this.Height) / 2);
            //            btnPrintRep.Location = new Point((this.Width - btnPrintRep.Width) / 2, 225);
            //           btnPrintRep.Visible = true;
            //            datagridTable.Visible = false;
            //            datagridTableChild.Visible = false;
            //set Dates
            datagridTableChild.RowTemplate.Height = 60;
            txtDateFrom.Text = DateTime.Now.ToString();
            txtDateTo.Text = DateTime.Now.ToString();
            populateComboReport();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        //mouse handling
        private void formReports_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formReports_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formReports_MouseUp(object sender, MouseEventArgs e)
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
            if (keyData == Keys.F5)   // To print report
            {
                if (myType == "Report")
                {
                    ClsPrint ClsPrint = new ClsPrint(datagridTableChild, comboReports.Text);
                    ClsPrint.PrintForm();
                }
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

        //Buttons Handling - put all codes for any buttons here
        private void btnClose_Click(object sender, EventArgs e)
        {
            ReferenceToAfterLogin.Show();
            this.Dispose();
        }
        private void btnPrintRep_Click(object sender, EventArgs e)
        {
            ClsPrint ClsPrint = new ClsPrint(datagridTableChild, comboReports.Text);
            ClsPrint.PrintForm();
        }

        //Date Handling - put all dates here
        private void txtDateFrom_Enter(object sender, EventArgs e)
        {
            monCalFrom.Location = txtDateFrom.Location;
            monCalFrom.Visible = true;
            monCalFrom.Focus();
        }
        private void txtDateTo_Enter(object sender, EventArgs e)
        {
            monCalTo.Location = txtDateTo.Location;
            monCalTo.Visible = true;
            monCalTo.Focus();
        }
        private void monCalFrom_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateFrom.Text = monCalFrom.SelectionRange.Start.ToShortDateString();
            txtDateTo.Text = monCalFrom.SelectionRange.Start.ToShortDateString();
            monCalFrom.Visible = false;
        }
        private void monCalTo_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateTo.Text = monCalTo.SelectionRange.Start.ToShortDateString();
            monCalTo.Visible = false;
        }

        //Controls Handling

        private void populateComboReport()
        {
            comboReports.Items.Clear();
            comboReports.Items.Add("Sales by Product");
            comboReports.Items.Add("Sales by Category");
            comboReports.Items.Add("Inventory by Products");
            comboReports.Items.Add("Products by Category");
            comboReports.Items.Add("Products by Supplier");
            comboReports.Items.Add("Good Deliveries by Supplier");
            comboReports.Items.Add("Bad Deliveries by Supplier");
            comboReports.Items.Add("Good Deliveries by Product");
            comboReports.Items.Add("Bad Deliveries by Product");
            comboReports.Items.Add("Returns To Supplier by Product");
            comboReports.Items.Add("Returns by Supplier");
            comboReports.Items.Add("Returns From Customer by Product");
            comboReports.Items.Add("Inhouse Damage by Product");
        }

        private void comboReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            int myRowIndex = comboReports.SelectedIndex;
            switch (myRowIndex)
            {
                case 0:
                    {
                        myParent = "Product";
                        myChild = "Sales";
                        populatedatagridParent("SELECT prodID, prodName from tbl_product ORDER by prodName");
                        //set up datagridchild columns
                        datagridTableChild.Rows.Clear();
                        datagridTableChild.ColumnCount = 6;
                        datagridTableChild.ColumnHeadersVisible = true;
                        datagridTableChild.Columns[0].Name = "Product";
                        datagridTableChild.Columns[1].Name = "Sales Date";
                        datagridTableChild.Columns[2].Name = "Quantity";
                        datagridTableChild.Columns[3].Name = "Unit";
                        datagridTableChild.Columns[4].Name = "Sales";
                        datagridTableChild.Columns[5].Name = "Discount";
                        datagridTableChild.Columns["Product"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                        datagridTableChild.Columns["Sales Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                        datagridTableChild.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                        datagridTableChild.Columns["Unit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                        datagridTableChild.Columns["Sales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                        datagridTableChild.Columns["Discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                        
                        myTotSales = 0;
                        myTotDiscount = 0;
                        for (int i = 0; i < datagridTableParent.RowCount; i++)
                        {
                            myGroupSales = 0;
                            myGroupDiscount = 0;
                            datagridTableParent.Rows[i].Selected = true;
                            myID = datagridTableParent.Rows[i].Cells["prodID"].Value.ToString();
                            mySelectSQLChild = "SELECT a.prodName, b.transDate, b.transQty, a.prodUnit, b.transTotPrice, b.transDiscount from tbl_product a, tbl_transact b WHERE a.prodID = b.prodID AND b.prodID ='"+ myID +"'";
                            try
                            {
                                conn.Open();
                                MySqlCommand query = new MySqlCommand(mySelectSQLChild, conn);
                                MySqlDataReader reader = query.ExecuteReader();
                                while (reader.Read())
                                {
                                    datagridTableChild.Rows.Add(reader[0], reader[1], reader[2], reader[3], func.stringToDecimal(reader[4].ToString(),2), func.stringToDecimal(reader[5].ToString(),2));
                                    myTotSales = myTotSales + float.Parse(reader[4].ToString());
                                    myTotDiscount = myTotDiscount + float.Parse(reader[5].ToString());
                                    myGroupSales = myGroupSales + float.Parse(reader[4].ToString());
                                    myGroupDiscount = myGroupDiscount + float.Parse(reader[5].ToString());
                                }
                                conn.Close();
                                datagridTableChild.Rows.Add("Sub-Total", "", "", "", myGroupSales.ToString("#,#.00#"), myGroupDiscount.ToString("#,#.00#"));
                            }
                            catch (Exception x)

                            {
                                MessageBox.Show("Error in Load:" + x.ToString());
                                conn.Close();
                            }
                        }
                        datagridTableChild.Rows.Add("Grand Total", "", "", "", myTotSales.ToString("#,#.00#"),myTotDiscount.ToString("#,#.00#"));
                        break;
                    }
                case 1:
                    {
                        myParent = "Category";
                        myChild = "Sales";
                        populatedatagridParent("SELECT catID, catName from tbl_productcatalog ORDER by catName");
                        //set up datagridchild columns
                        datagridTableChild.Rows.Clear();
                        datagridTableChild.ColumnCount = 5;
                        datagridTableChild.ColumnHeadersVisible = true;
                        datagridTableChild.Columns[0].Name = "Product";
                        datagridTableChild.Columns[1].Name = "Sales Date";
                        datagridTableChild.Columns[2].Name = "Quantity";
                        datagridTableChild.Columns[3].Name = "Sales";
                        datagridTableChild.Columns[4].Name = "Discount";
                        datagridTableChild.Columns["Product"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                        datagridTableChild.Columns["Sales Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                        datagridTableChild.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                        datagridTableChild.Columns["Sales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                        datagridTableChild.Columns["Discount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;

                        myTotSales = 0;
                        myTotDiscount = 0;
                        for (int i = 0; i < datagridTableParent.RowCount; i++)
                        {
                            myGroupSales = 0;
                            myGroupDiscount = 0;
                            datagridTableParent.Rows[i].Selected = true;
                            myID = datagridTableParent.Rows[i].Cells["catID"].Value.ToString();
                            //MessageBox.Show("SELECT a.catName, b.transDate, b.transQty, b.transTotPrice, b.transDiscount from tbl_productcatalog a, tbl_transact b WHERE a.prodID = left(b.prodID,2) AND left(b.prodID,2) ='" + myID + "'", "", MessageBoxButtons.OK);
                            mySelectSQLChild = "SELECT a.catName, b.transDate, b.transQty, b.transTotPrice, b.transDiscount from tbl_productcatalog a, tbl_transact b WHERE a.catID = left(b.prodID,2) AND left(b.prodID,2) ='" + myID + "'";
                            try
                            {
                                conn.Open();
                                MySqlCommand query = new MySqlCommand(mySelectSQLChild, conn);
                                MySqlDataReader reader = query.ExecuteReader();
                                while (reader.Read())
                                {
                                    datagridTableChild.Rows.Add(reader[0], reader[1], reader[2], func.stringToDecimal(reader[3].ToString(), 2), func.stringToDecimal(reader[4].ToString(), 2));
                                    myTotSales = myTotSales + float.Parse(reader[3].ToString());
                                    myTotDiscount = myTotDiscount + float.Parse(reader[4].ToString());
                                    myGroupSales = myGroupSales + float.Parse(reader[3].ToString());
                                    myGroupDiscount = myGroupDiscount + float.Parse(reader[4].ToString());
                                }
                                conn.Close();
                                datagridTableChild.Rows.Add("Sub-Total", "", "", myGroupSales.ToString("#,#.00#"), myGroupDiscount.ToString("#,#.00#"));
                            }
                            catch (Exception x)

                            {
                                MessageBox.Show("Error in Load:" + x.ToString());
                                conn.Close();
                            }
                        }
                        datagridTableChild.Rows.Add("Grand Total", "", "", myTotSales.ToString("#,#.00#"), myTotDiscount.ToString("#,#.00#"));
                        break;
                    }
                case 2:
                    {
                        myParent = "Product";
                        myChild = "Product";
                        break;
                    }
                case 3:
                    {
                        myParent = "Category";
                        myChild = "Product";
                        break;
                    }
                case 4:
                    {
                        myParent = "Supplier";
                        myChild = "Product";
                        break;
                    }
                case 5:
                    {
                        myParent = "Supplier";
                        myChild = "Arr";
                        break;
                    }
                case 6:
                    {
                        myParent = "Supplier";
                        myChild = "Arrdef";
                        break;
                    }
                case 7:
                    {
                        myParent = "Product";
                        myChild = "Arr";
                        break;
                    }
                case 8:
                    {
                        myParent = "Product";
                        myChild = "Arrdef";
                        break;
                    }
                case 9:
                    {
                        myParent = "Product";
                        myChild = "Returnto";
                        break;
                    }
                case 10:
                    {
                        myParent = "Supplier";
                        myChild = "ReturnTo";
                        break;
                    }
                case 11:
                    {
                        myParent = "Product";
                        myChild = "ReturnFrom";
                        break;
                    }
                case 12:
                    {
                        myParent = "Product";
                        myChild = "Damage";
                        break;
                    }
            }

            switch (myParent)
            {
                case "Product":
                    {
                        mySelectSQLParent = "SELECT prodID, prodName from tbl_product ORDER by prodName";
                        break;
                    }
                case "Supplier":
                    {
                        mySelectSQLParent = "SELECT supID, supName from tbl_supplier ORDER by supName";
                        break;
                    }
                case "Category":
                    {
                        mySelectSQLParent = "SELECT catID, catName from tbl_productcatalog ORDER by catName";
                        break;
                    }
            }
        }


        private void populatedatagridParent(string selectCommand)
        {
            datagridTableParent.DataSource = null;      //remove datasource link for datagridProduct
            //MessageBox.Show("Parent - " + selectCommand,"",MessageBoxButtons.OK);
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
                datagridTableParent.DataSource = bs;
                conn.Close();
                datagridTableParent.AutoResizeColumns();
                datagridTableParent.AutoResizeRows();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in populating datagridTable : " + x.ToString());
                conn.Close();
            }
        }


        //set datagridChild tbl here

        private void populatedatagridChild(string selectCommand)
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand(selectCommand, conn);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    datagridTableChild.Rows.Add();
                }
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Child table:" + x.ToString());
                conn.Close();
            }
        }
    }
}
