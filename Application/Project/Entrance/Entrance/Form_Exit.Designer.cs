namespace Entrance
{
    partial class Form_Exit
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
            this.label_Title = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.listView_main = new System.Windows.Forms.ListView();
            this.Name_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReturn = new System.Windows.Forms.Button();
            this.label_CS = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_SS = new System.Windows.Forms.Label();
            this.label_SystemStatus = new System.Windows.Forms.Label();
            this.label_databasestatus = new System.Windows.Forms.Label();
            this.label_DB = new System.Windows.Forms.Label();
            this.label_RFIDnr = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.DaysRented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbRent = new System.Windows.Forms.Label();
            this.gbRent = new System.Windows.Forms.GroupBox();
            this.gbRent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(23, 18);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(157, 31);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Festival Exit";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(24, 306);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(71, 17);
            this.lbMoney.TabIndex = 6;
            this.lbMoney.Text = "To return:";
            // 
            // listView_main
            // 
            this.listView_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_Return,
            this.Price_Return,
            this.Amount_Return,
            this.DaysRented,
            this.clmSubtotal});
            this.listView_main.FullRowSelect = true;
            this.listView_main.GridLines = true;
            this.listView_main.Location = new System.Drawing.Point(27, 80);
            this.listView_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_main.MultiSelect = false;
            this.listView_main.Name = "listView_main";
            this.listView_main.Size = new System.Drawing.Size(631, 206);
            this.listView_main.TabIndex = 9;
            this.listView_main.UseCompatibleStateImageBehavior = false;
            this.listView_main.View = System.Windows.Forms.View.Details;
            // 
            // Name_Return
            // 
            this.Name_Return.Text = "Name";
            this.Name_Return.Width = 100;
            // 
            // Price_Return
            // 
            this.Price_Return.Text = "Deposit";
            // 
            // Amount_Return
            // 
            this.Amount_Return.Text = "Amount";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(27, 348);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(332, 50);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return product";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_CS
            // 
            this.label_CS.AutoSize = true;
            this.label_CS.Location = new System.Drawing.Point(796, 116);
            this.label_CS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CS.Name = "label_CS";
            this.label_CS.Size = new System.Drawing.Size(101, 17);
            this.label_CS.TabIndex = 14;
            this.label_CS.Text = "Current status:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(904, 116);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(18, 17);
            this.label_status.TabIndex = 15;
            this.label_status.Text = "--";
            // 
            // label_SS
            // 
            this.label_SS.AutoSize = true;
            this.label_SS.Location = new System.Drawing.Point(796, 336);
            this.label_SS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SS.Name = "label_SS";
            this.label_SS.Size = new System.Drawing.Size(85, 17);
            this.label_SS.TabIndex = 16;
            this.label_SS.Text = "RFID status:";
            // 
            // label_SystemStatus
            // 
            this.label_SystemStatus.AutoSize = true;
            this.label_SystemStatus.Location = new System.Drawing.Point(904, 336);
            this.label_SystemStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SystemStatus.Name = "label_SystemStatus";
            this.label_SystemStatus.Size = new System.Drawing.Size(18, 17);
            this.label_SystemStatus.TabIndex = 17;
            this.label_SystemStatus.Text = "--";
            // 
            // label_databasestatus
            // 
            this.label_databasestatus.AutoSize = true;
            this.label_databasestatus.Location = new System.Drawing.Point(936, 368);
            this.label_databasestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_databasestatus.Name = "label_databasestatus";
            this.label_databasestatus.Size = new System.Drawing.Size(18, 17);
            this.label_databasestatus.TabIndex = 18;
            this.label_databasestatus.Text = "--";
            // 
            // label_DB
            // 
            this.label_DB.AutoSize = true;
            this.label_DB.Location = new System.Drawing.Point(796, 368);
            this.label_DB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DB.Name = "label_DB";
            this.label_DB.Size = new System.Drawing.Size(115, 17);
            this.label_DB.TabIndex = 19;
            this.label_DB.Text = "Database status:";
            // 
            // label_RFIDnr
            // 
            this.label_RFIDnr.AutoSize = true;
            this.label_RFIDnr.Location = new System.Drawing.Point(796, 68);
            this.label_RFIDnr.Name = "label_RFIDnr";
            this.label_RFIDnr.Size = new System.Drawing.Size(95, 17);
            this.label_RFIDnr.TabIndex = 20;
            this.label_RFIDnr.Text = "RFID number:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(106, 306);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(46, 17);
            this.lbTotal.TabIndex = 21;
            this.lbTotal.Text = "label1";
            // 
            // DaysRented
            // 
            this.DaysRented.Text = "Days Rented";
            this.DaysRented.Width = 68;
            // 
            // clmSubtotal
            // 
            this.clmSubtotal.Text = "Subtotal";
            this.clmSubtotal.Width = 70;
            // 
            // lbRent
            // 
            this.lbRent.AutoSize = true;
            this.lbRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbRent.Location = new System.Drawing.Point(27, 26);
            this.lbRent.Name = "lbRent";
            this.lbRent.Size = new System.Drawing.Size(255, 36);
            this.lbRent.TabIndex = 22;
            this.lbRent.Text = "Please Scan Tag";
            // 
            // gbRent
            // 
            this.gbRent.BackColor = System.Drawing.SystemColors.Control;
            this.gbRent.Controls.Add(this.lbRent);
            this.gbRent.Controls.Add(this.lbTotal);
            this.gbRent.Controls.Add(this.btnReturn);
            this.gbRent.Controls.Add(this.listView_main);
            this.gbRent.Controls.Add(this.lbMoney);
            this.gbRent.Location = new System.Drawing.Point(32, 90);
            this.gbRent.Name = "gbRent";
            this.gbRent.Size = new System.Drawing.Size(718, 429);
            this.gbRent.TabIndex = 23;
            this.gbRent.TabStop = false;
            // 
            // Form_Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 628);
            this.Controls.Add(this.gbRent);
            this.Controls.Add(this.label_RFIDnr);
            this.Controls.Add(this.label_DB);
            this.Controls.Add(this.label_databasestatus);
            this.Controls.Add(this.label_SystemStatus);
            this.Controls.Add(this.label_SS);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_CS);
            this.Controls.Add(this.label_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Exit";
            this.Text = "z";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Exit_FormClosing);
            this.gbRent.ResumeLayout(false);
            this.gbRent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.ListView listView_main;
        private System.Windows.Forms.ColumnHeader Name_Return;
        private System.Windows.Forms.ColumnHeader Price_Return;
        private System.Windows.Forms.ColumnHeader Amount_Return;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label_CS;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_SS;
        private System.Windows.Forms.Label label_SystemStatus;
        private System.Windows.Forms.Label label_databasestatus;
        private System.Windows.Forms.Label label_DB;
        private System.Windows.Forms.Label label_RFIDnr;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ColumnHeader DaysRented;
        private System.Windows.Forms.ColumnHeader clmSubtotal;
        private System.Windows.Forms.Label lbRent;
        private System.Windows.Forms.GroupBox gbRent;
    }
}