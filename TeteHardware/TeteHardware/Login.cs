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
    public partial class formLogin : Form
    {
        public string loginID; //variable for form
        public MySqlConnection conn; //connection
        public formLogin()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //sets form opacity to 0
            timer1.Start(); //form transition using timer
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the form
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void formLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void formLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Contains("'") || txtUser.Text.Contains("'") || txtUser.Text.Contains("\\") || txtPass.Text.Contains("\\"))
            {
                MessageBox.Show("Invalid Credentials!", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    conn.Open(); //opens the connection to the database

                    MySqlCommand comm = new MySqlCommand("SELECT * FROM tbl_employee WHERE empUser = '" + txtUser.Text + "' AND empPass = '" + txtPass.Text + "'", conn); //command to get the inputted username/password
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm); //loads data to datatable
                    DataTable dt = new DataTable(); //datatable
                    adp.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        loginID = dt.Rows[0]["empID"].ToString();
                        TeteHardware.Properties.Settings.Default.loginID = loginID;
                        MySqlCommand com = new MySqlCommand("UPDATE tbl_employee SET empRemarks = 'logged' WHERE empUser = '" + txtUser.Text + "' AND empPass = '" + txtPass.Text + "'", conn); //query to set remark to Logged
                        com.ExecuteNonQuery();
                        formAfterLogin formAL = new formAfterLogin(); //variaxble reference to formAfterLogin
                        formAL.ReferenceToLogin = this; //sets the reference to this form
                        formAL.employeeName = dt.Rows[0]["empName"].ToString(); //gets the eName variable from the database and converts it to a string
                        formAL.Show(); //shows the referenced form
                        this.Hide(); //hides current form
                    }
                    else if (txtUser.Text == "" || txtPass.Text == "") //DATA VALIDATION
                    {
                        MessageBox.Show("Please supply all necessary fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows a message box if textboxes are blank
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credentials!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows a message box if either one of the textboxes have wrong inputs
                    }
                    conn.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Error: " + x.ToString()); //shows the error if there is one
                    conn.Close(); //closes the connection
                }
            }
        }

        private void formLogin_Load(object sender, EventArgs e) //loads all database values in table employee
        {
            try
            {
                conn.Open(); //opens the connection
                MySqlCommand comm = new MySqlCommand("SELECT * FROM tbl_employee WHERE empUser = '" + txtUser.Text + "' AND empPass = '" + txtPass.Text + "'", conn); //query with username/password parameters
                conn.Close(); //closes the connection
            }
            catch(Exception x)
            {
                MessageBox.Show("Error: " + x.ToString());//shows the error if there is one
                conn.Close(); //closes the connection
            }
        }

        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            txtUser.Text = ""; //sets the value of txtUser to blank after mouseclick
        }

        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            txtPass.Text = ""; //sets the value of txtPass to blank after mouseclick
        }
    }
}
