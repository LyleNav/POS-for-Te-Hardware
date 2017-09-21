namespace TeteHardware
{
    partial class formInStoreDamages
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelEditSupplier = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtRem = new System.Windows.Forms.TextBox();
            this.calMon = new System.Windows.Forms.MonthCalendar();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labelEditSupplier);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 58);
            this.panel1.TabIndex = 161;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(262, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 27);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelEditSupplier
            // 
            this.labelEditSupplier.AutoSize = true;
            this.labelEditSupplier.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditSupplier.ForeColor = System.Drawing.Color.White;
            this.labelEditSupplier.Location = new System.Drawing.Point(24, 13);
            this.labelEditSupplier.Name = "labelEditSupplier";
            this.labelEditSupplier.Size = new System.Drawing.Size(208, 31);
            this.labelEditSupplier.TabIndex = 101;
            this.labelEditSupplier.Text = "In-Store Damages";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(36, 105);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 19);
            this.lblDate.TabIndex = 162;
            this.lblDate.Text = "Date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 163;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 164;
            this.label2.Text = "Item Damaged:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 165;
            this.label3.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 166;
            this.label4.Text = "Remarks:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(154, 102);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(151, 25);
            this.txtDate.TabIndex = 2;
            this.txtDate.Enter += new System.EventHandler(this.txtDate_Enter);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(154, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 25);
            this.txtName.TabIndex = 3;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(154, 176);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(307, 25);
            this.txtProdName.TabIndex = 4;
            this.txtProdName.Enter += new System.EventHandler(this.txtProdName_Enter);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(154, 215);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(151, 25);
            this.txtQty.TabIndex = 5;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtRem
            // 
            this.txtRem.Location = new System.Drawing.Point(154, 254);
            this.txtRem.Multiline = true;
            this.txtRem.Name = "txtRem";
            this.txtRem.Size = new System.Drawing.Size(307, 49);
            this.txtRem.TabIndex = 6;
            // 
            // calMon
            // 
            this.calMon.Location = new System.Drawing.Point(202, 390);
            this.calMon.Name = "calMon";
            this.calMon.TabIndex = 172;
            this.calMon.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calMon_DateSelected);
            // 
            // txtProdID
            // 
            this.txtProdID.Location = new System.Drawing.Point(339, 215);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(122, 25);
            this.txtProdID.TabIndex = 173;
            this.txtProdID.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Location = new System.Drawing.Point(104, 338);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(91, 53);
            this.btnProduct.TabIndex = 7;
            this.btnProduct.Text = "Product (F6)";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(219, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 53);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClear.Location = new System.Drawing.Point(326, 338);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 53);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(370, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 53);
            this.btnExit.TabIndex = 235;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnClose.Location = new System.Drawing.Point(480, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.AllowUserToResizeColumns = false;
            this.dataGridProduct.AllowUserToResizeRows = false;
            this.dataGridProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProduct.EnableHeadersVisualStyles = false;
            this.dataGridProduct.GridColor = System.Drawing.Color.Yellow;
            this.dataGridProduct.Location = new System.Drawing.Point(480, 296);
            this.dataGridProduct.MultiSelect = false;
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridProduct.Size = new System.Drawing.Size(118, 95);
            this.dataGridProduct.TabIndex = 238;
            this.dataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellClick);
            this.dataGridProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridProduct_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(75, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 14);
            this.label5.TabIndex = 239;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(83, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 14);
            this.label6.TabIndex = 240;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(139, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 14);
            this.label7.TabIndex = 241;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(98, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 14);
            this.label8.TabIndex = 242;
            this.label8.Text = "*";
            // 
            // formInStoreDamages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(521, 414);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.txtProdID);
            this.Controls.Add(this.calMon);
            this.Controls.Add(this.txtRem);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formInStoreDamages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formInStoreDamages_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formReturns_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formReturns_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formReturns_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelEditSupplier;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtRem;
        private System.Windows.Forms.MonthCalendar calMon;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}