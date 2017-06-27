namespace BackEnd
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView_Details = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Camping = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_Search = new System.Windows.Forms.Label();
            this.comboBox_Search = new System.Windows.Forms.ComboBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVisitorInfo = new System.Windows.Forms.Button();
            this.btnCampInfo = new System.Windows.Forms.Button();
            this.btnShopInfo = new System.Windows.Forms.Button();
            this.btnSalesInfo = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lbWorstSeller = new System.Windows.Forms.Label();
            this.lbWorstSellerTitle = new System.Windows.Forms.Label();
            this.lbCampAmount = new System.Windows.Forms.Label();
            this.lbCampAmountTitle = new System.Windows.Forms.Label();
            this.lbPopularShop = new System.Windows.Forms.Label();
            this.lbPopularShopTitle = new System.Windows.Forms.Label();
            this.lbBestSeller = new System.Windows.Forms.Label();
            this.lbBestSellerTitle = new System.Windows.Forms.Label();
            this.lbEarned = new System.Windows.Forms.Label();
            this.lbEarnedTitle = new System.Windows.Forms.Label();
            this.lbCheckedOut = new System.Windows.Forms.Label();
            this.lbPending = new System.Windows.Forms.Label();
            this.lbCheckedOutTitle = new System.Windows.Forms.Label();
            this.lbPendingTitle = new System.Windows.Forms.Label();
            this.lbVisitors = new System.Windows.Forms.Label();
            this.lbTickets = new System.Windows.Forms.Label();
            this.lbVisitorsTitle = new System.Windows.Forms.Label();
            this.lbTicketsTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Details
            // 
            this.listView_Details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Fullname,
            this.Status,
            this.Balance,
            this.Camping});
            this.listView_Details.Location = new System.Drawing.Point(53, 39);
            this.listView_Details.Margin = new System.Windows.Forms.Padding(4);
            this.listView_Details.Name = "listView_Details";
            this.listView_Details.Size = new System.Drawing.Size(645, 230);
            this.listView_Details.TabIndex = 0;
            this.listView_Details.UseCompatibleStateImageBehavior = false;
            this.listView_Details.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Fullname
            // 
            this.Fullname.Text = "Name";
            this.Fullname.Width = 113;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 126;
            // 
            // Balance
            // 
            this.Balance.Text = "Balance";
            this.Balance.Width = 114;
            // 
            // Camping
            // 
            this.Camping.Text = "Camping";
            this.Camping.Width = 151;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Location = new System.Drawing.Point(50, 292);
            this.label_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(77, 17);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "Search By:";
            // 
            // comboBox_Search
            // 
            this.comboBox_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Search.FormattingEnabled = true;
            this.comboBox_Search.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Status",
            "Balance",
            "Camping"});
            this.comboBox_Search.Location = new System.Drawing.Point(135, 292);
            this.comboBox_Search.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(127, 24);
            this.comboBox_Search.TabIndex = 2;
            this.comboBox_Search.SelectedIndexChanged += new System.EventHandler(this.comboBox_Search_SelectedIndexChanged);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(307, 292);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(120, 26);
            this.textBox_Search.TabIndex = 3;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnVisitorInfo);
            this.groupBox1.Controls.Add(this.btnCampInfo);
            this.groupBox1.Controls.Add(this.btnShopInfo);
            this.groupBox1.Controls.Add(this.btnSalesInfo);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(739, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 357);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            // 
            // btnVisitorInfo
            // 
            this.btnVisitorInfo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnVisitorInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVisitorInfo.Location = new System.Drawing.Point(17, 38);
            this.btnVisitorInfo.Name = "btnVisitorInfo";
            this.btnVisitorInfo.Size = new System.Drawing.Size(150, 37);
            this.btnVisitorInfo.TabIndex = 4;
            this.btnVisitorInfo.Text = "Event Information";
            this.btnVisitorInfo.UseVisualStyleBackColor = false;
            this.btnVisitorInfo.Click += new System.EventHandler(this.btnVisitorInfo_Click);
            // 
            // btnCampInfo
            // 
            this.btnCampInfo.BackColor = System.Drawing.Color.Chocolate;
            this.btnCampInfo.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnCampInfo.Location = new System.Drawing.Point(17, 292);
            this.btnCampInfo.Name = "btnCampInfo";
            this.btnCampInfo.Size = new System.Drawing.Size(150, 34);
            this.btnCampInfo.TabIndex = 3;
            this.btnCampInfo.Text = "Camping Information";
            this.btnCampInfo.UseVisualStyleBackColor = false;
            this.btnCampInfo.Click += new System.EventHandler(this.btnCampInfo_Click);
            // 
            // btnShopInfo
            // 
            this.btnShopInfo.BackColor = System.Drawing.Color.Maroon;
            this.btnShopInfo.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnShopInfo.Location = new System.Drawing.Point(17, 205);
            this.btnShopInfo.Name = "btnShopInfo";
            this.btnShopInfo.Size = new System.Drawing.Size(150, 34);
            this.btnShopInfo.TabIndex = 2;
            this.btnShopInfo.Text = "Shop Information";
            this.btnShopInfo.UseVisualStyleBackColor = false;
            this.btnShopInfo.Click += new System.EventHandler(this.btnStandsInfo_Click);
            // 
            // btnSalesInfo
            // 
            this.btnSalesInfo.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSalesInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesInfo.Location = new System.Drawing.Point(17, 121);
            this.btnSalesInfo.Name = "btnSalesInfo";
            this.btnSalesInfo.Size = new System.Drawing.Size(150, 34);
            this.btnSalesInfo.TabIndex = 1;
            this.btnSalesInfo.Text = "Sales Information";
            this.btnSalesInfo.UseVisualStyleBackColor = false;
            this.btnSalesInfo.Click += new System.EventHandler(this.btnSalesInfo_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.gbInfo.Controls.Add(this.lbWorstSeller);
            this.gbInfo.Controls.Add(this.lbWorstSellerTitle);
            this.gbInfo.Controls.Add(this.lbCampAmount);
            this.gbInfo.Controls.Add(this.lbCampAmountTitle);
            this.gbInfo.Controls.Add(this.lbPopularShop);
            this.gbInfo.Controls.Add(this.lbPopularShopTitle);
            this.gbInfo.Controls.Add(this.lbBestSeller);
            this.gbInfo.Controls.Add(this.lbBestSellerTitle);
            this.gbInfo.Controls.Add(this.lbEarned);
            this.gbInfo.Controls.Add(this.lbEarnedTitle);
            this.gbInfo.Controls.Add(this.lbCheckedOut);
            this.gbInfo.Controls.Add(this.lbPending);
            this.gbInfo.Controls.Add(this.lbCheckedOutTitle);
            this.gbInfo.Controls.Add(this.lbPendingTitle);
            this.gbInfo.Controls.Add(this.lbVisitors);
            this.gbInfo.Controls.Add(this.lbTickets);
            this.gbInfo.Controls.Add(this.lbVisitorsTitle);
            this.gbInfo.Controls.Add(this.lbTicketsTitle);
            this.gbInfo.ForeColor = System.Drawing.SystemColors.Menu;
            this.gbInfo.Location = new System.Drawing.Point(82, 400);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(616, 229);
            this.gbInfo.TabIndex = 6;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // lbWorstSeller
            // 
            this.lbWorstSeller.AutoSize = true;
            this.lbWorstSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbWorstSeller.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbWorstSeller.Location = new System.Drawing.Point(278, 127);
            this.lbWorstSeller.Name = "lbWorstSeller";
            this.lbWorstSeller.Size = new System.Drawing.Size(53, 20);
            this.lbWorstSeller.TabIndex = 18;
            this.lbWorstSeller.Text = "label5";
            this.lbWorstSeller.Visible = false;
            // 
            // lbWorstSellerTitle
            // 
            this.lbWorstSellerTitle.AutoSize = true;
            this.lbWorstSellerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbWorstSellerTitle.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbWorstSellerTitle.Location = new System.Drawing.Point(23, 127);
            this.lbWorstSellerTitle.Name = "lbWorstSellerTitle";
            this.lbWorstSellerTitle.Size = new System.Drawing.Size(170, 20);
            this.lbWorstSellerTitle.TabIndex = 17;
            this.lbWorstSellerTitle.Text = "Least selling product:";
            this.lbWorstSellerTitle.Visible = false;
            // 
            // lbCampAmount
            // 
            this.lbCampAmount.AutoSize = true;
            this.lbCampAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbCampAmount.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbCampAmount.Location = new System.Drawing.Point(278, 44);
            this.lbCampAmount.Name = "lbCampAmount";
            this.lbCampAmount.Size = new System.Drawing.Size(53, 20);
            this.lbCampAmount.TabIndex = 16;
            this.lbCampAmount.Text = "label1";
            this.lbCampAmount.Visible = false;
            // 
            // lbCampAmountTitle
            // 
            this.lbCampAmountTitle.AutoSize = true;
            this.lbCampAmountTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbCampAmountTitle.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbCampAmountTitle.Location = new System.Drawing.Point(24, 44);
            this.lbCampAmountTitle.Name = "lbCampAmountTitle";
            this.lbCampAmountTitle.Size = new System.Drawing.Size(196, 20);
            this.lbCampAmountTitle.TabIndex = 15;
            this.lbCampAmountTitle.Text = "Number of spots booked:";
            this.lbCampAmountTitle.Visible = false;
            // 
            // lbPopularShop
            // 
            this.lbPopularShop.AutoSize = true;
            this.lbPopularShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPopularShop.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbPopularShop.Location = new System.Drawing.Point(278, 44);
            this.lbPopularShop.Name = "lbPopularShop";
            this.lbPopularShop.Size = new System.Drawing.Size(53, 20);
            this.lbPopularShop.TabIndex = 14;
            this.lbPopularShop.Text = "label1";
            this.lbPopularShop.Visible = false;
            // 
            // lbPopularShopTitle
            // 
            this.lbPopularShopTitle.AutoSize = true;
            this.lbPopularShopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPopularShopTitle.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbPopularShopTitle.Location = new System.Drawing.Point(23, 44);
            this.lbPopularShopTitle.Name = "lbPopularShopTitle";
            this.lbPopularShopTitle.Size = new System.Drawing.Size(152, 20);
            this.lbPopularShopTitle.TabIndex = 13;
            this.lbPopularShopTitle.Text = "Most popular shop:";
            this.lbPopularShopTitle.Visible = false;
            // 
            // lbBestSeller
            // 
            this.lbBestSeller.AutoSize = true;
            this.lbBestSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbBestSeller.Location = new System.Drawing.Point(278, 81);
            this.lbBestSeller.Name = "lbBestSeller";
            this.lbBestSeller.Size = new System.Drawing.Size(53, 20);
            this.lbBestSeller.TabIndex = 12;
            this.lbBestSeller.Text = "label1";
            this.lbBestSeller.Visible = false;
            // 
            // lbBestSellerTitle
            // 
            this.lbBestSellerTitle.AutoSize = true;
            this.lbBestSellerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbBestSellerTitle.Location = new System.Drawing.Point(23, 81);
            this.lbBestSellerTitle.Name = "lbBestSellerTitle";
            this.lbBestSellerTitle.Size = new System.Drawing.Size(163, 20);
            this.lbBestSellerTitle.TabIndex = 11;
            this.lbBestSellerTitle.Text = "Best selling product:";
            this.lbBestSellerTitle.Visible = false;
            // 
            // lbEarned
            // 
            this.lbEarned.AutoSize = true;
            this.lbEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbEarned.Location = new System.Drawing.Point(278, 44);
            this.lbEarned.Name = "lbEarned";
            this.lbEarned.Size = new System.Drawing.Size(53, 20);
            this.lbEarned.TabIndex = 10;
            this.lbEarned.Text = "label1";
            this.lbEarned.Visible = false;
            // 
            // lbEarnedTitle
            // 
            this.lbEarnedTitle.AutoSize = true;
            this.lbEarnedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbEarnedTitle.Location = new System.Drawing.Point(23, 44);
            this.lbEarnedTitle.Name = "lbEarnedTitle";
            this.lbEarnedTitle.Size = new System.Drawing.Size(96, 20);
            this.lbEarnedTitle.TabIndex = 9;
            this.lbEarnedTitle.Text = "Total sales:";
            this.lbEarnedTitle.Visible = false;
            // 
            // lbCheckedOut
            // 
            this.lbCheckedOut.AutoSize = true;
            this.lbCheckedOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbCheckedOut.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbCheckedOut.Location = new System.Drawing.Point(278, 166);
            this.lbCheckedOut.Name = "lbCheckedOut";
            this.lbCheckedOut.Size = new System.Drawing.Size(53, 20);
            this.lbCheckedOut.TabIndex = 8;
            this.lbCheckedOut.Text = "label6";
            this.lbCheckedOut.Visible = false;
            // 
            // lbPending
            // 
            this.lbPending.AutoSize = true;
            this.lbPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPending.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbPending.Location = new System.Drawing.Point(278, 127);
            this.lbPending.Name = "lbPending";
            this.lbPending.Size = new System.Drawing.Size(53, 20);
            this.lbPending.TabIndex = 7;
            this.lbPending.Text = "label5";
            this.lbPending.Visible = false;
            // 
            // lbCheckedOutTitle
            // 
            this.lbCheckedOutTitle.AutoSize = true;
            this.lbCheckedOutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbCheckedOutTitle.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbCheckedOutTitle.Location = new System.Drawing.Point(23, 166);
            this.lbCheckedOutTitle.Name = "lbCheckedOutTitle";
            this.lbCheckedOutTitle.Size = new System.Drawing.Size(205, 20);
            this.lbCheckedOutTitle.TabIndex = 6;
            this.lbCheckedOutTitle.Text = "Total visitors checked out:";
            // 
            // lbPendingTitle
            // 
            this.lbPendingTitle.AutoSize = true;
            this.lbPendingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbPendingTitle.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbPendingTitle.Location = new System.Drawing.Point(23, 127);
            this.lbPendingTitle.Name = "lbPendingTitle";
            this.lbPendingTitle.Size = new System.Drawing.Size(173, 20);
            this.lbPendingTitle.TabIndex = 5;
            this.lbPendingTitle.Text = "Total visitors pending:";
            // 
            // lbVisitors
            // 
            this.lbVisitors.AutoSize = true;
            this.lbVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbVisitors.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbVisitors.Location = new System.Drawing.Point(278, 81);
            this.lbVisitors.Name = "lbVisitors";
            this.lbVisitors.Size = new System.Drawing.Size(53, 20);
            this.lbVisitors.TabIndex = 4;
            this.lbVisitors.Text = "label5";
            this.lbVisitors.Visible = false;
            // 
            // lbTickets
            // 
            this.lbTickets.AutoSize = true;
            this.lbTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTickets.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbTickets.Location = new System.Drawing.Point(278, 44);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(53, 20);
            this.lbTickets.TabIndex = 3;
            this.lbTickets.Text = "label4";
            this.lbTickets.Visible = false;
            // 
            // lbVisitorsTitle
            // 
            this.lbVisitorsTitle.AutoSize = true;
            this.lbVisitorsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbVisitorsTitle.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbVisitorsTitle.Location = new System.Drawing.Point(23, 81);
            this.lbVisitorsTitle.Name = "lbVisitorsTitle";
            this.lbVisitorsTitle.Size = new System.Drawing.Size(183, 20);
            this.lbVisitorsTitle.TabIndex = 1;
            this.lbVisitorsTitle.Text = "Total visitors attending:\r\n";
            // 
            // lbTicketsTitle
            // 
            this.lbTicketsTitle.AutoSize = true;
            this.lbTicketsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTicketsTitle.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbTicketsTitle.Location = new System.Drawing.Point(23, 44);
            this.lbTicketsTitle.Name = "lbTicketsTitle";
            this.lbTicketsTitle.Size = new System.Drawing.Size(141, 20);
            this.lbTicketsTitle.TabIndex = 0;
            this.lbTicketsTitle.Text = "Total tickets sold:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 672);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.comboBox_Search);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.listView_Details);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Festival Management";
            this.groupBox1.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Details;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Fullname;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.ColumnHeader Camping;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.ComboBox comboBox_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCampInfo;
        private System.Windows.Forms.Button btnShopInfo;
        private System.Windows.Forms.Button btnSalesInfo;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lbVisitorsTitle;
        private System.Windows.Forms.Label lbTicketsTitle;
        private System.Windows.Forms.Label lbCheckedOut;
        private System.Windows.Forms.Label lbPending;
        private System.Windows.Forms.Label lbCheckedOutTitle;
        private System.Windows.Forms.Label lbPendingTitle;
        private System.Windows.Forms.Label lbVisitors;
        private System.Windows.Forms.Label lbTickets;
        private System.Windows.Forms.Label lbEarnedTitle;
        private System.Windows.Forms.Label lbEarned;
        private System.Windows.Forms.Button btnVisitorInfo;
        private System.Windows.Forms.Label lbBestSeller;
        private System.Windows.Forms.Label lbBestSellerTitle;
        private System.Windows.Forms.Label lbPopularShop;
        private System.Windows.Forms.Label lbPopularShopTitle;
        private System.Windows.Forms.Label lbCampAmount;
        private System.Windows.Forms.Label lbCampAmountTitle;
        private System.Windows.Forms.Label lbWorstSeller;
        private System.Windows.Forms.Label lbWorstSellerTitle;
    }
}

