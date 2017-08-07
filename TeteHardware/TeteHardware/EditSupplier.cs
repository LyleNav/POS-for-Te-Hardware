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
        public string supName, supDesc, supContact;
        public int supID;
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
            txtSid.Text = "";
            txtSname.Text = "";
            txtSdesc.Text = "";
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
            txtSdesc.Text = supDesc;
            txtScontact.Text = supContact;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            this.Close();
        }
        private void Edit()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_supplier WHERE supplierID = '" + supID + "'", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("UPDATE tbl_supplier SET supplierName = '" + txtSname.Text + "', supplierDesc = '" + txtSdesc.Text + "', supplierContactInfo = '" + txtScontact.Text + "' WHERE supplierID = '" + supID + "'", conn);
                query1.ExecuteNonQuery();
                conn.Close();
                ReferenceToSupManage.getData();

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
