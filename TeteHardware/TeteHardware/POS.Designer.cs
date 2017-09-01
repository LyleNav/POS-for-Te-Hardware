namespace TeteHardware
{
    partial class formPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridOrdered = new System.Windows.Forms.DataGridView();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlCalcu = new System.Windows.Forms.Panel();
            this.btnEditTrans = new System.Windows.Forms.Button();
            this.lblTotDisc = new System.Windows.Forms.Label();
            this.lblSubTot = new System.Windows.Forms.Label();
            this.lblnoItems = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblGrandTot = new System.Windows.Forms.Label();
            this.txtNoItems = new System.Windows.Forms.TextBox();
            this.txtSubTot = new System.Windows.Forms.TextBox();
            this.txtTotDisc = new System.Windows.Forms.TextBox();
            this.txtGrandTot = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditLine = new System.Windows.Forms.Button();
            this.btnItemSearch = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdered)).BeginInit();
            this.pnlDisplay.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridOrdered
            // 
            this.dataGridOrdered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdered.Location = new System.Drawing.Point(858, 12);
            this.dataGridOrdered.Name = "dataGridOrdered";
            this.dataGridOrdered.Size = new System.Drawing.Size(1050, 550);
            this.dataGridOrdered.TabIndex = 157;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlDisplay.Controls.Add(this.lblGrandTot);
            this.pnlDisplay.Controls.Add(this.txtGrandTot);
            this.pnlDisplay.Controls.Add(this.txtVAT);
            this.pnlDisplay.Controls.Add(this.lblTotDisc);
            this.pnlDisplay.Controls.Add(this.lblnoItems);
            this.pnlDisplay.Controls.Add(this.lblVAT);
            this.pnlDisplay.Controls.Add(this.lblSubTot);
            this.pnlDisplay.Controls.Add(this.txtTotDisc);
            this.pnlDisplay.Controls.Add(this.txtNoItems);
            this.pnlDisplay.Controls.Add(this.txtSubTot);
            this.pnlDisplay.Location = new System.Drawing.Point(1388, 561);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(520, 218);
            this.pnlDisplay.TabIndex = 159;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlButtons.Controls.Add(this.btnEditLine);
            this.pnlButtons.Controls.Add(this.btnDiscount);
            this.pnlButtons.Controls.Add(this.btnItemSearch);
            this.pnlButtons.Controls.Add(this.btnEditTrans);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Location = new System.Drawing.Point(1388, 796);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(520, 215);
            this.pnlButtons.TabIndex = 160;
            // 
            // pnlCalcu
            // 
            this.pnlCalcu.BackColor = System.Drawing.Color.Turquoise;
            this.pnlCalcu.Location = new System.Drawing.Point(858, 571);
            this.pnlCalcu.Name = "pnlCalcu";
            this.pnlCalcu.Size = new System.Drawing.Size(520, 440);
            this.pnlCalcu.TabIndex = 160;
            // 
            // btnEditTrans
            // 
            this.btnEditTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnEditTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTrans.Location = new System.Drawing.Point(106, 3);
            this.btnEditTrans.Name = "btnEditTrans";
            this.btnEditTrans.Size = new System.Drawing.Size(100, 105);
            this.btnEditTrans.TabIndex = 161;
            this.btnEditTrans.Text = "Edit Transaction";
            this.btnEditTrans.UseVisualStyleBackColor = false;
            // 
            // lblTotDisc
            // 
            this.lblTotDisc.BackColor = System.Drawing.Color.Transparent;
            this.lblTotDisc.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotDisc.Location = new System.Drawing.Point(161, 99);
            this.lblTotDisc.Name = "lblTotDisc";
            this.lblTotDisc.Size = new System.Drawing.Size(115, 22);
            this.lblTotDisc.TabIndex = 163;
            this.lblTotDisc.Text = "Total Discount";
            // 
            // lblSubTot
            // 
            this.lblSubTot.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTot.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTot.Location = new System.Drawing.Point(161, 65);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(115, 22);
            this.lblSubTot.TabIndex = 164;
            this.lblSubTot.Text = "Sub-Total";
            // 
            // lblnoItems
            // 
            this.lblnoItems.BackColor = System.Drawing.Color.Transparent;
            this.lblnoItems.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoItems.Location = new System.Drawing.Point(161, 34);
            this.lblnoItems.Name = "lblnoItems";
            this.lblnoItems.Size = new System.Drawing.Size(115, 22);
            this.lblnoItems.TabIndex = 165;
            this.lblnoItems.Text = "No. of Items";
            // 
            // lblVAT
            // 
            this.lblVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblVAT.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.Location = new System.Drawing.Point(161, 133);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(115, 22);
            this.lblVAT.TabIndex = 166;
            this.lblVAT.Text = "VAT";
            // 
            // lblGrandTot
            // 
            this.lblGrandTot.BackColor = System.Drawing.Color.Transparent;
            this.lblGrandTot.Font = new System.Drawing.Font("Tw Cen MT", 18F);
            this.lblGrandTot.Location = new System.Drawing.Point(161, 167);
            this.lblGrandTot.Name = "lblGrandTot";
            this.lblGrandTot.Size = new System.Drawing.Size(154, 22);
            this.lblGrandTot.TabIndex = 167;
            this.lblGrandTot.Text = "Grand Total";
            // 
            // txtNoItems
            // 
            this.txtNoItems.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoItems.Location = new System.Drawing.Point(321, 28);
            this.txtNoItems.Name = "txtNoItems";
            this.txtNoItems.Size = new System.Drawing.Size(154, 28);
            this.txtNoItems.TabIndex = 168;
            this.txtNoItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoItems_KeyPress);
            // 
            // txtSubTot
            // 
            this.txtSubTot.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTot.Location = new System.Drawing.Point(321, 62);
            this.txtSubTot.Name = "txtSubTot";
            this.txtSubTot.Size = new System.Drawing.Size(154, 28);
            this.txtSubTot.TabIndex = 169;
            // 
            // txtTotDisc
            // 
            this.txtTotDisc.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotDisc.Location = new System.Drawing.Point(321, 96);
            this.txtTotDisc.Name = "txtTotDisc";
            this.txtTotDisc.Size = new System.Drawing.Size(154, 28);
            this.txtTotDisc.TabIndex = 170;
            // 
            // txtGrandTot
            // 
            this.txtGrandTot.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTot.Location = new System.Drawing.Point(321, 164);
            this.txtGrandTot.Name = "txtGrandTot";
            this.txtGrandTot.Size = new System.Drawing.Size(154, 36);
            this.txtGrandTot.TabIndex = 171;
            // 
            // txtVAT
            // 
            this.txtVAT.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(321, 130);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(154, 28);
            this.txtVAT.TabIndex = 172;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(191, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 105);
            this.btnClose.TabIndex = 162;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditLine
            // 
            this.btnEditLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnEditLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLine.Location = new System.Drawing.Point(297, 25);
            this.btnEditLine.Name = "btnEditLine";
            this.btnEditLine.Size = new System.Drawing.Size(100, 105);
            this.btnEditLine.TabIndex = 173;
            this.btnEditLine.Text = "Edit Line";
            this.btnEditLine.UseVisualStyleBackColor = false;
            // 
            // btnItemSearch
            // 
            this.btnItemSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnItemSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemSearch.Location = new System.Drawing.Point(0, 12);
            this.btnItemSearch.Name = "btnItemSearch";
            this.btnItemSearch.Size = new System.Drawing.Size(100, 105);
            this.btnItemSearch.TabIndex = 174;
            this.btnItemSearch.Text = "Item Search";
            this.btnItemSearch.UseVisualStyleBackColor = false;
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Location = new System.Drawing.Point(420, 0);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(100, 105);
            this.btnDiscount.TabIndex = 175;
            this.btnDiscount.Text = "Discounts";
            this.btnDiscount.UseVisualStyleBackColor = false;
            // 
            // formPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlCalcu);
            this.Controls.Add(this.dataGridOrdered);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdered)).EndInit();
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridOrdered;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlCalcu;
        private System.Windows.Forms.Button btnEditTrans;
        private System.Windows.Forms.Label lblTotDisc;
        private System.Windows.Forms.Label lblSubTot;
        private System.Windows.Forms.Label lblnoItems;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblGrandTot;
        private System.Windows.Forms.TextBox txtNoItems;
        private System.Windows.Forms.TextBox txtSubTot;
        private System.Windows.Forms.TextBox txtTotDisc;
        private System.Windows.Forms.TextBox txtGrandTot;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditLine;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnItemSearch;
    }
}