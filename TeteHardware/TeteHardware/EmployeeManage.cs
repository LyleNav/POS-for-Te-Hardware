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
    public partial class formEmployeeManage : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //reference formAfterLogin to this form
        public MySqlConnection conn; //connection
        public int empID, empLevelz;
        public string empName, empUser, empPass;
        public formEmployeeManage()
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
            formAE.ReferenceToEmpManage = this; //sets the reference form to this form
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

                formEditEmployee formEE = new formEditEmployee(); //variable reference to formEditEmployee
                formEE.ReferenceToEmpManage = this; //sets the reference form to this form
                formEE.empID = empID;
                formEE.empName = empName;
                formEE.empUser = empUser;
                formEE.empPass = empPass;
                formEE.empLevel = empLevelz;
                
                formEE.Show(); //shows referenced form*/
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
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            btnEditEmployee.Enabled = false;
            btnAddEmployee.Enabled = true;
            dataGridEmployee.ClearSelection();
        }

        private void EmployeeManage_Load(object sender, EventArgs e)
        {
            dataLoad();
            btnEditEmployee.Enabled = false;
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
        public void dataLoad() //loads the data from the database
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand query = new MySqlCommand("SELECT autoID, empID, empName, empUser, empPass, (CASE WHEN empLevel = 0 THEN 'Admin' ELSE 'Cashier' END) as empLevel, empRemarks, empDateEdit FROM tbl_employee", conn); //query to select all entries in tbl_employee
                MySqlDataAdapter adp = new MySqlDataAdapter(query); //adapter for query
                DataTable dt = new DataTable(); //datatable for adapter
                adp.Fill(dt); //adapter fills the data with data table

                dataGridEmployee.DataSource = dt; //sets datasource to datatable
                dataGridEmployee.Columns["empID"].Visible = false; //gets the employeeID and sets it's visibility to false
                dataGridEmployee.Columns["autoID"].Visible = false;
                dataGridEmployee.Columns["empName"].HeaderText = "Name"; //gets the eName and sets it as a header
                dataGridEmployee.Columns["empUser"].HeaderText = "Username"; //gets the username and sets it as a header
                dataGridEmployee.Columns["empPass"].Visible = false; //gets the password and sets it as a header
                dataGridEmployee.Columns["empLevel"].HeaderText = "Level";
                dataGridEmployee.Columns["empRemarks"].HeaderText = "Remarks"; //gets the eRemarks and sets it as a header
                dataGridEmployee.Columns["empDateEdit"].Visible = false;
                conn.Close(); //closes the connection
                dataGridEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error in dataLoad(): " + x).ToString(); //shows an error if there is one
                conn.Close(); // closes the connection
            }
        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAddEmployee.Enabled = false;
                btnEditEmployee.Enabled = true;
                empID = int.Parse(dataGridEmployee.Rows[e.RowIndex].Cells["empID"].Value.ToString());
                if (dataGridEmployee.Rows[e.RowIndex].Cells["empLevel"].Value.ToString() == "Admin")
                    empLevelz = 0;
                else
                    empLevelz = 1;
                empName = dataGridEmployee.Rows[e.RowIndex].Cells["empName"].Value.ToString();
                empUser = dataGridEmployee.Rows[e.RowIndex].Cells["empUser"].Value.ToString();
                empPass = dataGridEmployee.Rows[e.RowIndex].Cells["empPass"].Value.ToString();
            }
            catch(ArgumentOutOfRangeException){}
            
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
    }
}
