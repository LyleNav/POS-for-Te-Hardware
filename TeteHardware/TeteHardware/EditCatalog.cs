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
    public partial class formEditCatalog : Form
    {
        public formCatalogManage ReferenceToCatManage { get; set; } //Reference formCatalogManage to this form
        public MySqlConnection conn; //connection
        public string catName, catDesc;
        public int catID;
        public formEditCatalog()
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

        private void btnClear_Click(object sender, EventArgs e) //clears all inputted values
        {
            txtCid.Text = "";
            txtCname.Text = "";
            txtCdesc.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void formEditCatalog_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formEditCatalog_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formEditCatalog_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formEditCatalog_Load(object sender, EventArgs e)
        {
            txtCid.Text = catID.ToString();
            txtCname.Text = catName;
            txtCdesc.Text = catDesc;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            this.Close();
        }

        private void formEditCatalog_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToCatManage.Show(); //shows the previous form upon exiting the current form
        }

        private void Edit()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_productcatalog WHERE productCatalogID = '" + catID + "'", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("UPDATE tbl_productcatalog SET productCatalogName = '" + txtCname.Text + "', productCatalogDesc = '" + txtCdesc.Text + "' WHERE productCatalogID = '" + catID + "'", conn);
                query1.ExecuteNonQuery();
                conn.Close();
                ReferenceToCatManage.getData();

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
