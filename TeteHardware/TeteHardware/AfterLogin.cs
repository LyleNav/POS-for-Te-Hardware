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
    public partial class formAfterLogin : Form
    {
        public formLogin ReferenceToLogin { get; set; } //Reference formLogin to this form
        public MySqlConnection conn; //connection
        public string employeeName; //string employee name to change value of labelName sa Welcome Header
        public formAfterLogin()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //sets form opacity to 0
            timer1.Start(); //form transition using timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void formAfterLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formAfterLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formAfterLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formAfterLogin_Load(object sender, EventArgs e)
        {
            labelName.Text = employeeName + "!"; //sets the value of labelName to employeeName
        }

        private void formAfterLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToLogin.Show(); //shows the previous form upon exiting the current form
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); //opens the connection

                MySqlCommand com = new MySqlCommand("UPDATE tbl_employee SET empRemarks = '' WHERE empRemarks = 'logged'", conn); //changes eRemarks value to blank from logged
                com.ExecuteNonQuery(); //executes query

                conn.Close(); //closes the connection

                this.Close(); //closes current form, shows previous form
            }
            catch(Exception x)
            {
                MessageBox.Show("Error: " + x.ToString()); //shows the error if there is one
                conn.Close(); //closes the connection
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); //opens the connection

                MySqlCommand com = new MySqlCommand("UPDATE tbl_employee SET empRemarks = '' WHERE empRemarks = 'logged'", conn); //changes eRemarks value to blank from logged
                com.ExecuteNonQuery(); //executes query

                conn.Close(); //closes the connection

                this.Close(); //closes current form, shows previous form
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.ToString()); //shows the error if there is one
                conn.Close(); //closes the connection
            }
        }

        private void btnCatManage_Click(object sender, EventArgs e)
        {
            formCatalogManage formCM = new formCatalogManage(); //variable reference to formCatalogManage
            formCM.ReferenceToAfterLogin = this; //sets the reference form to this form
            formCM.Show(); //shows referenced form
            this.Hide(); //hides current form
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            formSupplierManage formSM = new formSupplierManage(); //variable reference to formSupplierManage
            formSM.ReferenceToAfterLogin = this; //sets the reference form to this form
            formSM.Show(); //shows referenced form
            this.Hide(); //hides current form
        }

        private void btnEmpManage_Click(object sender, EventArgs e)
        {
            formEmployeeManage formEM = new formEmployeeManage(); //variable reference to formEmployeeManage
            formEM.ReferenceToAfterLogin = this; //sets the reference form to this form
            formEM.Show(); //shows referenced form
            this.Hide(); //hides current form
        }

        private void btnPromos_Click(object sender, EventArgs e)
        {
            formPromoManage formPM = new formPromoManage();
            formPM.ReferenceToAfterLogin = this;
            formPM.Show();
            this.Hide();
        }

        private void btnCustOrder_Click(object sender, EventArgs e)
        {
            formPOS formT = new formPOS();
            formT.ReferenceToAfterLogin = this;
            formT.Show();
            this.Hide();
        }

        private void btnProdManage_Click(object sender, EventArgs e)
        {
            formProductManage formPM = new formProductManage();
            formPM.ReferenceToAfterLogin = this;
            formPM.Show();
            this.Hide();
        }

        private void btnArr_Click(object sender, EventArgs e)
        {
            formArrival formA = new formArrival();
            formA.ReferenceToAfterLogin = this;
            formA.txtTable.Text = "tbl_arr";
            formA.lblArrival.Text = "Stock In - Good Items";
            formA.Show();
            this.Hide();
        }

        private void btnArrDef_Click(object sender, EventArgs e)
        {
            formArrival formA = new formArrival();
            formA.ReferenceToAfterLogin = this;
            formA.txtTable.Text = "tbl_arrdef";
            formA.lblArrival.Text = "Stock In - Bad Items";
            formA.Show();
            this.Hide();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            formPOS formTrans = new formPOS();
            formTrans.ReferenceToAfterLogin = this;
            formTrans.Show();
            this.Hide();
        }

        private void btnViews_Click(object sender, EventArgs e)
        {
            formViews formV = new formViews();
            formV.ReferenceToAfterLogin = this;
            formV.myType = "View";
            formV.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            formReturns formRet = new formReturns();
            formRet.ReferenceToAfterLogin = this;
            formRet.Show();
            this.Hide();
        }

        private void btnCustReturn_Click(object sender, EventArgs e)
        {
            ManageCustReturns formMCR = new ManageCustReturns();
            formMCR.ReferenceToAfterLogin = this;
            formMCR.Show();
            this.Hide();

        }

        private void btnInstoreDam_Click(object sender, EventArgs e)
        {
            formInStoreDamages formInst = new formInStoreDamages();
            formInst.ReferenceToAfterLogin = this;
            formInst.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            formReports formRep = new formReports();
            formRep.ReferenceToAfterLogin = this;
            formRep.myType = "Report";
            formRep.Show();
            this.Hide();
                
        }
    }
}
