namespace TeteHardware
{
    partial class formAddEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelAddEmployee = new System.Windows.Forms.Label();
            this.labelEuser = new System.Windows.Forms.Label();
            this.txtEuser = new System.Windows.Forms.TextBox();
            this.labelEpass = new System.Windows.Forms.Label();
            this.txtEpass = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelEname = new System.Windows.Forms.Label();
            this.labelEid = new System.Windows.Forms.Label();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtEid = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelLevel = new System.Windows.Forms.Label();
            this.comboElevel = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labelAddEmployee);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 58);
            this.panel1.TabIndex = 153;
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
            // labelAddEmployee
            // 
            this.labelAddEmployee.AutoSize = true;
            this.labelAddEmployee.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddEmployee.ForeColor = System.Drawing.Color.White;
            this.labelAddEmployee.Location = new System.Drawing.Point(24, 13);
            this.labelAddEmployee.Name = "labelAddEmployee";
            this.labelAddEmployee.Size = new System.Drawing.Size(231, 31);
            this.labelAddEmployee.TabIndex = 101;
            this.labelAddEmployee.Text = "Add New Employee";
            // 
            // labelEuser
            // 
            this.labelEuser.AutoSize = true;
            this.labelEuser.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEuser.ForeColor = System.Drawing.Color.White;
            this.labelEuser.Location = new System.Drawing.Point(51, 177);
            this.labelEuser.Name = "labelEuser";
            this.labelEuser.Size = new System.Drawing.Size(76, 19);
            this.labelEuser.TabIndex = 182;
            this.labelEuser.Text = "Username:";
            // 
            // txtEuser
            // 
            this.txtEuser.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuser.Location = new System.Drawing.Point(196, 174);
            this.txtEuser.Name = "txtEuser";
            this.txtEuser.Size = new System.Drawing.Size(158, 25);
            this.txtEuser.TabIndex = 4;
            // 
            // labelEpass
            // 
            this.labelEpass.AutoSize = true;
            this.labelEpass.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEpass.ForeColor = System.Drawing.Color.White;
            this.labelEpass.Location = new System.Drawing.Point(51, 210);
            this.labelEpass.Name = "labelEpass";
            this.labelEpass.Size = new System.Drawing.Size(73, 19);
            this.labelEpass.TabIndex = 181;
            this.labelEpass.Text = "Password:";
            // 
            // txtEpass
            // 
            this.txtEpass.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpass.Location = new System.Drawing.Point(196, 207);
            this.txtEpass.Name = "txtEpass";
            this.txtEpass.PasswordChar = '*';
            this.txtEpass.Size = new System.Drawing.Size(158, 25);
            this.txtEpass.TabIndex = 5;
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
            this.btnCancel.Location = new System.Drawing.Point(264, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 40);
            this.btnCancel.TabIndex = 9;
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
            this.btnClear.Location = new System.Drawing.Point(167, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 40);
            this.btnClear.TabIndex = 8;
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
            this.btnAdd.Location = new System.Drawing.Point(70, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 40);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelEname
            // 
            this.labelEname.AutoSize = true;
            this.labelEname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEname.ForeColor = System.Drawing.Color.White;
            this.labelEname.Location = new System.Drawing.Point(51, 145);
            this.labelEname.Name = "labelEname";
            this.labelEname.Size = new System.Drawing.Size(118, 19);
            this.labelEname.TabIndex = 179;
            this.labelEname.Text = "Employee Name:";
            // 
            // labelEid
            // 
            this.labelEid.AutoSize = true;
            this.labelEid.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEid.ForeColor = System.Drawing.Color.White;
            this.labelEid.Location = new System.Drawing.Point(51, 110);
            this.labelEid.Name = "labelEid";
            this.labelEid.Size = new System.Drawing.Size(93, 19);
            this.labelEid.TabIndex = 180;
            this.labelEid.Text = "Employee ID:";
            // 
            // txtEname
            // 
            this.txtEname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEname.Location = new System.Drawing.Point(196, 140);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(158, 25);
            this.txtEname.TabIndex = 3;
            // 
            // txtEid
            // 
            this.txtEid.Enabled = false;
            this.txtEid.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEid.Location = new System.Drawing.Point(196, 105);
            this.txtEid.Name = "txtEid";
            this.txtEid.ReadOnly = true;
            this.txtEid.Size = new System.Drawing.Size(158, 25);
            this.txtEid.TabIndex = 2;
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
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.Color.White;
            this.labelLevel.Location = new System.Drawing.Point(51, 243);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(45, 19);
            this.labelLevel.TabIndex = 184;
            this.labelLevel.Text = "Level:";
            // 
            // comboElevel
            // 
            this.comboElevel.AllowDrop = true;
            this.comboElevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboElevel.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboElevel.FormattingEnabled = true;
            this.comboElevel.Items.AddRange(new object[] {
            "",
            "Admin",
            "Cashier"});
            this.comboElevel.Location = new System.Drawing.Point(196, 240);
            this.comboElevel.Name = "comboElevel";
            this.comboElevel.Size = new System.Drawing.Size(159, 25);
            this.comboElevel.TabIndex = 6;
            // 
            // formAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(408, 341);
            this.ControlBox = false;
            this.Controls.Add(this.comboElevel);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelEuser);
            this.Controls.Add(this.txtEuser);
            this.Controls.Add(this.labelEpass);
            this.Controls.Add(this.txtEpass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelEname);
            this.Controls.Add(this.labelEid);
            this.Controls.Add(this.txtEname);
            this.Controls.Add(this.txtEid);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAddEmployee_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formAddEmployee_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formAddEmployee_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formAddEmployee_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelAddEmployee;
        private System.Windows.Forms.Label labelEuser;
        private System.Windows.Forms.TextBox txtEuser;
        private System.Windows.Forms.Label labelEpass;
        private System.Windows.Forms.TextBox txtEpass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelEname;
        private System.Windows.Forms.Label labelEid;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtEid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ComboBox comboElevel;
    }
}