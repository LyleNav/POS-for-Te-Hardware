﻿using System;
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
    public partial class formAddSupplier : Form
    {
        public formSupplierManage ReferenceToSupManage { get; set; } //Reference formSupplierManage to this form
        public MySqlConnection conn; //connection
        Test func = new Test();
        public formAddSupplier()
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSname.Text = "";
            txtSaddress.Text = "";
            txtScontact.Text = "";
            txtScontactNum.Text = "";
            txtSothers.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void formAddSupplier_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formAddSupplier_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formAddSupplier_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formAddSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToSupManage.Show(); //shows the previous form upon exiting the current form
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSname.Text == "" || txtSaddress.Text == "" || txtScontact.Text == "" || txtScontactNum.Text == "") //DATA VALIDATION
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
                MySqlCommand query = new MySqlCommand("INSERT INTO tbl_supplier(supName, supAddress, supContact, supContactNum, supOthers) VALUES('" + txtSname.Text + "','" + txtSaddress.Text + "','" + txtScontact.Text + "','" + txtScontactNum.Text + "','" + txtSothers.Text + "')", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("Update tbl_supplier SET supID = autoID WHERE supName = '" + txtSname.Text + "'", conn);
                query1.ExecuteNonQuery();
                func.ChangeLog("tbl_supplier", "All", "None");
                conn.Close();
                ReferenceToSupManage.getData();
                ReferenceToSupManage.dataLoad();

                MessageBox.Show("Added Successfully!", "", MessageBoxButtons.OK);
            }
            catch (MySqlException x)
            {
                if (x.Number.ToString() == "1062")
                {
                    MessageBox.Show("Supplier already exists!");
                    txtSname.Focus();
                    txtSname.SelectAll();
                }
                else
                {
                    MessageBox.Show("Error in Add() :" + x.ToString());

                }
                conn.Close();
            }
        }

        private void formAddSupplier_Load(object sender, EventArgs e)
        {

        }

        private void txtScontactNum_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtScontactNum.Text, "  ^ [0-9]"))
            {
                txtScontactNum.Text = "";  
            }
        }

        private void txtScontactNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) //with decimals
            {
                e.Handled = true;
            }
        }
    }
}
