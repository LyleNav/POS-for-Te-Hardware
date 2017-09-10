namespace TeteHardware
{
    partial class formAfterLogin
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
            this.labelName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCatManage = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnProdManage = new System.Windows.Forms.Button();
            this.btnPromos = new System.Windows.Forms.Button();
            this.btnEmpManage = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnStockInDef = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCustReturn = new System.Windows.Forms.Button();
            this.btnViews = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnInstoreDam = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.labelWelcome);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 58);
            this.panel1.TabIndex = 101;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(155, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 31);
            this.labelName.TabIndex = 101;
            this.labelName.Text = "Name";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(444, 16);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(63, 27);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(35, 13);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(123, 31);
            this.labelWelcome.TabIndex = 100;
            this.labelWelcome.Text = "Welcome,";
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
            this.btnClose.Location = new System.Drawing.Point(884, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCatManage);
            this.flowLayoutPanel1.Controls.Add(this.btnSupplier);
            this.flowLayoutPanel1.Controls.Add(this.btnProdManage);
            this.flowLayoutPanel1.Controls.Add(this.btnPromos);
            this.flowLayoutPanel1.Controls.Add(this.btnEmpManage);
            this.flowLayoutPanel1.Controls.Add(this.btnStockIn);
            this.flowLayoutPanel1.Controls.Add(this.btnStockInDef);
            this.flowLayoutPanel1.Controls.Add(this.btnTransaction);
            this.flowLayoutPanel1.Controls.Add(this.btnReturn);
            this.flowLayoutPanel1.Controls.Add(this.btnCustReturn);
            this.flowLayoutPanel1.Controls.Add(this.btnViews);
            this.flowLayoutPanel1.Controls.Add(this.btnReport);
            this.flowLayoutPanel1.Controls.Add(this.btnPOS);
            this.flowLayoutPanel1.Controls.Add(this.btnInstoreDam);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(60, 113);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(796, 591);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // btnCatManage
            // 
            this.btnCatManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnCatManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnCatManage.FlatAppearance.BorderSize = 0;
            this.btnCatManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnCatManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatManage.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatManage.ForeColor = System.Drawing.Color.White;
            this.btnCatManage.Location = new System.Drawing.Point(13, 13);
            this.btnCatManage.Name = "btnCatManage";
            this.btnCatManage.Size = new System.Drawing.Size(185, 169);
            this.btnCatManage.TabIndex = 2;
            this.btnCatManage.Text = "Catalog Management";
            this.btnCatManage.UseVisualStyleBackColor = false;
            this.btnCatManage.Click += new System.EventHandler(this.btnCatManage_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnSupplier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Location = new System.Drawing.Point(204, 13);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(185, 169);
            this.btnSupplier.TabIndex = 5;
            this.btnSupplier.Text = "Supplier Management";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnProdManage
            // 
            this.btnProdManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnProdManage.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProdManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnProdManage.FlatAppearance.BorderSize = 0;
            this.btnProdManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnProdManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdManage.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdManage.ForeColor = System.Drawing.Color.White;
            this.btnProdManage.Location = new System.Drawing.Point(395, 13);
            this.btnProdManage.Name = "btnProdManage";
            this.btnProdManage.Size = new System.Drawing.Size(185, 169);
            this.btnProdManage.TabIndex = 3;
            this.btnProdManage.Text = "Product Management";
            this.btnProdManage.UseVisualStyleBackColor = false;
            this.btnProdManage.Click += new System.EventHandler(this.btnProdManage_Click);
            // 
            // btnPromos
            // 
            this.btnPromos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnPromos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPromos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnPromos.FlatAppearance.BorderSize = 0;
            this.btnPromos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnPromos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromos.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromos.ForeColor = System.Drawing.Color.White;
            this.btnPromos.Location = new System.Drawing.Point(586, 13);
            this.btnPromos.Name = "btnPromos";
            this.btnPromos.Size = new System.Drawing.Size(185, 169);
            this.btnPromos.TabIndex = 7;
            this.btnPromos.Text = "Promos";
            this.btnPromos.UseVisualStyleBackColor = false;
            this.btnPromos.Click += new System.EventHandler(this.btnPromos_Click);
            // 
            // btnEmpManage
            // 
            this.btnEmpManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnEmpManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnEmpManage.FlatAppearance.BorderSize = 0;
            this.btnEmpManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnEmpManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpManage.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpManage.ForeColor = System.Drawing.Color.White;
            this.btnEmpManage.Location = new System.Drawing.Point(13, 188);
            this.btnEmpManage.Name = "btnEmpManage";
            this.btnEmpManage.Size = new System.Drawing.Size(185, 169);
            this.btnEmpManage.TabIndex = 10;
            this.btnEmpManage.Text = "Employee Management";
            this.btnEmpManage.UseVisualStyleBackColor = false;
            this.btnEmpManage.Click += new System.EventHandler(this.btnEmpManage_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnStockIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnStockIn.FlatAppearance.BorderSize = 0;
            this.btnStockIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockIn.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.ForeColor = System.Drawing.Color.White;
            this.btnStockIn.Location = new System.Drawing.Point(204, 188);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(185, 169);
            this.btnStockIn.TabIndex = 11;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = false;
            this.btnStockIn.Click += new System.EventHandler(this.btnArr_Click);
            // 
            // btnStockInDef
            // 
            this.btnStockInDef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnStockInDef.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnStockInDef.FlatAppearance.BorderSize = 0;
            this.btnStockInDef.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnStockInDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockInDef.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockInDef.ForeColor = System.Drawing.Color.White;
            this.btnStockInDef.Location = new System.Drawing.Point(395, 188);
            this.btnStockInDef.Name = "btnStockInDef";
            this.btnStockInDef.Size = new System.Drawing.Size(185, 169);
            this.btnStockInDef.TabIndex = 12;
            this.btnStockInDef.Text = "Stock In (Defective)";
            this.btnStockInDef.UseVisualStyleBackColor = false;
            this.btnStockInDef.Click += new System.EventHandler(this.btnArrDef_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Location = new System.Drawing.Point(586, 188);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(185, 169);
            this.btnTransaction.TabIndex = 6;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnCustOrder_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(13, 363);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(185, 169);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Returns";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCustReturn
            // 
            this.btnCustReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnCustReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnCustReturn.FlatAppearance.BorderSize = 0;
            this.btnCustReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnCustReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustReturn.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustReturn.ForeColor = System.Drawing.Color.White;
            this.btnCustReturn.Location = new System.Drawing.Point(204, 363);
            this.btnCustReturn.Name = "btnCustReturn";
            this.btnCustReturn.Size = new System.Drawing.Size(185, 169);
            this.btnCustReturn.TabIndex = 9;
            this.btnCustReturn.Text = "Customer Returned";
            this.btnCustReturn.UseVisualStyleBackColor = false;
            this.btnCustReturn.Click += new System.EventHandler(this.btnCustReturn_Click);
            // 
            // btnViews
            // 
            this.btnViews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnViews.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnViews.FlatAppearance.BorderSize = 0;
            this.btnViews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnViews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViews.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViews.ForeColor = System.Drawing.Color.White;
            this.btnViews.Location = new System.Drawing.Point(395, 363);
            this.btnViews.Name = "btnViews";
            this.btnViews.Size = new System.Drawing.Size(89, 169);
            this.btnViews.TabIndex = 14;
            this.btnViews.Text = "Views";
            this.btnViews.UseVisualStyleBackColor = false;
            this.btnViews.Click += new System.EventHandler(this.btnViews_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnPOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Location = new System.Drawing.Point(585, 363);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(90, 169);
            this.btnPOS.TabIndex = 13;
            this.btnPOS.Text = "Point Of Sale";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnInstoreDam
            // 
            this.btnInstoreDam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnInstoreDam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnInstoreDam.FlatAppearance.BorderSize = 0;
            this.btnInstoreDam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnInstoreDam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstoreDam.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstoreDam.ForeColor = System.Drawing.Color.White;
            this.btnInstoreDam.Location = new System.Drawing.Point(681, 363);
            this.btnInstoreDam.Name = "btnInstoreDam";
            this.btnInstoreDam.Size = new System.Drawing.Size(90, 169);
            this.btnInstoreDam.TabIndex = 15;
            this.btnInstoreDam.Text = "InStore Damages";
            this.btnInstoreDam.UseVisualStyleBackColor = false;
            this.btnInstoreDam.Click += new System.EventHandler(this.btnInstoreDam_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(490, 363);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(89, 169);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // formAfterLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(925, 716);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formAfterLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAfterLogin_FormClosing);
            this.Load += new System.EventHandler(this.formAfterLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formAfterLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formAfterLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formAfterLogin_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCatManage;
        private System.Windows.Forms.Button btnProdManage;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnPromos;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCustReturn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnEmpManage;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Button btnStockInDef;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnViews;
        private System.Windows.Forms.Button btnInstoreDam;
        private System.Windows.Forms.Button btnReport;
    }
}