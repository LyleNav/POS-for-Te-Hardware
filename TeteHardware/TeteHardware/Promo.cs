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
    public partial class formPromoManage : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //reference formAfterLogin to this form
        public MySqlConnection conn; //connection
        public int promoID, promoValue, promoPercent, promoStatus, promoType;
        public string promoName;
        public formPromoManage()
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
        private void formPromoManage_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formPromoManage_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formPromoManage_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formPromoManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToAfterLogin.Show(); //shows the previous form upon exiting the current form
        }

        private void btnAddPromo_Click(object sender, EventArgs e)
        {
            formAddPromo formAP = new formAddPromo(); //variable reference to formAddPromo
            formAP.ReferenceToPromoManage = this; //sets the reference form to this form
            formAP.Show(); //shows referenced form
            this.Hide(); //hides current form
        }

        private void btnEditPromo_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_promo", conn); //query to select all entries in tbl_promo
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table

                formEditPromo formEP = new formEditPromo(); //variable reference to formEditPromo
                formEP.ReferenceToPromoManage = this; //sets the reference form to this form
                formEP.promName = promoName;
                formEP.promType = promoType;
                formEP.promPercent = promoPercent;
                formEP.promValue = promoValue;
                formEP.promStatus = promoStatus;
                formEP.promID = promoID;
                formEP.Show(); //shows referenced form
                this.Hide(); //hides current form
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.ToString());
                conn.Close();
            }
        }

        private void btnDeletePromo_Click(object sender, EventArgs e)
        {
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            btnAddPromo.Enabled = true;
            btnEditPromo.Enabled = false;  
            dataGridPromo.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form, shows previous form
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form, shows previous form
        }

        private void formPromoManage_Load(object sender, EventArgs e)
        {
            dataLoad();
            btnEditPromo.Enabled = false;
            dataGridPromo.ClearSelection();
        }

        private void dataGridPromo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAddPromo.Enabled = false;
                btnEditPromo.Enabled = true;

                promoName = dataGridPromo.Rows[e.RowIndex].Cells["promoName"].Value.ToString();
                if (dataGridPromo.Rows[e.RowIndex].Cells["promoType"].Value.ToString() == "Percent")
                    promoType = 0;
                else if (dataGridPromo.Rows[e.RowIndex].Cells["promoType"].Value.ToString() == "Value")
                    promoType = 1;
                promoValue = int.Parse(dataGridPromo.Rows[e.RowIndex].Cells["promoValue"].Value.ToString());
                promoPercent = int.Parse(dataGridPromo.Rows[e.RowIndex].Cells["promoPercent"].Value.ToString());
                if (dataGridPromo.Rows[e.RowIndex].Cells["promoStatus"].Value.ToString() == "On-going")
                    promoStatus = 0;
                else if (dataGridPromo.Rows[e.RowIndex].Cells["promoStatus"].Value.ToString() == "Paused")
                    promoStatus = 1;
                promoID = int.Parse(dataGridPromo.Rows[e.RowIndex].Cells["promoID"].Value.ToString());
            }
            catch (ArgumentOutOfRangeException) { }
        }

        public void dataLoad() //loads the data from the database
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT autoID, promoID, promoName, (CASE WHEN promoType = 0 THEN 'Percent' ELSE 'Value' END) AS promoType, promoPercent, promoValue, (CASE WHEN promoStatus = 0 THEN 'On-going' ELSE 'Paused' END) AS promoStatus FROM tbl_promo", conn); //query to select all entries in tbl_promo
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table

                dataGridPromo.DataSource = dt; //sets datasource to datatable
                dataGridPromo.Columns["promoID"].Visible = false; //gets the promoID and sets it's visibility to false
                dataGridPromo.Columns["autoID"].Visible = false;
                dataGridPromo.Columns["promoName"].HeaderText = "Name"; //gets the promoName and sets it as a header
                dataGridPromo.Columns["promoType"].HeaderText = "Type"; //gets the promoPercent and sets it as a header
                dataGridPromo.Columns["promoPercent"].HeaderText = "Percent";
                dataGridPromo.Columns["promoValue"].HeaderText = "Value"; //gets the promoValue and sets it as a header
                dataGridPromo.Columns["promoStatus"].HeaderText = "Status"; //gets the promoStatus and sets it as a header
                conn.Close(); //closes the connection
                dataGridPromo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in dataLoad(): " + x).ToString(); //shows an error if there is one
                conn.Close(); // closes the connection
            }
        }

        public void getData() //gets the data from the database
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_promo", conn); //query to select all entries in tbl_promo
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table
                dataGridPromo.DataSource = dt; //sets datasource to data table
                conn.Close(); //closes the connection
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in getData(): " + x.ToString()); //shows and error if there is one
                conn.Close(); //closes the connection
            }
        }
    }
}
