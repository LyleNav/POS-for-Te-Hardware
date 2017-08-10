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
        public formProductManage ReferenceToProdManage { get; set; } //Reference formPromoManage to this form
        public MySqlConnection conn; //connection
        public int prodID, catID, supID, promID, prodStock, prodStatus;
        public string prodName, prodDesc, prodUnit;
        public float prodPrice;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPid.Text = "";
            txtPname.Text = "";
            txtPdesc.Text = "";
            comboPcat.Text = "";
            comboPsupplier.Text = "";
            comboPpromo.Text = "";
            txtPstock.Text = "";
            txtPprice.Text = "";
            txtPunit.Text = "";
            comboPstatus.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse

        private void formEditProduct_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formEditProduct_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formEditProduct_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formEditProduct_Load(object sender, EventArgs e)
        {
            txtPid.Text = prodID.ToString();
            txtPname.Text = prodName;
            txtPdesc.Text = prodDesc;
            comboPcat.Text = catID.ToString();
            comboPsupplier.Text = supID.ToString();
            comboPpromo.Text = promID.ToString();
            txtPstock.Text = prodStock.ToString();
            txtPprice.Text = prodPrice.ToString();
            txtPunit.Text = prodUnit;
            comboPstatus.Text = prodStatus.ToString();
        }

        private void formEditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToProdManage.Show(); //shows the previous form upon exiting the current form
        }
       /* private void Edit()
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
        }*/
    }
}
