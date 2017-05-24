﻿namespace BackEnd
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
            this.btnStandsInfo = new System.Windows.Forms.Button();
            this.btnSalesInfo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2.SuspendLayout();
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
            this.listView_Details.Location = new System.Drawing.Point(60, 49);
            this.listView_Details.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView_Details.Name = "listView_Details";
            this.listView_Details.Size = new System.Drawing.Size(725, 286);
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
            this.label_Search.Location = new System.Drawing.Point(56, 365);
            this.label_Search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(86, 20);
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
            this.comboBox_Search.Location = new System.Drawing.Point(152, 365);
            this.comboBox_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_Search.Name = "comboBox_Search";
            this.comboBox_Search.Size = new System.Drawing.Size(142, 28);
            this.comboBox_Search.TabIndex = 2;
            this.comboBox_Search.SelectedIndexChanged += new System.EventHandler(this.comboBox_Search_SelectedIndexChanged);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(345, 365);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(134, 30);
            this.textBox_Search.TabIndex = 3;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnVisitorInfo);
            this.groupBox1.Controls.Add(this.btnCampInfo);
            this.groupBox1.Controls.Add(this.btnStandsInfo);
            this.groupBox1.Controls.Add(this.btnSalesInfo);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(831, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(202, 446);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            // 
            // btnVisitorInfo
            // 
            this.btnVisitorInfo.BackColor = System.Drawing.Color.Green;
            this.btnVisitorInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVisitorInfo.Location = new System.Drawing.Point(19, 48);
            this.btnVisitorInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVisitorInfo.Name = "btnVisitorInfo";
            this.btnVisitorInfo.Size = new System.Drawing.Size(169, 46);
            this.btnVisitorInfo.TabIndex = 4;
            this.btnVisitorInfo.Text = "Visitor Information";
            this.btnVisitorInfo.UseVisualStyleBackColor = false;
            this.btnVisitorInfo.Click += new System.EventHandler(this.btnVisitorInfo_Click);
            // 
            // btnCampInfo
            // 
            this.btnCampInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCampInfo.Location = new System.Drawing.Point(19, 365);
            this.btnCampInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCampInfo.Name = "btnCampInfo";
            this.btnCampInfo.Size = new System.Drawing.Size(169, 42);
            this.btnCampInfo.TabIndex = 3;
            this.btnCampInfo.Text = "Camping Information";
            this.btnCampInfo.UseVisualStyleBackColor = false;
            // 
            // btnStandsInfo
            // 
            this.btnStandsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStandsInfo.Location = new System.Drawing.Point(19, 256);
            this.btnStandsInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStandsInfo.Name = "btnStandsInfo";
            this.btnStandsInfo.Size = new System.Drawing.Size(169, 42);
            this.btnStandsInfo.TabIndex = 2;
            this.btnStandsInfo.Text = "Stands Information";
            this.btnStandsInfo.UseVisualStyleBackColor = false;
            // 
            // btnSalesInfo
            // 
            this.btnSalesInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSalesInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalesInfo.Location = new System.Drawing.Point(19, 151);
            this.btnSalesInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalesInfo.Name = "btnSalesInfo";
            this.btnSalesInfo.Size = new System.Drawing.Size(169, 42);
            this.btnSalesInfo.TabIndex = 1;
            this.btnSalesInfo.Text = "Sales Information";
            this.btnSalesInfo.UseVisualStyleBackColor = false;
            this.btnSalesInfo.Click += new System.EventHandler(this.btnSalesInfo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.lbEarned);
            this.groupBox2.Controls.Add(this.lbEarnedTitle);
            this.groupBox2.Controls.Add(this.lbCheckedOut);
            this.groupBox2.Controls.Add(this.lbPending);
            this.groupBox2.Controls.Add(this.lbCheckedOutTitle);
            this.groupBox2.Controls.Add(this.lbPendingTitle);
            this.groupBox2.Controls.Add(this.lbVisitors);
            this.groupBox2.Controls.Add(this.lbTickets);
            this.groupBox2.Controls.Add(this.lbVisitorsTitle);
            this.groupBox2.Controls.Add(this.lbTicketsTitle);
            this.groupBox2.Location = new System.Drawing.Point(60, 492);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(627, 286);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // lbEarned
            // 
            this.lbEarned.AutoSize = true;
            this.lbEarned.Location = new System.Drawing.Point(246, 55);
            this.lbEarned.Name = "lbEarned";
            this.lbEarned.Size = new System.Drawing.Size(51, 20);
            this.lbEarned.TabIndex = 10;
            this.lbEarned.Text = "label1";
            this.lbEarned.Visible = false;
            // 
            // lbEarnedTitle
            // 
            this.lbEarnedTitle.AutoSize = true;
            this.lbEarnedTitle.Location = new System.Drawing.Point(26, 55);
            this.lbEarnedTitle.Name = "lbEarnedTitle";
            this.lbEarnedTitle.Size = new System.Drawing.Size(160, 20);
            this.lbEarnedTitle.TabIndex = 9;
            this.lbEarnedTitle.Text = "Total amount earned:";
            this.lbEarnedTitle.Visible = false;
            // 
            // lbCheckedOut
            // 
            this.lbCheckedOut.AutoSize = true;
            this.lbCheckedOut.Location = new System.Drawing.Point(243, 208);
            this.lbCheckedOut.Name = "lbCheckedOut";
            this.lbCheckedOut.Size = new System.Drawing.Size(51, 20);
            this.lbCheckedOut.TabIndex = 8;
            this.lbCheckedOut.Text = "label6";
            this.lbCheckedOut.Visible = false;
            // 
            // lbPending
            // 
            this.lbPending.AutoSize = true;
            this.lbPending.Location = new System.Drawing.Point(243, 159);
            this.lbPending.Name = "lbPending";
            this.lbPending.Size = new System.Drawing.Size(51, 20);
            this.lbPending.TabIndex = 7;
            this.lbPending.Text = "label5";
            this.lbPending.Visible = false;
            // 
            // lbCheckedOutTitle
            // 
            this.lbCheckedOutTitle.AutoSize = true;
            this.lbCheckedOutTitle.Location = new System.Drawing.Point(26, 208);
            this.lbCheckedOutTitle.Name = "lbCheckedOutTitle";
            this.lbCheckedOutTitle.Size = new System.Drawing.Size(191, 20);
            this.lbCheckedOutTitle.TabIndex = 6;
            this.lbCheckedOutTitle.Text = "Total visitors checked out:";
            // 
            // lbPendingTitle
            // 
            this.lbPendingTitle.AutoSize = true;
            this.lbPendingTitle.Location = new System.Drawing.Point(26, 159);
            this.lbPendingTitle.Name = "lbPendingTitle";
            this.lbPendingTitle.Size = new System.Drawing.Size(161, 20);
            this.lbPendingTitle.TabIndex = 5;
            this.lbPendingTitle.Text = "Total visitors pending:";
            // 
            // lbVisitors
            // 
            this.lbVisitors.AutoSize = true;
            this.lbVisitors.Location = new System.Drawing.Point(243, 101);
            this.lbVisitors.Name = "lbVisitors";
            this.lbVisitors.Size = new System.Drawing.Size(51, 20);
            this.lbVisitors.TabIndex = 4;
            this.lbVisitors.Text = "label5";
            this.lbVisitors.Visible = false;
            // 
            // lbTickets
            // 
            this.lbTickets.AutoSize = true;
            this.lbTickets.Location = new System.Drawing.Point(243, 55);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(51, 20);
            this.lbTickets.TabIndex = 3;
            this.lbTickets.Text = "label4";
            this.lbTickets.Visible = false;
            // 
            // lbVisitorsTitle
            // 
            this.lbVisitorsTitle.AutoSize = true;
            this.lbVisitorsTitle.Location = new System.Drawing.Point(26, 101);
            this.lbVisitorsTitle.Name = "lbVisitorsTitle";
            this.lbVisitorsTitle.Size = new System.Drawing.Size(171, 20);
            this.lbVisitorsTitle.TabIndex = 1;
            this.lbVisitorsTitle.Text = "Total visitors attending:\r\n";
            // 
            // lbTicketsTitle
            // 
            this.lbTicketsTitle.AutoSize = true;
            this.lbTicketsTitle.Location = new System.Drawing.Point(26, 55);
            this.lbTicketsTitle.Name = "lbTicketsTitle";
            this.lbTicketsTitle.Size = new System.Drawing.Size(131, 20);
            this.lbTicketsTitle.TabIndex = 0;
            this.lbTicketsTitle.Text = "Total tickets sold:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 840);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.comboBox_Search);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.listView_Details);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Festival Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Button btnStandsInfo;
        private System.Windows.Forms.Button btnSalesInfo;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}

