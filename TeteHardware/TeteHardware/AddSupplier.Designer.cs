﻿namespace TeteHardware
{
    partial class formAddSupplier
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
            this.labelSname = new System.Windows.Forms.Label();
            this.labelSid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelAddSupplier = new System.Windows.Forms.Label();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelSaddress = new System.Windows.Forms.Label();
            this.txtSaddress = new System.Windows.Forms.TextBox();
            this.labelScontact = new System.Windows.Forms.Label();
            this.txtScontact = new System.Windows.Forms.TextBox();
            this.labelScontactNum = new System.Windows.Forms.Label();
            this.txtScontactNum = new System.Windows.Forms.TextBox();
            this.labelSothers = new System.Windows.Forms.Label();
            this.txtSothers = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSname
            // 
            this.labelSname.AutoSize = true;
            this.labelSname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSname.ForeColor = System.Drawing.Color.White;
            this.labelSname.Location = new System.Drawing.Point(51, 145);
            this.labelSname.Name = "labelSname";
            this.labelSname.Size = new System.Drawing.Size(108, 19);
            this.labelSname.TabIndex = 150;
            this.labelSname.Text = "Supplier Name:";
            // 
            // labelSid
            // 
            this.labelSid.AutoSize = true;
            this.labelSid.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSid.ForeColor = System.Drawing.Color.White;
            this.labelSid.Location = new System.Drawing.Point(51, 110);
            this.labelSid.Name = "labelSid";
            this.labelSid.Size = new System.Drawing.Size(83, 19);
            this.labelSid.TabIndex = 151;
            this.labelSid.Text = "Supplier ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labelAddSupplier);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 58);
            this.panel1.TabIndex = 152;
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelAddSupplier
            // 
            this.labelAddSupplier.AutoSize = true;
            this.labelAddSupplier.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSupplier.ForeColor = System.Drawing.Color.White;
            this.labelAddSupplier.Location = new System.Drawing.Point(24, 13);
            this.labelAddSupplier.Name = "labelAddSupplier";
            this.labelAddSupplier.Size = new System.Drawing.Size(215, 31);
            this.labelAddSupplier.TabIndex = 101;
            this.labelAddSupplier.Text = "Add New Supplier";
            // 
            // txtSid
            // 
            this.txtSid.Enabled = false;
            this.txtSid.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSid.Location = new System.Drawing.Point(196, 105);
            this.txtSid.Name = "txtSid";
            this.txtSid.ReadOnly = true;
            this.txtSid.Size = new System.Drawing.Size(158, 25);
            this.txtSid.TabIndex = 2;
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(196, 140);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(158, 25);
            this.txtSname.TabIndex = 3;
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
            this.btnClose.Location = new System.Drawing.Point(367, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(267, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 40);
            this.btnCancel.TabIndex = 10;
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
            this.btnClear.Location = new System.Drawing.Point(170, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 40);
            this.btnClear.TabIndex = 9;
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
            this.btnAdd.Location = new System.Drawing.Point(73, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelSaddress
            // 
            this.labelSaddress.AutoSize = true;
            this.labelSaddress.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaddress.ForeColor = System.Drawing.Color.White;
            this.labelSaddress.Location = new System.Drawing.Point(51, 177);
            this.labelSaddress.Name = "labelSaddress";
            this.labelSaddress.Size = new System.Drawing.Size(120, 19);
            this.labelSaddress.TabIndex = 171;
            this.labelSaddress.Text = "Supplier Address:";
            // 
            // txtSaddress
            // 
            this.txtSaddress.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaddress.Location = new System.Drawing.Point(196, 173);
            this.txtSaddress.Name = "txtSaddress";
            this.txtSaddress.Size = new System.Drawing.Size(158, 25);
            this.txtSaddress.TabIndex = 4;
            // 
            // labelScontact
            // 
            this.labelScontact.AutoSize = true;
            this.labelScontact.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScontact.ForeColor = System.Drawing.Color.White;
            this.labelScontact.Location = new System.Drawing.Point(51, 210);
            this.labelScontact.Name = "labelScontact";
            this.labelScontact.Size = new System.Drawing.Size(117, 19);
            this.labelScontact.TabIndex = 170;
            this.labelScontact.Text = "Supplier Contact:";
            // 
            // txtScontact
            // 
            this.txtScontact.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScontact.Location = new System.Drawing.Point(196, 206);
            this.txtScontact.Name = "txtScontact";
            this.txtScontact.Size = new System.Drawing.Size(158, 25);
            this.txtScontact.TabIndex = 5;
            // 
            // labelScontactNum
            // 
            this.labelScontactNum.AutoSize = true;
            this.labelScontactNum.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScontactNum.ForeColor = System.Drawing.Color.White;
            this.labelScontactNum.Location = new System.Drawing.Point(51, 243);
            this.labelScontactNum.Name = "labelScontactNum";
            this.labelScontactNum.Size = new System.Drawing.Size(132, 19);
            this.labelScontactNum.TabIndex = 173;
            this.labelScontactNum.Text = "Supplier Contact #:";
            // 
            // txtScontactNum
            // 
            this.txtScontactNum.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScontactNum.Location = new System.Drawing.Point(196, 239);
            this.txtScontactNum.Name = "txtScontactNum";
            this.txtScontactNum.Size = new System.Drawing.Size(158, 25);
            this.txtScontactNum.TabIndex = 6;
            // 
            // labelSothers
            // 
            this.labelSothers.AutoSize = true;
            this.labelSothers.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSothers.ForeColor = System.Drawing.Color.White;
            this.labelSothers.Location = new System.Drawing.Point(51, 276);
            this.labelSothers.Name = "labelSothers";
            this.labelSothers.Size = new System.Drawing.Size(54, 19);
            this.labelSothers.TabIndex = 175;
            this.labelSothers.Text = "Others:";
            // 
            // txtSothers
            // 
            this.txtSothers.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSothers.Location = new System.Drawing.Point(196, 273);
            this.txtSothers.Multiline = true;
            this.txtSothers.Name = "txtSothers";
            this.txtSothers.Size = new System.Drawing.Size(158, 42);
            this.txtSothers.TabIndex = 7;
            // 
            // formAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(408, 392);
            this.ControlBox = false;
            this.Controls.Add(this.labelSothers);
            this.Controls.Add(this.txtSothers);
            this.Controls.Add(this.labelScontactNum);
            this.Controls.Add(this.txtScontactNum);
            this.Controls.Add(this.labelSaddress);
            this.Controls.Add(this.txtSaddress);
            this.Controls.Add(this.labelScontact);
            this.Controls.Add(this.txtScontact);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSname);
            this.Controls.Add(this.labelSid);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtSid);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formAddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAddSupplier_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formAddSupplier_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formAddSupplier_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formAddSupplier_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSname;
        private System.Windows.Forms.Label labelSid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelAddSupplier;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSaddress;
        private System.Windows.Forms.TextBox txtSaddress;
        private System.Windows.Forms.Label labelScontact;
        private System.Windows.Forms.TextBox txtScontact;
        private System.Windows.Forms.Label labelScontactNum;
        private System.Windows.Forms.TextBox txtScontactNum;
        private System.Windows.Forms.Label labelSothers;
        private System.Windows.Forms.TextBox txtSothers;
    }
}