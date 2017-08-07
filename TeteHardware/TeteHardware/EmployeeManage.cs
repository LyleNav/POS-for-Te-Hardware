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
    public partial class EmployeeManage : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //reference formAfterLogin to this form
        public MySqlConnection conn; //connection
        public int employeeID;
        public string eName, eUser, ePass;
        public EmployeeManage()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //sets form opacity to 0
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void EmployeeManage_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void EmployeeManage_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void EmployeeManage_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void EmployeeManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToAfterLogin.Show(); //shows the previous form upon exiting the current form
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            formAddEmployee formAE = new formAddEmployee(); //variable reference to formAddEmployee
            formAE.ReferenceToSupManage = this; //sets the reference form to this form
            formAE.Show(); //shows referenced form
            this.Hide(); //hides current form
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_employee", conn); //query to select all entries in tbl_employee
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table

                /* formEditSupplier formES = new formEditSupplier(); //variable reference to formEditEmployee
                 formES.ReferenceToSupManage = this; //sets the reference form to this form
                 formES.supName = supplierName;
                 formES.supDesc = supplierDesc;
                 formES.supContact = supplierContact;
                 formES.supID = supplierID;
                 formES.Show(); //shows referenced form*/
                this.Hide(); //hides current form
                conn.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.ToString());
                conn.Close();
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            Delete();
            dataGridEmployee.ClearSelection();
            btnEditEmployee.Enabled = false;
            btnAddEmployee.Enabled = true;
            btnDeleteEmployee.Enabled = false;
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            btnEditEmployee.Enabled = false;
            btnAddEmployee.Enabled = true;
            btnDeleteEmployee.Enabled = false;
            dataGridEmployee.ClearSelection();
        }

        private void EmployeeManage_Load(object sender, EventArgs e)
        {
            dataLoad();
            btnEditEmployee.Enabled = false;
            btnDeleteEmployee.Enabled = false;
            dataGridEmployee.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form, shows previous form
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form, shows previous form
        }
        private void dataLoad() //loads the data from the database
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_employee", conn); //query to select all entries in tbl_employee
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table

                dataGridEmployee.DataSource = dt; //sets datasource to datatable
                dataGridEmployee.Columns["employeeID"].Visible = false; //gets the employeeID and sets it's visibility to false
                dataGridEmployee.Columns["eName"].HeaderText = "Employee Name"; //gets the eName and sets it as a header
                dataGridEmployee.Columns["username"].HeaderText = "Username"; //gets the username and sets it as a header
                dataGridEmployee.Columns["password"].Visible = false; //gets the password and sets it as a header
                dataGridEmployee.Columns["eRemarks"].HeaderText = "Remarks"; //gets the eRemarks and sets it as a header
                conn.Close(); //closes the connection
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in dataLoad(): " + x).ToString(); //shows an error if there is one
                conn.Close(); // closes the connection
            }
        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddEmployee.Enabled = false;
            btnEditEmployee.Enabled = true;
            btnDeleteEmployee.Enabled = true;

            eName = dataGridEmployee.Rows[e.RowIndex].Cells["eName"].Value.ToString();
            eUser = dataGridEmployee.Rows[e.RowIndex].Cells["eUser"].Value.ToString();
            employeeID = int.Parse(dataGridEmployee.Rows[e.RowIndex].Cells["employeeID"].Value.ToString());
        }

        public void getData() //gets the data from the database
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_employee", conn); //query to select all entries in tbl_employee
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table
                dataGridEmployee.DataSource = dt; //sets datasource to data table
                conn.Close(); //closes the connection
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in getData(): " + x.ToString()); //shows and error if there is one
                conn.Close(); //closes the connection
            }
        }
        private void Delete()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_employee WHERE employeeID = '" + employeeID + "'", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("DELETE FROM tbl_employee WHERE employeeID ='" + employeeID + "'", conn);
                query1.ExecuteNonQuery();
                conn.Close();
                getData();

                MessageBox.Show("Deleted Successfully!", "", MessageBoxButtons.OK);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in Delete: " + x.ToString());
                conn.Close();
            }
        }
    }
}
