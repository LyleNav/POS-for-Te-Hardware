namespace TeteHardware
{
    partial class formArrival
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelAddEmployee = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdateArrival = new System.Windows.Forms.TextBox();
            this.calArrival = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnClose.Location = new System.Drawing.Point(389, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 193;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(272, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 27);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelAddEmployee
            // 
            this.labelAddEmployee.AutoSize = true;
            this.labelAddEmployee.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddEmployee.ForeColor = System.Drawing.Color.White;
            this.labelAddEmployee.Location = new System.Drawing.Point(24, 13);
            this.labelAddEmployee.Name = "labelAddEmployee";
            this.labelAddEmployee.Size = new System.Drawing.Size(87, 31);
            this.labelAddEmployee.TabIndex = 101;
            this.labelAddEmployee.Text = "Arrival";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labelAddEmployee);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 58);
            this.panel1.TabIndex = 194;
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(357, 82);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(191, 20);
            this.txtTable.TabIndex = 195;
            this.txtTable.Visible = false;
            // 
            // txtSearchID
            // 
            this.txtSearchID.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchID.Location = new System.Drawing.Point(34, 97);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(77, 25);
            this.txtSearchID.TabIndex = 197;
            this.txtSearchID.TextChanged += new System.EventHandler(this.txtSearchID_TextChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(203, 97);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(122, 25);
            this.txtSearchName.TabIndex = 199;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.AllowUserToResizeColumns = false;
            this.dataGridProduct.AllowUserToResizeRows = false;
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProduct.EnableHeadersVisualStyles = false;
            this.dataGridProduct.Location = new System.Drawing.Point(30, 135);
            this.dataGridProduct.MultiSelect = false;
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridProduct.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridProduct.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduct.Size = new System.Drawing.Size(357, 155);
            this.dataGridProduct.TabIndex = 200;
            this.dataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellClick);
            // 
            // txtItemName
            // 
            this.txtItemName.Enabled = false;
            this.txtItemName.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(98, 305);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(289, 25);
            this.txtItemName.TabIndex = 201;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(26, 306);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(40, 19);
            this.lblItemName.TabIndex = 202;
            this.lblItemName.Text = "Item:";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(357, 56);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(77, 20);
            this.txtItemID.TabIndex = 203;
            this.txtItemID.Visible = false;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(26, 333);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(71, 19);
            this.lblQty.TabIndex = 205;
            this.lblQty.Text = "Quantity: ";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(98, 334);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(79, 25);
            this.txtQty.TabIndex = 204;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(26, 364);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 19);
            this.lblStatus.TabIndex = 207;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(98, 364);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(289, 40);
            this.txtStatus.TabIndex = 206;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(269, 438);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 40);
            this.btnCancel.TabIndex = 210;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(172, 438);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 40);
            this.btnClear.TabIndex = 209;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(75, 438);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 40);
            this.btnAdd.TabIndex = 208;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 212;
            this.label1.Text = "Date Arrival:";
            // 
            // txtdateArrival
            // 
            this.txtdateArrival.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdateArrival.Location = new System.Drawing.Point(269, 334);
            this.txtdateArrival.Name = "txtdateArrival";
            this.txtdateArrival.Size = new System.Drawing.Size(118, 25);
            this.txtdateArrival.TabIndex = 211;
            this.txtdateArrival.Enter += new System.EventHandler(this.txtdateArrival_Enter);
            // 
            // calArrival
            // 
            this.calArrival.Location = new System.Drawing.Point(160, 333);
            this.calArrival.Name = "calArrival";
            this.calArrival.TabIndex = 213;
            this.calArrival.Visible = false;
            this.calArrival.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calArrival_DateSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 214;
            this.label2.Text = "Search by ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 215;
            this.label3.Text = "Search by Name:";
            // 
            // formArrival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(430, 512);
            this.ControlBox = false;
            this.Controls.Add(this.calArrival);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdateArrival);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.dataGridProduct);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formArrival";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formArrival_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formArrival_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formArrival_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formArrival_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelAddEmployee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.TextBox txtTable;
        public System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblQty;
        public System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtdateArrival;
        private System.Windows.Forms.MonthCalendar calArrival;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}