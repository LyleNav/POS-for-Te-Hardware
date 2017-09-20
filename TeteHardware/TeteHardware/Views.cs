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
    public partial class formViews : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //Reference formEmployeeManage to this form
        public MySqlConnection conn; //connection
        public string myType;
        Test func = new Test();
        string myParent = "";
        string myChild = "";
        string myDateSQL = "";
        string myIDfordatagridtableChild = "";
        string myParentselectCommand = "";
        string myChildselectCommand = "";
        string myOrderSQL = "";
        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse

        public formViews()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //form transition using timer
            timer1.Start(); //form transition using timer
        }

        private void formViews_Load(object sender, EventArgs e)
        {
            //set Dates
            txtDateFrom.Text = DateTime.Now.ToString();
            txtDateTo.Text = DateTime.Now.ToString();
            populateComboParent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        //mouse handling
        private void formViews_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formViews_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formViews_MouseUp(object sender, MouseEventArgs e)
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
                if(myType == "Report")
                {
                    ClsPrint ClsPrint = new ClsPrint(datagridTableChild, "Yoyo");
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
            ReferenceToAfterLogin.btnReport_Click(sender, e);
            this.Dispose();
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
            txtDateTo.Focus();
        }
        private void monCalTo_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDateTo.Text = monCalTo.SelectionRange.Start.ToShortDateString();
            monCalTo.Visible = false;
        }

        private void populateComboParent()
        {
            comboParent.Items.Clear();
            comboParent.Items.Add("Category");
            comboParent.Items.Add("Supplier");
            comboParent.Items.Add("Product");
            comboParent.Items.Add("Promo");
            comboParent.Items.Add("Transaction");
            comboParent.SelectedIndex = 0;
        }

        private void populateComboChild(string myParent)
        {
            comboChild.Items.Clear();
            if (myParent == "Category")
            {
                comboChild.Items.Add("Products");
                comboChild.Items.Add("Sales");
                comboChild.Items.Add("Good Deliveries");
                comboChild.Items.Add("Defective Deliveries");
                comboChild.Items.Add("In-store Damage");
            }
            else if (myParent == "Supplier")
            {
                comboChild.Items.Add("Products");
                comboChild.Items.Add("Good Deliveries");
                comboChild.Items.Add("Defective Deliveries");
                comboChild.Items.Add("Returned To Supplier");
            }
            else if (myParent == "Product")
            {
                comboChild.Items.Add("Sales");
                comboChild.Items.Add("Returned To Supplier");
                comboChild.Items.Add("Returns from Customer");
                comboChild.Items.Add("In-store Damage");
            }
            else if (myParent == "Promo")
            {
                comboChild.Items.Add("Sales");
            }
            else if (myParent == "Transaction")
            {
                comboChild.Items.Add("Sales");
            }
            comboChild.SelectedIndex = 0;
        }

        //Setup for datagridTableChild
        private void setupforDatagridChild()
        {
            //re-run general setupfor datagridchild to get the original selectCommand
            genSetupfordatagridChild();
            int myRowIndex = datagridTableParent.CurrentRow.Index;
            lblDetails.Text = "Details for " + comboParent.Text + " by " + comboChild.Text + ": " + datagridTableParent.Rows[myRowIndex].Cells[1].Value.ToString();
            switch (myParent)
            {
                case "Category":
                    {
                        myIDfordatagridtableChild = datagridTableParent.Rows[myRowIndex].Cells[0].Value.ToString();
                        switch (myChild)
                        {
                            case "Products":
                                {
                                    myChildselectCommand = myChildselectCommand + " WHERE LEFT(prodID,2) = '" + myIDfordatagridtableChild + "'";
                                    break;
                                }
                            default:
                                {
                                    myChildselectCommand = myChildselectCommand + " AND LEFT(b.prodID,2) = '" + myIDfordatagridtableChild + "'";
                                    break;
                                }
                        }
                        break;
                    }
                case "Supplier":
                    {
                        myIDfordatagridtableChild = datagridTableParent.Rows[myRowIndex].Cells[0].Value.ToString();
                        switch (myChild)
                        {
                            case "Products":
                                {
                                    myChildselectCommand = myChildselectCommand + " AND a.supID = '" + myIDfordatagridtableChild + "'";
                                    break;
                                }
                            default:
                                {
                                    myChildselectCommand = myChildselectCommand + " AND a.supID = '" + myIDfordatagridtableChild + "'";
                                    break;
                                }
                        }
                        break;
                    }
                case "Product":
                    {
                        myIDfordatagridtableChild = datagridTableParent.Rows[myRowIndex].Cells[0].Value.ToString();
                        switch(myChild)
                        {
                            case "Returns from Customer":
                                {
                                    myChildselectCommand = myChildselectCommand + " AND b.prodID = '" + myIDfordatagridtableChild + "'";
                                    break;
                                }
                            default:
                                {
                                    myChildselectCommand = myChildselectCommand + " AND b.prodID = '" + myIDfordatagridtableChild + "'";
                                    break;
                                }
                        }
                        break;
                    }
                case "Promo":
                    {
                        myIDfordatagridtableChild = datagridTableParent.Rows[myRowIndex].Cells[0].Value.ToString();
                        myChildselectCommand = myChildselectCommand + " AND c.promoID = '" + myIDfordatagridtableChild + "'";
                        break;
                    }
                case "Transaction":
                    {
                        myIDfordatagridtableChild = datagridTableParent.Rows[myRowIndex].Cells[0].Value.ToString();
                        myChildselectCommand = myChildselectCommand + " AND a.transNum = '" + myIDfordatagridtableChild + "'";

                        break;
                    }
            }
            if (myDateSQL == "")
            {
                populatedatagridChild(myChildselectCommand);
            }
            else
            {
                populatedatagridChild(myChildselectCommand + " AND " + myDateSQL);
            }
        }


            //Set datagridParents tbl here
            private void comboParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            myParent = comboParent.Text;
            populateComboChild(myParent);
            if(myParent=="Category")
            {
                myParentselectCommand = "SELECT catID as 'Catalog ID', catName as 'Catalog Name' FROM tbl_ProductCatalog";
            }
            else  if (myParent == "Supplier")
            {
                myParentselectCommand = "SELECT supID as 'Supplier ID', supName as 'Supplier Name' FROM tbl_Supplier";
            }
            else if (myParent == "Product")
            {
                myParentselectCommand = "SELECT prodID as 'Product ID', prodName as 'Product Name', prodDesc FROM tbl_Product";
            }
            else if (myParent == "Promo")
            {
                myParentselectCommand = "SELECT promoID as 'Promo ID', promoName as 'Promo Name' FROM tbl_Promo";
            }
            else if (myParent == "Transaction")
            {
                myParentselectCommand = "SELECT DISTINCT transNum as 'Transaction Number', transDate as 'Date Sold' FROM tbl_Transact";
            }
            populatedatagridTableParent(myParentselectCommand);
            datagridTableParent.ClearSelection();
        }
        private void populatedatagridTableParent(string selectCommand)
        {
            datagridTableParent.DataSource = null;      //remove datasource link for datagridProduct
            try
            {
                conn.Open(); //opens the connection
                //MessageBox.Show(selectCommand, "", MessageBoxButtons.OK);
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
                datagridTableParent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in populating datagridTable : " + x.ToString());
                conn.Close();
            }
        }

        //set datagridChild tbl here
        private void comboChild_SelectedIndexChanged(object sender, EventArgs e)
        {
            genSetupfordatagridChild();
            if (myDateSQL == "")
            {
                populatedatagridChild(myChildselectCommand + myOrderSQL);
            }
            else
            {
                populatedatagridChild(myChildselectCommand + " AND " + myDateSQL + myOrderSQL);
            }
            datagridTableParent.ClearSelection();
        }

        private void genSetupfordatagridChild()
        {
            myChild = comboChild.Text;
            if (myChild == "Products")
            {
                if (myParent == "Category")
                {
                    myDateSQL = "";
                    myOrderSQL = " ORDER BY prodName";
                    myChildselectCommand = "SELECT prodName as 'Item', prodDesc as 'Description', prodStock as 'Stocks', prodUnit as 'unit', prodMOQ as 'Ordering Level', prodStatus as 'Details' FROM tbl_Product";
                }
                else if (myParent == "Supplier")
                {
                    myDateSQL = "";
                    myOrderSQL = " ORDER BY prodName";
                    myChildselectCommand = "SELECT c.arrRef as 'Reference', b.prodName as 'Item', b.prodDesc as 'Description', b.prodStock as 'Stocks', b.prodUnit as 'unit', b.prodStatus as'Details' FROM tbl_supplier a, tbl_product b, tbl_arr c WHERE c.supID = a.supID AND b.prodID = c.prodID";
                }

            }
            else if (myChild == "Sales")
            {
                if (myParent == "Promo")
                {
                    myDateSQL = "transDate between '" + txtDateFrom.Text + "' AND '" + txtDateTo.Text + "'";
                    myOrderSQL = " ORDER BY promoName";
                    myChildselectCommand = "SELECT c.promoName as 'Promo', b.prodName as 'Product', a.transDate as 'Date Sold', a.transQty as 'Qty', b.prodUnit as 'unit', ROUND(a.transTotPrice, 2) as 'Total Sales', c.promoName as 'Availed Promo', ROUND(a.transDiscount+'000', 2) as 'Discount' FROM tbl_Transact a, tbl_Product b, tbl_promo c WHERE b.prodID = a.prodID AND c.promoID = a.promoID";
                }
                else if (myParent == "Transaction")
                {
                    myDateSQL = "transDate between '" + txtDateFrom.Text + "' AND '" + txtDateTo.Text + "'";
                    myOrderSQL = " ORDER BY transNum";
                    myChildselectCommand = "SELECT a.transNum as 'Transaction', a.transDate as 'Date Sold', b.prodName as 'Product', transQty as 'Qty', b.prodUnit as 'unit', ROUND(transTotPrice + '000', 2) as 'Total Sales', c.promoName as 'Availed Promo', ROUND(transDiscount, 2) as 'Discount' FROM tbl_transact a, tbl_product b, tbl_promo c WHERE b.prodID = a.prodID and c.promoID = a.promoID";
                }
                else
                {
                    myDateSQL = "transDate between '" + txtDateFrom.Text + "' AND '" + txtDateTo.Text + "'";
                    myOrderSQL = " ORDER BY prodName";
                    myChildselectCommand = "SELECT b.prodName as 'Name', a.transDate as 'Date Sold', a.transQty as 'Qty', b.prodUnit as 'unit', ROUND(a.transTotPrice, 2) as 'Total Sales', c.promoName as 'Availed Promo', ROUND(a.transDiscount, 2) as 'Discount' FROM tbl_Transact a, tbl_Product b, tbl_promo c WHERE b.prodID = a.prodID AND c.promoID = a.promoID";
                }
            }
            else if (myChild == "Good Deliveries")
            {
                myDateSQL = "dateArrival between '" + txtDateFrom.Text + "' AND '" + txtDateTo.Text + "'";
                myOrderSQL = " ORDER BY prodName";
                myChildselectCommand = "SELECT b.prodName as 'Name', c.supName as 'Supplier', a.dateArrival as 'Date Arrived', a.Quantity as 'Qty', a.Status as 'Details' from tbl_arr a, tbl_product b, tbl_supplier c WHERE b.prodID = a.prodID AND c.supID = a.supID";
            }
            else if (myChild == "Defective Deliveries")
            {
                myDateSQL = "dateArrival between '" + txtDateFrom.Text + "' AND '" + txtDateTo.Text + "'";
                myOrderSQL = " ORDER BY prodName";
                myChildselectCommand = "SELECT b.prodName as 'Name', c.supName as 'Supplier', a.dateArrival as 'Date Arrived', a.Quantity as 'Qty', a.Status as 'Details' from tbl_arrdef a, tbl_product b, tbl_supplier c WHERE b.prodID = a.prodID AND c.supID = a.supID";
            }
            else if (myChild == "Returned To Supplier")
            {
                myDateSQL = "";
                myOrderSQL = " ORDER BY supName";
                myChildselectCommand = "SELECT b.supName as 'Supplier', c.prodName as 'Product', a.retQty as 'Qty', a.retDate as 'Date Returned', a.retDefect as 'Defect', a.retRef as 'Reference' from tbl_returnto a, tbl_supplier b, tbl_product c WHERE b.supID = a.supID AND c.prodID =  a.prodID";
            }
            else if (myChild == "Returns from Customer")
            {
                myDateSQL = "";
                myOrderSQL = " ORDER BY retDate";
                myChildselectCommand = "SELECT  a.custName as 'Customer', b.prodName as 'Item', a.retQty as 'Qty', a.retDate as 'Date Returned', a.transNum as 'Transaction No', a.retDefect as 'Defect' FROM tbl_returnfrom a, tbl_product b WHERE b.prodID = a.prodID";
            }
            else if (myChild == "In-store Damage")
            {
                myDateSQL = "";
                myOrderSQL = " ORDER BY prodName";
                myChildselectCommand = "SELECT b.prodName as 'Product', a.damBy as 'Damaged By', damQty as 'Qty', damDate as 'Date Damaged', damDetails as 'Details' from tbl_damage a, tbl_product b WHERE b.prodID = a.prodID";
            }

        }

        private void populatedatagridChild(string selectCommand)
        {
            datagridTableChild.DataSource = null;      //remove datasource link for datagridProduct
            //MessageBox.Show(selectCommand, "", MessageBoxButtons.OK);
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand(selectCommand, conn); //query to select all entries in tbl_productcatalog
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                BindingSource bs1 = new BindingSource();
                dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adp.Fill(dt);
                bs1.DataSource = dt;
                datagridTableChild.DataSource = bs1;
                conn.Close();
                
                //Align datagridview
                for (int i = 0; i < datagridTableChild.ColumnCount; i++)
                {
                    setDatagridChildAlignment(i);
                }
                //                datagridTableChild.AutoResizeColumns();
                //                datagridTableChild.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                if (!(myChild == "Sales"))
                {
                    datagridTableChild.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    datagridTableChild.Columns[datagridTableChild.ColumnCount - 1].Width = 400;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in populating datagridTableChild : " + x.ToString());
                conn.Close();
            }
        }

        private void datagridTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setupforDatagridChild();
        }

        private void datagridTable_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                setupforDatagridChild();
            }
        }

        private void setDatagridChildAlignment(int mycolNum)
        {
            if (datagridTableChild.Columns[mycolNum].Name == "Total Sales" || datagridTableChild.Columns[mycolNum].Name == "Discount")
            {
                datagridTableChild.Columns[mycolNum].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                datagridTableChild.Columns[mycolNum].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopRight;
                datagridTableChild.Columns[mycolNum].DefaultCellStyle.Format = "0.00##";
            }
            else if (datagridTableChild.Columns[mycolNum].Name == "Qty" || datagridTableChild.Columns[mycolNum].Name == "Stocks" || datagridTableChild.Columns[mycolNum].Name == "Ordering Level")
            {
                datagridTableChild.Columns[mycolNum].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
                datagridTableChild.Columns[mycolNum].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            }
            else
            {
                datagridTableChild.Columns[mycolNum].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                datagridTableChild.Columns[mycolNum].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopLeft;
            }
            datagridTableChild.AutoResizeColumns();
        }
    }
}
