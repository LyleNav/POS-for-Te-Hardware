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
    public partial class formAddCatalog : Form
    {
        public formCatalogManage ReferenceToCatManage { get; set; } //Reference formCatalogManage to this form
        public MySqlConnection conn; //connection
        Test func = new Test();
        public formAddCatalog()
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

        private void formAddCatalog_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formAddCatalog_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formAddCatalog_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formAddCatalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToCatManage.Show(); //shows the previous form upon exiting the current form
        }

        private void btnClear_Click(object sender, EventArgs e) //clears all inputted values
        {
            txtCname.Text = "";
            txtCdesc.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCname.Text == "" || txtCdesc.Text == "") //DATA VALIDATION
            {
                MessageBox.Show("Please supply all necessary fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows a message box if textboxes are blank
            }
            else
            {
                Add();
            }
        }

        private void Add()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("INSERT INTO tbl_productcatalog(catName, catDesc) VALUES('" + txtCname.Text + "','" + txtCdesc.Text + "')", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("UPDATE tbl_productcatalog SET catID = RIGHT(autoID + 100, 2) WHERE catName = '" + txtCname.Text + "'", conn);
                query1.ExecuteNonQuery();
                func.ChangeLog("tbl_productcatalog", "All", "None");
                conn.Close();
                ReferenceToCatManage.getData();
                ReferenceToCatManage.dataLoad();
                MessageBox.Show("Added Successfully!", "", MessageBoxButtons.OK);
                txtCname.Text = "";
                txtCid.Text = "";
                txtCdesc.Text = "";
            }
            catch (MySqlException x)
            {
                if(x.Number.ToString() == "1062")
                {
                    MessageBox.Show("Category already exists!");
                    txtCname.Focus();
                    txtCname.SelectAll();
                }
                else
                {
                    MessageBox.Show("Error in Add() :" + x.ToString());
                    
                }
                conn.Close();
            }
        }

        private void formAddCatalog_Load(object sender, EventArgs e)
        {
            int mycounter = 0;
/*
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT max(autoID) FROM tbl_productcatalog", conn);
                MySqlDataReader reader = query.ExecuteReader();
//                mycounter = 0;
                while (reader.Read())
                {
                    mycounter = int.Parse(reader[0].ToString());
                }
                conn.Close();
                mycounter++;
                txtCid.Text = mycounter.ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Load:" + x.ToString());
                conn.Close();
            }
            */
        }
    }
}
