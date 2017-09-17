namespace TeteHardware
{
    partial class formViews
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
            this.lblParent = new System.Windows.Forms.Label();
            this.comboParent = new System.Windows.Forms.ComboBox();
            this.comboChild = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datagridTableParent = new System.Windows.Forms.DataGridView();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.monCalFrom = new System.Windows.Forms.MonthCalendar();
            this.monCalTo = new System.Windows.Forms.MonthCalendar();
            this.datagridTableChild = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblViews = new System.Windows.Forms.Label();
            this.btnPrintRep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTableParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTableChild)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblParent
            // 
            this.lblParent.AutoSize = true;
            this.lblParent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblParent.Location = new System.Drawing.Point(17, 152);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(90, 19);
            this.lblParent.TabIndex = 0;
            this.lblParent.Text = "Parent Table";
            // 
            // comboParent
            // 
            this.comboParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParent.FormattingEnabled = true;
            this.comboParent.Location = new System.Drawing.Point(24, 178);
            this.comboParent.Name = "comboParent";
            this.comboParent.Size = new System.Drawing.Size(228, 27);
            this.comboParent.TabIndex = 1;
            this.comboParent.SelectedIndexChanged += new System.EventHandler(this.comboParent_SelectedIndexChanged);
            // 
            // comboChild
            // 
            this.comboChild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChild.FormattingEnabled = true;
            this.comboChild.Location = new System.Drawing.Point(271, 178);
            this.comboChild.Name = "comboChild";
            this.comboChild.Size = new System.Drawing.Size(235, 27);
            this.comboChild.TabIndex = 3;
            this.comboChild.SelectedIndexChanged += new System.EventHandler(this.comboChild_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(264, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Child Table";
            // 
            // datagridTableParent
            // 
            this.datagridTableParent.AllowUserToAddRows = false;
            this.datagridTableParent.AllowUserToDeleteRows = false;
            this.datagridTableParent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.datagridTableParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTableParent.Location = new System.Drawing.Point(21, 208);
            this.datagridTableParent.Name = "datagridTableParent";
            this.datagridTableParent.ReadOnly = true;
            this.datagridTableParent.RowHeadersVisible = false;
            this.datagridTableParent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTableParent.Size = new System.Drawing.Size(485, 388);
            this.datagridTableParent.TabIndex = 4;
            this.datagridTableParent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridTable_CellClick);
            this.datagridTableParent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datagridTable_KeyDown);
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDateTo.Location = new System.Drawing.Point(264, 85);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(63, 19);
            this.lblDateTo.TabIndex = 7;
            this.lblDateTo.Text = "Date To:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDateFrom.Location = new System.Drawing.Point(17, 85);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(79, 19);
            this.lblDateFrom.TabIndex = 5;
            this.lblDateFrom.Text = "Date From:";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(25, 110);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(199, 25);
            this.txtDateFrom.TabIndex = 8;
            this.txtDateFrom.Enter += new System.EventHandler(this.txtDateFrom_Enter);
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(271, 110);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(199, 25);
            this.txtDateTo.TabIndex = 9;
            this.txtDateTo.Enter += new System.EventHandler(this.txtDateTo_Enter);
            // 
            // monCalFrom
            // 
            this.monCalFrom.Location = new System.Drawing.Point(529, 533);
            this.monCalFrom.Name = "monCalFrom";
            this.monCalFrom.TabIndex = 10;
            this.monCalFrom.Visible = false;
            this.monCalFrom.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monCalFrom_DateSelected);
            // 
            // monCalTo
            // 
            this.monCalTo.Location = new System.Drawing.Point(758, 533);
            this.monCalTo.Name = "monCalTo";
            this.monCalTo.TabIndex = 11;
            this.monCalTo.Visible = false;
            this.monCalTo.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monCalTo_DateSelected);
            // 
            // datagridTableChild
            // 
            this.datagridTableChild.AllowUserToAddRows = false;
            this.datagridTableChild.AllowUserToDeleteRows = false;
            this.datagridTableChild.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.datagridTableChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTableChild.Location = new System.Drawing.Point(529, 125);
            this.datagridTableChild.Name = "datagridTableChild";
            this.datagridTableChild.ReadOnly = true;
            this.datagridTableChild.RowHeadersVisible = false;
            this.datagridTableChild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridTableChild.Size = new System.Drawing.Size(743, 471);
            this.datagridTableChild.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(525, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Details :";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1256, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 156;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblViews);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 58);
            this.panel1.TabIndex = 158;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(356, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 27);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblViews
            // 
            this.lblViews.AutoSize = true;
            this.lblViews.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViews.ForeColor = System.Drawing.Color.White;
            this.lblViews.Location = new System.Drawing.Point(35, 13);
            this.lblViews.Name = "lblViews";
            this.lblViews.Size = new System.Drawing.Size(77, 31);
            this.lblViews.TabIndex = 101;
            this.lblViews.Text = "Views";
            // 
            // btnPrintRep
            // 
            this.btnPrintRep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnPrintRep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnPrintRep.FlatAppearance.BorderSize = 0;
            this.btnPrintRep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnPrintRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintRep.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintRep.ForeColor = System.Drawing.Color.White;
            this.btnPrintRep.Location = new System.Drawing.Point(62, 602);
            this.btnPrintRep.Name = "btnPrintRep";
            this.btnPrintRep.Size = new System.Drawing.Size(104, 53);
            this.btnPrintRep.TabIndex = 159;
            this.btnPrintRep.Text = "Print [F5]";
            this.btnPrintRep.UseVisualStyleBackColor = false;
            this.btnPrintRep.Visible = false;
            this.btnPrintRep.Click += new System.EventHandler(this.btnPrintRep_Click);
            // 
            // formViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1297, 632);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrintRep);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datagridTableChild);
            this.Controls.Add(this.monCalTo);
            this.Controls.Add(this.monCalFrom);
            this.Controls.Add(this.txtDateTo);
            this.Controls.Add(this.txtDateFrom);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.datagridTableParent);
            this.Controls.Add(this.comboChild);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboParent);
            this.Controls.Add(this.lblParent);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formViews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formViews_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formViews_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formViews_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formViews_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.datagridTableParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTableChild)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblParent;
        private System.Windows.Forms.ComboBox comboParent;
        private System.Windows.Forms.ComboBox comboChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagridTableParent;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.MonthCalendar monCalFrom;
        private System.Windows.Forms.MonthCalendar monCalTo;
        private System.Windows.Forms.DataGridView datagridTableChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrintRep;
        public System.Windows.Forms.Label lblViews;
    }
}