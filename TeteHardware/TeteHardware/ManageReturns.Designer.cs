namespace TeteHardware
{
    partial class formReturns
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.comboSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calReturned = new System.Windows.Forms.MonthCalendar();
            this.txtCalReturn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.combosupID = new System.Windows.Forms.ComboBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.labelReference = new System.Windows.Forms.Label();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
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
            this.btnClose.Location = new System.Drawing.Point(580, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboSupplier
            // 
            this.comboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSupplier.FormattingEnabled = true;
            this.comboSupplier.Location = new System.Drawing.Point(118, 140);
            this.comboSupplier.Name = "comboSupplier";
            this.comboSupplier.Size = new System.Drawing.Size(181, 27);
            this.comboSupplier.TabIndex = 3;
            this.comboSupplier.SelectedIndexChanged += new System.EventHandler(this.comboSupplier_SelectedIndexChanged);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(33, 143);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(65, 19);
            this.lblSupplier.TabIndex = 159;
            this.lblSupplier.Text = "Supplier:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(118, 470);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(181, 25);
            this.txtQty.TabIndex = 5;
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 164;
            this.label1.Text = "Quantity:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(118, 512);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(451, 50);
            this.txtRemarks.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 166;
            this.label2.Text = "Remarks:";
            // 
            // calReturned
            // 
            this.calReturned.Location = new System.Drawing.Point(573, 566);
            this.calReturned.Name = "calReturned";
            this.calReturned.TabIndex = 225;
            this.calReturned.Visible = false;
            this.calReturned.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calReturned_DateSelected);
            // 
            // txtCalReturn
            // 
            this.txtCalReturn.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalReturn.Location = new System.Drawing.Point(415, 140);
            this.txtCalReturn.Name = "txtCalReturn";
            this.txtCalReturn.Size = new System.Drawing.Size(154, 25);
            this.txtCalReturn.TabIndex = 4;
            this.txtCalReturn.Click += new System.EventHandler(this.txtCalReturn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 58);
            this.panel1.TabIndex = 228;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(360, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 27);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(24, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(298, 31);
            this.labelName.TabIndex = 101;
            this.labelName.Text = "Returned Items to Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(305, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 229;
            this.label3.Text = "Date Returned:";
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
            this.btnClear.Location = new System.Drawing.Point(287, 587);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
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
            this.btnSave.Location = new System.Drawing.Point(153, 587);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(415, 587);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // combosupID
            // 
            this.combosupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combosupID.FormattingEnabled = true;
            this.combosupID.Location = new System.Drawing.Point(398, 83);
            this.combosupID.Name = "combosupID";
            this.combosupID.Size = new System.Drawing.Size(171, 27);
            this.combosupID.TabIndex = 233;
            this.combosupID.Visible = false;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(118, 103);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(181, 25);
            this.txtReference.TabIndex = 2;
            // 
            // labelReference
            // 
            this.labelReference.AutoSize = true;
            this.labelReference.ForeColor = System.Drawing.Color.White;
            this.labelReference.Location = new System.Drawing.Point(33, 106);
            this.labelReference.Name = "labelReference";
            this.labelReference.Size = new System.Drawing.Size(76, 19);
            this.labelReference.TabIndex = 235;
            this.labelReference.Text = "Reference:";
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProduct.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridProduct.EnableHeadersVisualStyles = false;
            this.dataGridProduct.Location = new System.Drawing.Point(118, 179);
            this.dataGridProduct.MultiSelect = false;
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridProduct.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridProduct.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduct.Size = new System.Drawing.Size(451, 277);
            this.dataGridProduct.TabIndex = 163;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(103, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 14);
            this.label5.TabIndex = 255;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(93, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 14);
            this.label4.TabIndex = 256;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(403, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 14);
            this.label6.TabIndex = 257;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(95, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 14);
            this.label7.TabIndex = 258;
            this.label7.Text = "*";
            // 
            // formReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(621, 640);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelReference);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.calReturned);
            this.Controls.Add(this.combosupID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCalReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProduct);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.comboSupplier);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formReturns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formReturns_Load);
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

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar calReturned;
        public System.Windows.Forms.TextBox txtCalReturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox combosupID;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.Label labelReference;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}