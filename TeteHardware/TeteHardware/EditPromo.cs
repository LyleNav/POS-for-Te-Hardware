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
    public partial class formEditPromo : Form
    {
        public formPromoManage ReferenceToPromoManage { get; set; } //Reference formPromoManage to this form
        public MySqlConnection conn; //connection
        public int promID, promType, promValue, promStatus;
        public string promName;
        public formEditPromo()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //form transition using timer
            timer1.Start(); //form transition using timer
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPid.Text = "";
            txtPname.Text = "";
            txtPvalue.Text = "";
            comboPtype.Text = "";
            comboPstatus.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void EditPromo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void EditPromo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void EditPromo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void EditPromo_Load(object sender, EventArgs e)
        {
            txtPid.Text = promID.ToString();
            txtPname.Text = promName;
            txtPvalue.Text = promValue.ToString();
            comboPtype.Text = promType.ToString();
            comboPstatus.Text = promStatus.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            this.Close();
        }

        private void EditPromo_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToPromoManage.Show(); //shows the previous form upon exiting the current form
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        private void Edit()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_promo WHERE promoID = '" + promID + "'", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("UPDATE tbl_promo SET promoName = '" + txtPname.Text + "', promoType = '" + comboPtype.Text + "', promoValue = '" + txtPvalue.Text + "', promoStatus = '" + comboPstatus.Text + "' WHERE promoID = '" + promID + "'", conn);
                query1.ExecuteNonQuery();
                conn.Close();
                ReferenceToPromoManage.getData();

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
