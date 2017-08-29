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
            dataGridOrdered.Location = new Point(this.Width-1070, 20);
            dataGridOrdered.Size = new Size(1050, this.Height / 2);
            pnlDisplay.Location = new Point(this.Width - 535, dataGridOrdered.Height + 40);
            pnlDisplay.Size = new Size(500, (this.Height - dataGridOrdered.Height)/2 - 40);
            pnlButtons.Location = new Point(this.Width - 535, dataGridOrdered.Height + pnlDisplay.Height + 60);
            pnlButtons.Size = new Size(500, (this.Height - dataGridOrdered.Height) / 2 - 60);
            pnlCalcu.Location = new Point(this.Width - 1050, dataGridOrdered.Height + 40);
            pnlCalcu.Size = new Size(500, pnlDisplay.Height + pnlButtons.Height + 20);
            btnClose.BringToFront();
            btnClose.Size = new Size(pnlButtons.Width / 5, pnlButtons.Height / 2);
            btnClose.Location = new Point(pnlButtons.Location.X + pnlButtons.Width / 5 * 4, pnlButtons.Location.Y + pnlButtons.Height / 2);
            lblSubTot.Location = new Point(pnlDisplay.Location.X + 10, pnlDisplay.Location.Y + 10);
            txtSubTot.Location = new Point(pnlDisplay.Location.X + lblSubTot.Width + 20, pnlDisplay.Location.Y + 10);
            lblTotDisc.Location = new Point(pnlDisplay.Location.X + 10, pnlDisplay.Location.Y + 10 + 30);
            txtTotDisc.Location = new Point(pnlDisplay.Location.X + lblTotDisc.Width + 20, pnlDisplay.Location.Y + 10 + 30);
        }

        private void initializeOrderedGrid()
        {
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            ReferenceToAfterLogin.Show();
            this.Dispose();
        }
    }
}
