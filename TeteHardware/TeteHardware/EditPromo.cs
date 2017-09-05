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
        public int promID, promValue, promPercent, promStatus, promType;
        public string promName;
        public int oldpValue, oldpPercent, oldStatus, oldType, newpValue, newpPercent, newStatus, newType;
        public string oldName, newName, myField, oldValues;
        Test func = new Test();
        public formEditPromo()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //form transition using timer
            timer1.Start(); //form transition using timer
        }

        private void comboPtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPtype.Text == "Percent")
            {
                txtPpercent.Enabled = true;
                txtPvalue.Enabled = false;
                txtPvalue.Text = "0";
                txtPpercent.Text = "";
                labelpercentR.Visible = true;
                labelvalueR.Visible = false;
            }
            else if (comboPtype.Text == "Value")
            {
                txtPvalue.Enabled = true;
                txtPpercent.Enabled = false;
                txtPpercent.Text = "0";
                txtPvalue.Text = "";
                labelpercentR.Visible = false;
                labelvalueR.Visible = true;
            }
            else
            {
                txtPvalue.Enabled = false;
                txtPpercent.Enabled = false;
                txtPpercent.Text = "0";
                txtPvalue.Text = "0";
                labelpercentR.Visible = false;
                labelvalueR.Visible = false;
            }
            promType = comboPtype.SelectedIndex - 1 ;
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
            txtPname.Text = "";
            txtPvalue.Text = "";
            comboPtype.Text = "";
            comboPstatus.Text = "";
            txtPpercent.Text = "";
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

            if (promType.ToString() == "0")
                comboPtype.Text = "Percent";
            else if (promType.ToString() == "1")
                comboPtype.Text = "Value";

            if (comboPtype.Text == "Percent")
            {
                txtPpercent.Enabled = true;
                txtPvalue.Enabled = false;
                txtPvalue.Text = "0";
                txtPpercent.Text = promPercent.ToString();
            }
            else if (comboPtype.Text == "Value")
            {
                txtPvalue.Enabled = true;
                txtPpercent.Enabled = false;
                txtPpercent.Text = "0";
                txtPvalue.Text = promValue.ToString();
            }
            else
            {
                txtPvalue.Enabled = false;
                txtPpercent.Enabled = false;
                txtPpercent.Text = "0";
                txtPvalue.Text = "0";
            }

            if (promStatus.ToString() == "0")
                comboPstatus.Text = "On-going";
            else if(promStatus.ToString() == "1")
                comboPstatus.Text = "Paused";


            oldName = promName;
            oldpValue = promValue;
            oldpPercent = promPercent;
            oldType = promType;
            oldStatus = promStatus;
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
                MySqlCommand query1 = new MySqlCommand("UPDATE tbl_promo SET promoName = '" + txtPname.Text + "', promoType = '" + promType + "', promoPercent = '" + txtPpercent.Text + "', promoValue = '" + txtPvalue.Text + "', promoStatus = '" + promStatus + "' WHERE promoID = '" + promID + "'", conn);
                query1.ExecuteNonQuery();
                MySqlCommand query2 = new MySqlCommand("SELECT promoName, promoType, promoPercent, promoValue, promoStatus FROM tbl_promo WHERE promoID = '" + promID + "'", conn);
                MySqlDataReader reader = query2.ExecuteReader();
                MessageBox.Show("UPDATE tbl_promo SET promoName = '" + txtPname.Text + "', promoType = '" + promType + "', promoPercent = '" + txtPpercent.Text + "', promoValue = '" + txtPvalue.Text + "', promoStatus = '" + promStatus + "' WHERE promoID = '" + promID + "'");
                myField = "";
                oldValues = "";
                while (reader.Read())
                {
                    newName = Convert.ToString(reader[0]);
                    newType = int.Parse(Convert.ToString(reader[1]));
                    newpPercent = int.Parse(Convert.ToString(reader[2]));
                    newpValue = int.Parse(Convert.ToString(reader[3]));
                    newStatus = int.Parse(Convert.ToString(reader[4]));
                }
                conn.Close();
                if (oldName != newName)
                {
                    myField = myField + "promoName";
                    oldValues = oldValues + oldName;
                }
                if (oldType != newType)
                {
                    if (myField == "")
                    {
                        myField = myField + "promoType";
                        oldValues = oldValues + oldType;
                    }
                    else
                    {
                        myField = myField + ", promoType";
                        oldValues = oldValues + ", " + oldType;
                    }
                }
                if (oldpPercent != newpPercent)
                {
                    if (myField == "")
                    {
                        myField = myField + "promoPercent";
                        oldValues = oldValues + oldpPercent;
                    }
                    else
                    {
                        myField = myField + ", promoPercent";
                        oldValues = oldValues + ", " + oldpPercent;
                    }
                }
                if (oldpValue != newpValue)
                {
                    if (myField == "")
                    {
                        myField = myField + "promoValue";
                        oldValues = oldValues + oldpValue;
                    }
                    else
                    {
                        myField = myField + ", promoValue";
                        oldValues = oldValues + ", " + oldpValue;
                    }
                }
                if (oldStatus != newStatus)
                {
                    if (myField == "")
                    {
                        myField = myField + "promoStatus";
                        oldValues = oldValues + oldStatus;
                    }
                    else
                    {
                        myField = myField + ", promoPercent";
                        oldValues = oldValues + ", " + oldStatus;
                    }
                }
                func.ChangeLog("tbl_promo", myField, oldValues);
                ReferenceToPromoManage.getData();
                ReferenceToPromoManage.dataLoad();
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
