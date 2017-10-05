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
    public partial class formEditProduct : Form
    {
        public formProductManage ReferenceToProdManage { get; set; } //Reference formCatalogManage to this form
        public MySqlConnection conn; //connection
        Test func = new Test();
        public string prodID, prodName, prodDesc, prodUnit, prodStatus, myField, oldValues;
        public int empID;
        public float prodPrice, prodStock, prodMOQ;
        public string oldDesc, oldStatus, newDesc, newStatus;
        public int oldEmpID, newEmpID;
        public float oldPrice, newPrice, oldMOQ, newMOQ;

        private void txtMOQ_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMOQ.Text, "  ^ [0-9]"))
            {
                txtMOQ.Text = "";
            }
        }

        private void txtMOQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) //with decimals
            {
                e.Handled = true;
            }
        }

        private void txtPprice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPprice.Text, "  ^ [0-9]"))
            {
                txtPprice.Text = "";
            }
        }

        private void txtPprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) //with decimals
            {
                e.Handled = true;
            }
        }

        public formEditProduct()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //form transition using timer
            timer1.Start(); //form transition using timer
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        private void formEditProduct_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT catName FROM tbl_productcatalog WHERE catID = LEFT('" + prodID + "', 2)", conn);
                MySqlDataReader reader = query.ExecuteReader();
                while(reader.Read())
                {
                    txtPcat.Text = Convert.ToString(reader[0]);
                }

                conn.Close();
            }
            catch(Exception x)
            {
                MessageBox.Show("Error in Load:" + x.ToString());
                conn.Close();
            }
            txtPid.Text = prodID;
            txtPname.Text = prodName;
            txtPdesc.Text = prodDesc;
            txtMOQ.Text = prodMOQ.ToString();
            txtPstock.Text = prodStock.ToString();
            txtPprice.Text = prodPrice.ToString();
            txtPunit.Text = prodUnit;
            txtPstatus.Text = prodStatus;

            oldDesc = prodDesc;
            oldMOQ = prodMOQ;
            oldPrice = prodPrice;
            oldStatus = prodStatus;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPdesc.Text = "";
            txtMOQ.Text = "";
            txtPprice.Text = "";
            txtPstatus.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        bool mouseDown; //boolean for mousedown


        Point lastLocation; //variable for the last location of the mouse
        private void EditProduct_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void EditProduct_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void EditProduct_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtPcat.Text == "" || txtPname.Text == "" || txtPdesc.Text == "" || txtMOQ.Text == "" || txtPstock.Text == "" || txtPprice.Text == "" || txtPunit.Text == "") //DATA VALIDATION
            {
                MessageBox.Show("Please supply all necessary fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows a message box if textboxes are blank
            }
            else
            {
                Edit();
                this.Close();
            }
        }

        private void EditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToProdManage.Show(); //shows the previous form upon exiting the current form
        }

        private void Edit()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_product WHERE prodID = '" + prodID + "'", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("UPDATE tbl_product SET empID = '" + TeteHardware.Properties.Settings.Default.loginID + "', prodDesc = '" + txtPdesc.Text + "', prodMOQ = '" + txtMOQ.Text + "', prodUPrice = '" + txtPprice.Text + "', prodStatus = '" + txtPstatus.Text + "' WHERE prodID = '" + prodID + "'", conn);
                query1.ExecuteNonQuery();
                MySqlCommand query2 = new MySqlCommand("SELECT empID, prodDesc, prodMOQ, prodUPrice, prodStatus FROM tbl_product WHERE prodID = '" + prodID + "'", conn);
                MySqlDataReader reader = query2.ExecuteReader();
                myField = "";
                oldValues = "";
                while (reader.Read())
                {
                    newEmpID = int.Parse(reader[0].ToString());
                    newDesc = Convert.ToString(reader[1]);
                    newMOQ = float.Parse(reader[2].ToString());
                    newPrice = float.Parse(reader[3].ToString());
                    newStatus = Convert.ToString(reader[4]);
                }
                conn.Close();
                if (oldDesc != newDesc)
                {
                    myField = myField + "prodDesc";
                    oldValues = oldValues + oldDesc;
                }
                if (oldMOQ != newMOQ)
                {
                    if (myField == "")
                    {
                        myField = myField + "prodMOQ";
                        oldValues = oldValues + oldMOQ;
                    }
                    else
                    {
                        myField = myField + ", prodMOQ";
                        oldValues = oldValues + ", " + oldMOQ;
                    }
                }
                if (oldPrice!= newPrice)
                {
                    if (myField == "")
                    {
                        myField = myField + "prodPrice";
                        oldValues = oldValues + oldPrice;
                    }
                    else
                    {
                        myField = myField + ", prodPrice";
                        oldValues = oldValues + ", " + oldPrice;
                    }
                }
                if (oldStatus != newStatus)
                {
                    if (myField == "")
                    {
                        myField = myField + "prodStatus";
                        oldValues = oldValues + oldStatus;
                    }
                    else
                    {
                        myField = myField + ", prodStatus";
                        oldValues = oldValues + ", " + oldStatus;
                    }
                }
                func.ChangeLog("tbl_product", myField, oldValues);
                ReferenceToProdManage.getData();
                ReferenceToProdManage.dataLoad();
                MessageBox.Show("Edited Successfully!", "", MessageBoxButtons.OK);
            }
            catch (MySqlException x)
            {
                if (x.Number.ToString() == "1062")
                {
                    MessageBox.Show("Product already exists!");
                    txtPname.Focus();
                    txtPname.SelectAll();
                }
                else
                {
                    MessageBox.Show("Error in Edit() :" + x.ToString());

                }
                conn.Close();
            }
        }
    }
}
