namespace TeteHardware
{
    partial class formEditPromo
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
            this.comboPtype = new System.Windows.Forms.ComboBox();
            this.labelPvalue = new System.Windows.Forms.Label();
            this.txtPvalue = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelEditPromo = new System.Windows.Forms.Label();
            this.labelPtype = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboPstatus = new System.Windows.Forms.ComboBox();
            this.labelPstatus = new System.Windows.Forms.Label();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelPid = new System.Windows.Forms.Label();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.labelPpercent = new System.Windows.Forms.Label();
            this.txtPpercent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelpercentR = new System.Windows.Forms.Label();
            this.labelvalueR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboPtype
            // 
            this.comboPtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPtype.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPtype.FormattingEnabled = true;
            this.comboPtype.Items.AddRange(new object[] {
            "",
            "Percent",
            "Value"});
            this.comboPtype.Location = new System.Drawing.Point(197, 138);
            this.comboPtype.Name = "comboPtype";
            this.comboPtype.Size = new System.Drawing.Size(134, 25);
            this.comboPtype.TabIndex = 4;
            this.comboPtype.SelectedIndexChanged += new System.EventHandler(this.comboPtype_SelectedIndexChanged);
            // 
            // labelPvalue
            // 
            this.labelPvalue.AutoSize = true;
            this.labelPvalue.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPvalue.ForeColor = System.Drawing.Color.White;
            this.labelPvalue.Location = new System.Drawing.Point(51, 211);
            this.labelPvalue.Name = "labelPvalue";
            this.labelPvalue.Size = new System.Drawing.Size(94, 19);
            this.labelPvalue.TabIndex = 169;
            this.labelPvalue.Text = "Promo Value:";
            // 
            // txtPvalue
            // 
            this.txtPvalue.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPvalue.Location = new System.Drawing.Point(197, 208);
            this.txtPvalue.Name = "txtPvalue";
            this.txtPvalue.Size = new System.Drawing.Size(134, 25);
            this.txtPvalue.TabIndex = 5;
            this.txtPvalue.TextChanged += new System.EventHandler(this.txtPvalue_TextChanged);
            this.txtPvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPvalue_KeyPress);
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
            this.btnClose.Location = new System.Drawing.Point(363, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnClear.Location = new System.Drawing.Point(152, 300);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(55, 300);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 40);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(249, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelEditPromo
            // 
            this.labelEditPromo.AutoSize = true;
            this.labelEditPromo.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditPromo.ForeColor = System.Drawing.Color.White;
            this.labelEditPromo.Location = new System.Drawing.Point(24, 13);
            this.labelEditPromo.Name = "labelEditPromo";
            this.labelEditPromo.Size = new System.Drawing.Size(130, 31);
            this.labelEditPromo.TabIndex = 101;
            this.labelEditPromo.Text = "Edit Promo";
            // 
            // labelPtype
            // 
            this.labelPtype.AutoSize = true;
            this.labelPtype.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPtype.ForeColor = System.Drawing.Color.White;
            this.labelPtype.Location = new System.Drawing.Point(52, 144);
            this.labelPtype.Name = "labelPtype";
            this.labelPtype.Size = new System.Drawing.Size(89, 19);
            this.labelPtype.TabIndex = 173;
            this.labelPtype.Text = "Promo Type:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labelEditPromo);
            this.panel1.Location = new System.Drawing.Point(0, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 58);
            this.panel1.TabIndex = 171;
            // 
            // comboPstatus
            // 
            this.comboPstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPstatus.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPstatus.FormattingEnabled = true;
            this.comboPstatus.Items.AddRange(new object[] {
            "On-going",
            "Paused"});
            this.comboPstatus.Location = new System.Drawing.Point(197, 243);
            this.comboPstatus.Name = "comboPstatus";
            this.comboPstatus.Size = new System.Drawing.Size(134, 25);
            this.comboPstatus.TabIndex = 6;
            // 
            // labelPstatus
            // 
            this.labelPstatus.AutoSize = true;
            this.labelPstatus.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPstatus.ForeColor = System.Drawing.Color.White;
            this.labelPstatus.Location = new System.Drawing.Point(51, 247);
            this.labelPstatus.Name = "labelPstatus";
            this.labelPstatus.Size = new System.Drawing.Size(94, 19);
            this.labelPstatus.TabIndex = 168;
            this.labelPstatus.Text = "Promo Status:";
            // 
            // labelPname
            // 
            this.labelPname.AutoSize = true;
            this.labelPname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPname.ForeColor = System.Drawing.Color.White;
            this.labelPname.Location = new System.Drawing.Point(52, 109);
            this.labelPname.Name = "labelPname";
            this.labelPname.Size = new System.Drawing.Size(96, 19);
            this.labelPname.TabIndex = 165;
            this.labelPname.Text = "Promo Name:";
            // 
            // labelPid
            // 
            this.labelPid.AutoSize = true;
            this.labelPid.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPid.ForeColor = System.Drawing.Color.White;
            this.labelPid.Location = new System.Drawing.Point(52, 109);
            this.labelPid.Name = "labelPid";
            this.labelPid.Size = new System.Drawing.Size(71, 19);
            this.labelPid.TabIndex = 166;
            this.labelPid.Text = "Promo ID:";
            // 
            // txtPname
            // 
            this.txtPname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPname.Location = new System.Drawing.Point(197, 104);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(134, 25);
            this.txtPname.TabIndex = 3;
            // 
            // txtPid
            // 
            this.txtPid.Enabled = false;
            this.txtPid.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPid.Location = new System.Drawing.Point(197, 104);
            this.txtPid.Name = "txtPid";
            this.txtPid.ReadOnly = true;
            this.txtPid.Size = new System.Drawing.Size(134, 25);
            this.txtPid.TabIndex = 2;
            // 
            // labelPpercent
            // 
            this.labelPpercent.AutoSize = true;
            this.labelPpercent.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPpercent.ForeColor = System.Drawing.Color.White;
            this.labelPpercent.Location = new System.Drawing.Point(51, 176);
            this.labelPpercent.Name = "labelPpercent";
            this.labelPpercent.Size = new System.Drawing.Size(103, 19);
            this.labelPpercent.TabIndex = 175;
            this.labelPpercent.Text = "Promo Percent:";
            // 
            // txtPpercent
            // 
            this.txtPpercent.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPpercent.Location = new System.Drawing.Point(197, 173);
            this.txtPpercent.Name = "txtPpercent";
            this.txtPpercent.Size = new System.Drawing.Size(134, 25);
            this.txtPpercent.TabIndex = 174;
            this.txtPpercent.TextChanged += new System.EventHandler(this.txtPpercent_TextChanged);
            this.txtPpercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPpercent_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(143, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 14);
            this.label2.TabIndex = 235;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(136, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 14);
            this.label1.TabIndex = 236;
            this.label1.Text = "*";
            // 
            // labelpercentR
            // 
            this.labelpercentR.AutoSize = true;
            this.labelpercentR.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpercentR.ForeColor = System.Drawing.Color.Red;
            this.labelpercentR.Location = new System.Drawing.Point(149, 178);
            this.labelpercentR.Name = "labelpercentR";
            this.labelpercentR.Size = new System.Drawing.Size(12, 14);
            this.labelpercentR.TabIndex = 237;
            this.labelpercentR.Text = "*";
            this.labelpercentR.Visible = false;
            // 
            // labelvalueR
            // 
            this.labelvalueR.AutoSize = true;
            this.labelvalueR.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalueR.ForeColor = System.Drawing.Color.Red;
            this.labelvalueR.Location = new System.Drawing.Point(140, 213);
            this.labelvalueR.Name = "labelvalueR";
            this.labelvalueR.Size = new System.Drawing.Size(12, 14);
            this.labelvalueR.TabIndex = 238;
            this.labelvalueR.Text = "*";
            this.labelvalueR.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(140, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 14);
            this.label5.TabIndex = 239;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 240;
            this.label3.Text = "%";
            // 
            // formEditPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(404, 363);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelvalueR);
            this.Controls.Add(this.labelpercentR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPpercent);
            this.Controls.Add(this.txtPpercent);
            this.Controls.Add(this.comboPtype);
            this.Controls.Add(this.labelPvalue);
            this.Controls.Add(this.txtPvalue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelPtype);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboPstatus);
            this.Controls.Add(this.labelPstatus);
            this.Controls.Add(this.labelPname);
            this.Controls.Add(this.labelPid);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.txtPid);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formEditPromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPromo_FormClosing);
            this.Load += new System.EventHandler(this.EditPromo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditPromo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditPromo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EditPromo_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPtype;
        private System.Windows.Forms.Label labelPvalue;
        private System.Windows.Forms.TextBox txtPvalue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelEditPromo;
        private System.Windows.Forms.Label labelPtype;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboPstatus;
        private System.Windows.Forms.Label labelPstatus;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelPid;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.Label labelPpercent;
        private System.Windows.Forms.TextBox txtPpercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelpercentR;
        private System.Windows.Forms.Label labelvalueR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}