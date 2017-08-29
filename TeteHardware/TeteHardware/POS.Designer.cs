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
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlCalcu = new System.Windows.Forms.Panel();
            this.btnCash = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdered)).BeginInit();
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
            this.dataGridOrdered.Location = new System.Drawing.Point(39, 1);
            this.dataGridOrdered.Name = "dataGridOrdered";
            this.dataGridOrdered.Size = new System.Drawing.Size(1050, 152);
            this.dataGridOrdered.TabIndex = 157;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1041, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 88);
            this.btnClose.TabIndex = 158;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlDisplay.Location = new System.Drawing.Point(56, 261);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(418, 105);
            this.pnlDisplay.TabIndex = 159;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlButtons.Location = new System.Drawing.Point(56, 372);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(418, 105);
            this.pnlButtons.TabIndex = 160;
            // 
            // pnlCalcu
            // 
            this.pnlCalcu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pnlCalcu.Location = new System.Drawing.Point(56, 150);
            this.pnlCalcu.Name = "pnlCalcu";
            this.pnlCalcu.Size = new System.Drawing.Size(418, 105);
            this.pnlCalcu.TabIndex = 160;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Location = new System.Drawing.Point(935, 420);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(100, 88);
            this.btnCash.TabIndex = 161;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1041, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 88);
            this.button1.TabIndex = 162;
            this.button1.Text = "Cash";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblTotDisc
            // 
            this.lblTotDisc.BackColor = System.Drawing.Color.Transparent;
            this.lblTotDisc.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotDisc.Location = new System.Drawing.Point(637, 347);
            this.lblTotDisc.Name = "lblTotDisc";
            this.lblTotDisc.Size = new System.Drawing.Size(115, 22);
            this.lblTotDisc.TabIndex = 163;
            this.lblTotDisc.Text = "Total Discount";
            // 
            // lblSubTot
            // 
            this.lblSubTot.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTot.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTot.Location = new System.Drawing.Point(637, 321);
            this.lblSubTot.Name = "lblSubTot";
            this.lblSubTot.Size = new System.Drawing.Size(115, 22);
            this.lblSubTot.TabIndex = 164;
            this.lblSubTot.Text = "Sub-Total";
            // 
            // lblnoItems
            // 
            this.lblnoItems.BackColor = System.Drawing.Color.Transparent;
            this.lblnoItems.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoItems.Location = new System.Drawing.Point(637, 293);
            this.lblnoItems.Name = "lblnoItems";
            this.lblnoItems.Size = new System.Drawing.Size(115, 22);
            this.lblnoItems.TabIndex = 165;
            this.lblnoItems.Text = "No. of Items";
            // 
            // lblVAT
            // 
            this.lblVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblVAT.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.Location = new System.Drawing.Point(637, 399);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(115, 22);
            this.lblVAT.TabIndex = 166;
            this.lblVAT.Text = "VAT";
            // 
            // lblGrandTot
            // 
            this.lblGrandTot.BackColor = System.Drawing.Color.Transparent;
            this.lblGrandTot.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTot.Location = new System.Drawing.Point(637, 372);
            this.lblGrandTot.Name = "lblGrandTot";
            this.lblGrandTot.Size = new System.Drawing.Size(115, 22);
            this.lblGrandTot.TabIndex = 167;
            this.lblGrandTot.Text = "Grand Total";
            // 
            // txtNoItems
            // 
            this.txtNoItems.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoItems.Location = new System.Drawing.Point(745, 293);
            this.txtNoItems.Name = "txtNoItems";
            this.txtNoItems.Size = new System.Drawing.Size(120, 28);
            this.txtNoItems.TabIndex = 168;
            // 
            // txtSubTot
            // 
            this.txtSubTot.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTot.Location = new System.Drawing.Point(745, 318);
            this.txtSubTot.Name = "txtSubTot";
            this.txtSubTot.Size = new System.Drawing.Size(120, 28);
            this.txtSubTot.TabIndex = 169;
            // 
            // txtTotDisc
            // 
            this.txtTotDisc.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotDisc.Location = new System.Drawing.Point(745, 344);
            this.txtTotDisc.Name = "txtTotDisc";
            this.txtTotDisc.Size = new System.Drawing.Size(120, 28);
            this.txtTotDisc.TabIndex = 170;
            // 
            // txtGrandTot
            // 
            this.txtGrandTot.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTot.Location = new System.Drawing.Point(745, 369);
            this.txtGrandTot.Name = "txtGrandTot";
            this.txtGrandTot.Size = new System.Drawing.Size(120, 28);
            this.txtGrandTot.TabIndex = 171;
            // 
            // txtVAT
            // 
            this.txtVAT.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVAT.Location = new System.Drawing.Point(745, 396);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(120, 28);
            this.txtVAT.TabIndex = 172;
            // 
            // formPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1221, 554);
            this.ControlBox = false;
            this.Controls.Add(this.txtVAT);
            this.Controls.Add(this.txtGrandTot);
            this.Controls.Add(this.txtTotDisc);
            this.Controls.Add(this.txtSubTot);
            this.Controls.Add(this.txtNoItems);
            this.Controls.Add(this.lblGrandTot);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblnoItems);
            this.Controls.Add(this.lblSubTot);
            this.Controls.Add(this.lblTotDisc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlCalcu);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlDisplay);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridOrdered;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlCalcu;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button button1;
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
    }
}