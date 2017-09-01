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
    public partial class formPOS : Form
    {
        public formAfterLogin ReferenceToAfterLogin { get; set; } //Reference AfterLogin to this form
        public MySqlConnection conn; //connection
        Test func = new Test();

        public formPOS()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=tetehardware;Uid=root;Pwd=root"); //connection
            this.Opacity = 0; //form transition using timer
            timer1.Start(); //form transition using timer
        }

        private void formPOS_Load(object sender, EventArgs e)
        {
            initializeForm();
            initializeOrderedGrid();
        }

        private void initializeForm()
        {
            dataGridOrdered.Location = new Point(this.Width-1050, 0);
            dataGridOrdered.Size = new Size(1050, this.Height / 2);
            pnlDisplay.Location = new Point(this.Width - 1050 + 525, dataGridOrdered.Height);
            pnlDisplay.Size = new Size(dataGridOrdered.Width / 2, dataGridOrdered.Height / 2-25);
            pnlButtons.Location = new Point(this.Width - 1050 + 525, dataGridOrdered.Height + pnlDisplay.Height);
            pnlButtons.Size = new Size(dataGridOrdered.Width / 2, dataGridOrdered.Height / 2-25);
            pnlCalcu.Location = new Point(this.Width - 1050, dataGridOrdered.Height);
            pnlCalcu.Size = new Size(dataGridOrdered.Width / 2, this.Height / 2-50);
            btnClose.Size = new Size(pnlButtons.Width / 5, pnlButtons.Height / 2);
            btnItemSearch.Size = btnClose.Size;
            btnEditLine.Size = btnClose.Size;
            btnEditTrans.Size = btnClose.Size;
            btnDiscount.Size = btnClose.Size;
            btnClose.Location = new Point(420, pnlButtons.Height / 2);
            btnItemSearch.Location = new Point(0, pnlButtons.Height / 2);
            btnEditLine.Location = new Point(105, pnlButtons.Height / 2);
            btnEditTrans.Location = new Point(210, pnlButtons.Height / 2);
            btnDiscount.Location = new Point(315, pnlButtons.Height / 2);
            btnClose.BringToFront();

        }

        private void initializeOrderedGrid()
        {
            //Get Screen size type: A=800X600; B=1024 and 1280; C=1400 to 1600; D=1680 and above
            //set positions for datagrid, display and buttons panels
            //set widths of datagrid columns
            //set positions for labels and texboxes in display panel
            //set positions for buttons in buttons panel


            dataGridOrdered.ColumnCount = 8;
            dataGridOrdered.Columns[0].Name = "Item ID";
            dataGridOrdered.Columns[1].Name = "Item";
            dataGridOrdered.Columns[2].Name = "Qty";
            dataGridOrdered.Columns[3].Name = "U Price";
            dataGridOrdered.Columns[4].Name = "SubTotal";
            dataGridOrdered.Columns[5].Name = "Promo ID";
            dataGridOrdered.Columns[6].Name = "Discount";
            dataGridOrdered.Columns[7].Name = "Total Price";
            dataGridOrdered.Columns[0].Width = 100;
            dataGridOrdered.Columns[1].Width = 400;
            dataGridOrdered.Columns[2].Width = 70;
            dataGridOrdered.Columns[3].Width = 100;
            dataGridOrdered.Columns[4].Width = 100;
            dataGridOrdered.Columns[5].Width = 50;
            dataGridOrdered.Columns[6].Width = 100;
            dataGridOrdered.Columns[7].Width = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1; //form transition using timer
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ReferenceToAfterLogin.Show();
            this.Dispose();
        }

        private void txtNoItems_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
