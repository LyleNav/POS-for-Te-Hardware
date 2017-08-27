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
    public partial class formEditSupplier : Form
    {
        public formSupplierManage ReferenceToSupManage { get; set; } //Reference formSupplierManage to this form
        public MySqlConnection conn; //connection
        public string supName, supAddress, supContact, supContactNum, supOthers;
        public string oldName, oldAddress, oldContact, oldContactNum, oldOthers;
        public string newName, newAddress, newContact, newContactNum, newOthers;
        public string myField, oldValues;
        public int supID;
        Test func = new Test();

        public formEditSupplier()
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
        private void formEditSupplier_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formEditSupplier_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formEditSupplier_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formEditSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToSupManage.Show(); //shows the previous form upon exiting the current form
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        private void formEditSupplier_Load(object sender, EventArgs e)
        {
            txtSid.Text = supID.ToString();
            txtSname.Text = supName;
            txtSaddress.Text = supAddress;
            txtScontact.Text = supContact;
            txtScontactNum.Text = supContactNum;
            txtSothers.Text = supOthers;

            oldName = supName;
            oldAddress = supAddress;
            oldContact = supContact;
            oldContactNum = supContactNum;
            oldOthers = supOthers;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtSname.Text == "" || txtSaddress.Text == "" || txtScontact.Text == "" || txtScontactNum.Text == "" || txtSothers.Text == "") //DATA VALIDATION
            {
                MessageBox.Show("Please supply all necessary fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows a message box if textboxes are blank
            }
            else
            {
                Edit();
                this.Close();
            }
        }
        private void Edit()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_supplier WHERE supID = '" + supID + "'", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("UPDATE tbl_supplier SET supName = '" + txtSname.Text + "', supAddress = '" + txtSaddress.Text + "', supContact = '" + txtScontact.Text + "', supContactNum = '" + txtScontactNum.Text + "', supOthers = '" + txtSothers.Text + "' WHERE supID = '" + supID + "'", conn);
                query1.ExecuteNonQuery();
                MySqlCommand query2 = new MySqlCommand("SELECT supName, supAddress, supContact, supContactNum, supOthers FROM tbl_supplier WHERE supID = '" + supID + "'", conn);
                MySqlDataReader reader = query2.ExecuteReader();
                myField = "";
                oldValues = "";
                while (reader.Read())
                {
                    newName = Convert.ToString(reader[0]);
                    newAddress = Convert.ToString(reader[1]);
                    newContact = Convert.ToString(reader[2]);
                    newContactNum = Convert.ToString(reader[3]);
                    newOthers = Convert.ToString(reader[4]);
                }
                conn.Close();
                if (oldName != newName)
                {
                    myField = myField + "supName";
                    oldValues = oldValues + oldName;
                }
                if (oldAddress != newAddress)
                {
                    if (myField == "")
                    {
                        myField = myField + "supAddress";
                        oldValues = oldValues + oldAddress;
                    }
                    else
                    {
                        myField = myField + ", supAddress";
                        oldValues = oldValues + ", " + oldAddress;
                    }
                }
                if (oldContact != newContact)
                {
                    if (myField == "")
                    {
                        myField = myField + "supContact";
                        oldValues = oldValues + oldContact;
                    }
                    else
                    {
                        myField = myField + ", supContact";
                        oldValues = oldValues + ", " + oldContact;
                    }
                }
                if (oldContactNum != newContactNum)
                {
                    if (myField == "")
                    {
                        myField = myField + "supContactNum";
                        oldValues = oldValues + oldContactNum;
                    }
                    else
                    {
                        myField = myField + ", supContactNum";
                        oldValues = oldValues + ", " + oldContactNum;
                    }
                }
                if (oldOthers != newOthers)
                {
                    if (myField == "")
                    {
                        myField = myField + "supOthers";
                        oldValues = oldValues + oldOthers;
                    }
                    else
                    {
                        myField = myField + ", supOthers";
                        oldValues = oldValues + ", " + oldOthers;
                    }
                }
                func.ChangeLog("tbl_supplier", myField, oldValues);
                ReferenceToSupManage.getData();
                ReferenceToSupManage.dataLoad();
                MessageBox.Show("Edited Successfully!", "", MessageBoxButtons.OK);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Edit: " + x.ToString());
                conn.Close();
            }
        }
    }
}
