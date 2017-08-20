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
    public partial class formEditEmployee : Form
    {
        public formEmployeeManage ReferenceToEmpManage { get; set; } //Reference formEmployeeManage to this form
        public MySqlConnection conn; //connection
        Test func = new Test();
        public string empName, empUser, empPass, oldName, oldPass, newName, newPass, myField, oldValues;
        public int empLevel, oldLevel, newLevel;
        public int empID;
        public formEditEmployee()
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

        bool mouseDown; //boolean for mousedown
        Point lastLocation; //variable for the last location of the mouse
        private void formEditEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true; //sets mousedown to true
            lastLocation = e.Location; //gets the location of the form and sets it to lastlocation
        }

        private void formEditEmployee_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false; //sets mousedown to false
        }

        private void formEditEmployee_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) //if mouseDown is true, point to the last location of the mouse
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //gets the coordinates of the location of the mouse
                this.Update(); //updates the location of the mouse
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtEname.Text == "" || txtEuser.Text == "" || txtEpass.Text == "" || comboElevel.Text == "" ) //DATA VALIDATION
            {
                MessageBox.Show("Please supply all necessary fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //shows a message box if textboxes are blank
            }
            else
            {
                Edit();
                this.Close();
            }
        }

        private void formEditEmployee_Load(object sender, EventArgs e)
        {
            txtEid.Text = empID.ToString();
            txtEname.Text = empName;
            txtEuser.Text = empUser;
            txtEpass.Text = empPass;
            comboElevel.SelectedIndex = empLevel;
            txtEuser.Enabled = false;
            oldName = empName;
            oldPass = empPass;
            oldLevel = empLevel;
        }

        private void formEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReferenceToEmpManage.Show(); //shows the previous form upon exiting the current form
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEname.Text = "";
            txtEpass.Text = "";
            comboElevel.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
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
        private void Edit()
        {
            try
            {
                conn.Open();
                MySqlCommand query = new MySqlCommand("SELECT * FROM tbl_employee WHERE empID = '" + empID + "'", conn);
                query.ExecuteNonQuery();
                MySqlCommand query1 = new MySqlCommand("UPDATE tbl_employee SET empName = '" + txtEname.Text + "', empUser = '" + txtEuser.Text + "', empPass = '" + txtEpass.Text + "', empLevel = '" + comboElevel.SelectedIndex + "', empDateEdit = '" + DateTime.Now.ToString() + "' WHERE empID = '" + empID + "'", conn);
                query1.ExecuteNonQuery();
                MySqlCommand query2 = new MySqlCommand("SELECT empName, empPass, empLevel FROM tbl_employee WHERE empID = '" + empID + "'", conn);
                MySqlDataReader reader = query2.ExecuteReader();
                myField = "";
                oldValues = "";
                while (reader.Read())
                {
                    newName = Convert.ToString(reader[0]);
                    newPass = Convert.ToString(reader[1]);
                    newLevel = int.Parse(Convert.ToString(reader[2]));
                }
                conn.Close();
                if(oldName != newName)
                {
                    myField = myField + "empName";
                    oldValues = oldValues + oldName;
                }
                if(oldPass != newPass)
                {
                    if (myField == "")
                    {
                        myField = myField + "empPass";
                        oldValues = oldValues + oldPass;
                    }
                    else
                    {
                        myField = myField + ", empPass";
                        oldValues = oldValues + ", " + oldPass;
                    }
                }
                if(oldLevel != newLevel)
                {
                    if (myField == "")
                    {
                        myField = myField + "empLevel";
                        oldValues = oldValues + oldLevel;
                    }
                    else
                    {
                        myField = myField + ", empLevel";
                        oldValues = oldValues + ", " + oldLevel;
                    }
                }
                func.ChangeLog("tbl_employee", myField, oldValues);
                ReferenceToEmpManage.getData();
                ReferenceToEmpManage.dataLoad();
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
