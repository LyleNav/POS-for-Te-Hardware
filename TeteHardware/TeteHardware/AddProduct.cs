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
    public partial class formAddProduct : Form
    {
        public formProductManage ReferenceToProdManage { get; set; } //Reference formCatalogManage to this form
        public MySqlConnection conn; //connection
        Test func = new Test();
        public int catID;
        public string catName;
        public formAddProduct()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void formAddProduct_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formAddProduct_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formAddProduct_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToProdManage.Show(); //shows the previous form upon exiting the current form
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPname.Text = "";
            txtPdesc.Text = "";
            comboPcat.Text = "";
            txtPstock.Text = "";
            txtPprice.Text = "";
            txtPunit.Text = "";
            txtPstatus.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboPcat.Text == "" || txtPname.Text == "" || txtPdesc.Text == "" || txtMOQ.Text == "" || txtPstock.Text == "" || txtPprice.Text == "" || txtPunit.Text == "" || txtPstatus.Text == "") //DATA VALIDATION
            {
                MessageBox.Show("Please supply all necessary fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows a message box if textboxes are blank
            }
            else
            {
                Add();
                this.Close();
            }
           
        }

        private void Add()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("INSERT INTO tbl_product(empID, prodID, prodName, prodMOQ, prodDesc, prodStock, prodUPrice, prodUnit, prodStatus) VALUES('" + TeteHardware.Properties.Settings.Default.loginID  + "', '" + txtPid.Text + "', '" + txtPname.Text + "', '" + txtMOQ.Text + "','" + txtPdesc.Text + "','" + txtPstock.Text + "','" + txtPprice.Text + "','" + txtPunit.Text + "','" + txtPstatus.Text + "')", conn);
                query.ExecuteNonQuery();
                func.ChangeLog("tbl_product", "All", "None");
                conn.Close();
                ReferenceToProdManage.getData();
                ReferenceToProdManage.dataLoad();
                MessageBox.Show("Added Successfully!", "", MessageBoxButtons.OK);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Add() :" + x.ToString());
                conn.Close();
            }
        }

        private void formAddProduct_Load(object sender, EventArgs e)
        {
            txtPstock.Text = "0";
            txtPprice.Text = "0.00";
            txtMOQ.Text = "0";
            txtPstock.Enabled = false;
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT catID, catName FROM tbl_productcatalog", conn);
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    comboCatID.Items.Add(reader[0]);
                    comboPcat.Items.Add(reader[1]);
                }
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Load: " + x.ToString());
                conn.Close();
            }
        }

        private void comboPcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mycounter = "";
            int mycounter1 = 0;
            comboCatID.SelectedIndex = comboPcat.SelectedIndex;
            txtPid.Text = comboCatID.Text;
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT RIGHT(prodID, 3) AS myProdID FROM tbl_product WHERE LEFT(prodID, 2) = '" + txtPid.Text + "' ORDER BY prodID", conn);
                MySqlDataReader reader = query.ExecuteReader();
                while(reader.Read())
                {
                    mycounter = Convert.ToString(reader[0]);
                }
                conn.Close();
                
                if(mycounter == "")
                {
                    mycounter1 = 0;
                }
                else
                {
                    mycounter1 = int.Parse(mycounter);
                }
                MessageBox.Show(mycounter1.ToString());
                mycounter1 = mycounter1 + 1;
                mycounter1 = mycounter1 + 1000;
                string mycounter2 = mycounter1.ToString().Substring(mycounter1.ToString().Length - 3);
                txtPid.Text = comboCatID.Text + mycounter2;

            }
            catch (Exception x)
            {
                MessageBox.Show("Error in comboPcat: " + x.ToString());
                conn.Close();
            }
        }

        private void txtMOQ_Leave(object sender, EventArgs e)
        {
            if (!func.IsFloat(txtMOQ.Text))
            {
                MessageBox.Show("Invalid MOQ", "", MessageBoxButtons.OK);
            }
        }

        private void txtPprice_Leave(object sender, EventArgs e)
        {
            if (!func.IsFloat(txtPprice.Text))
            {
                MessageBox.Show("Invalid Price", "", MessageBoxButtons.OK);
            }
        }

    }
}
