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
    public partial class formAddPromo : Form
    {
        public formPromoManage ReferenceToPromoManage { get; set; } //Reference formPromoManage to this form
        public MySqlConnection conn; //connection
        private int promoType, promoStatus;
        Test func = new Test();
        public formAddPromo()
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
        private void formAddPromo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formAddPromo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formAddPromo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formAddPromo_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToPromoManage.Show(); //shows the previous form upon exiting the current form
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPname.Text = "";
            txtPpercent.Text = "";
            txtPvalue.Text = "";
            comboPtype.Text = " ";
            comboPstatus.Text = " ";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPname.Text == "" || comboPtype.Text == "" || txtPpercent.Text == "" || txtPvalue.Text == "" || comboPtype.Text == "") //DATA VALIDATION
            {
                MessageBox.Show("Please supply all necessary fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows a message box if textboxes are blank
            }
            else if (!IsNumeric(txtPpercent.Text))
            {
                MessageBox.Show("Invalid Percent!", "", MessageBoxButtons.OK);
            }
            else if (!IsNumeric(txtPvalue.Text))
            {
                MessageBox.Show("Invalid Value!", "", MessageBoxButtons.OK);
            }
            else
            {
                if (comboPtype.Text == "Percent")
                    promoType = 0;
                else if(comboPtype.Text == "Value")
                    promoType = 1;
                if (comboPstatus.Text == "On-going")
                    promoStatus = 0;
                else if(comboPstatus.Text == "Paused")
                    promoStatus = 1;
                Add();
                this.Close();
            }
        }

        public bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        private void comboPtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPtype.Text == "Percent")
            {
                txtPpercent.Enabled = true;
                txtPvalue.Enabled = false;
                txtPvalue.Text = "0";
                txtPpercent.Text = "";
                labelpercentR.Visible = true;
                labelvalueR.Visible = false;
            }
            else if (comboPtype.Text == "Value")
            {
                txtPvalue.Enabled = true;
                txtPpercent.Enabled = false;
                txtPpercent.Text = "0";
                txtPvalue.Text = "";
                labelpercentR.Visible = false;
                labelvalueR.Visible = true;
            }
            else
            {
                txtPvalue.Enabled = false;
                txtPpercent.Enabled = false;
                txtPpercent.Text = "0";
                txtPvalue.Text = "0";
                labelpercentR.Visible = false;
                labelvalueR.Visible = false;
            }
        }

        private void formAddPromo_Load(object sender, EventArgs e)
        {
            txtPpercent.Enabled = false;
            txtPvalue.Enabled = false;
            txtPpercent.Text = "0";
            txtPvalue.Text = "0";
            comboPstatus.SelectedIndex = 0;
            comboPstatus.Enabled = false;
        }

        private void Add()
        {
            promoType = comboPtype.SelectedIndex - 1;
            promoStatus = comboPtype.SelectedIndex - 1;
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("INSERT INTO tbl_promo(promoName, promoType, promoPercent, promoValue, promoStatus) VALUES('" + txtPname.Text + "','" + promoType + "','" + txtPpercent.Text + "','" + txtPvalue.Text + "','" + promoStatus + "')", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("UPDATE tbl_promo SET promoID = autoID WHERE promoName = '" + txtPname.Text + "'", conn);
                query1.ExecuteNonQuery();
                func.ChangeLog("tbl_promo", "All", "None");
                conn.Close();
                ReferenceToPromoManage.getData();
                ReferenceToPromoManage.dataLoad();

                MessageBox.Show("Added Successfully!", "", MessageBoxButtons.OK);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Add() :" + x.ToString());
                conn.Close();
            }
        }
    }
}
