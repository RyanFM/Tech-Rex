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
            this.label_Toreturn = new System.Windows.Forms.Label();
            this.listView_main = new System.Windows.Forms.ListView();
            this.Name_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label_CS = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_SS = new System.Windows.Forms.Label();
            this.label_SystemStatus = new System.Windows.Forms.Label();
            this.label_databasestatus = new System.Windows.Forms.Label();
            this.label_DB = new System.Windows.Forms.Label();
            this.label_RFIDnr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(26, 23);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(183, 37);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Festival Exit";
            // 
            // label_Toreturn
            // 
            this.label_Toreturn.AutoSize = true;
            this.label_Toreturn.Location = new System.Drawing.Point(72, 345);
            this.label_Toreturn.Name = "label_Toreturn";
            this.label_Toreturn.Size = new System.Drawing.Size(84, 20);
            this.label_Toreturn.TabIndex = 6;
            this.label_Toreturn.Text = "To Return:";
            // 
            // listView_main
            // 
            this.listView_main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_Return,
            this.ID_Return,
            this.Price_Return,
            this.Amount_Return});
            this.listView_main.FullRowSelect = true;
            this.listView_main.GridLines = true;
            this.listView_main.Location = new System.Drawing.Point(76, 83);
            this.listView_main.MultiSelect = false;
            this.listView_main.Name = "listView_main";
            this.listView_main.Size = new System.Drawing.Size(372, 256);
            this.listView_main.TabIndex = 9;
            this.listView_main.UseCompatibleStateImageBehavior = false;
            this.listView_main.View = System.Windows.Forms.View.Details;
            // 
            // Name_Return
            // 
            this.Name_Return.Text = "Name";
            // 
            // ID_Return
            // 
            this.ID_Return.Text = "ID";
            // 
            // Price_Return
            // 
            this.Price_Return.Text = "Price";
            // 
            // Amount_Return
            // 
            this.Amount_Return.Text = "Amount";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "Purchase item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_CS
            // 
            this.label_CS.AutoSize = true;
            this.label_CS.Location = new System.Drawing.Point(508, 143);
            this.label_CS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CS.Name = "label_CS";
            this.label_CS.Size = new System.Drawing.Size(114, 20);
            this.label_CS.TabIndex = 14;
            this.label_CS.Text = "Current status:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(630, 143);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(19, 20);
            this.label_status.TabIndex = 15;
            this.label_status.Text = "--";
            // 
            // label_SS
            // 
            this.label_SS.AutoSize = true;
            this.label_SS.Location = new System.Drawing.Point(508, 417);
            this.label_SS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SS.Name = "label_SS";
            this.label_SS.Size = new System.Drawing.Size(100, 20);
            this.label_SS.TabIndex = 16;
            this.label_SS.Text = "RFID status:";
            // 
            // label_SystemStatus
            // 
            this.label_SystemStatus.AutoSize = true;
            this.label_SystemStatus.Location = new System.Drawing.Point(630, 417);
            this.label_SystemStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SystemStatus.Name = "label_SystemStatus";
            this.label_SystemStatus.Size = new System.Drawing.Size(19, 20);
            this.label_SystemStatus.TabIndex = 17;
            this.label_SystemStatus.Text = "--";
            // 
            // label_databasestatus
            // 
            this.label_databasestatus.AutoSize = true;
            this.label_databasestatus.Location = new System.Drawing.Point(666, 458);
            this.label_databasestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_databasestatus.Name = "label_databasestatus";
            this.label_databasestatus.Size = new System.Drawing.Size(19, 20);
            this.label_databasestatus.TabIndex = 18;
            this.label_databasestatus.Text = "--";
            // 
            // label_DB
            // 
            this.label_DB.AutoSize = true;
            this.label_DB.Location = new System.Drawing.Point(508, 458);
            this.label_DB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DB.Name = "label_DB";
            this.label_DB.Size = new System.Drawing.Size(131, 20);
            this.label_DB.TabIndex = 19;
            this.label_DB.Text = "Database status:";
            // 
            // label_RFIDnr
            // 
            this.label_RFIDnr.AutoSize = true;
            this.label_RFIDnr.Location = new System.Drawing.Point(508, 83);
            this.label_RFIDnr.Name = "label_RFIDnr";
            this.label_RFIDnr.Size = new System.Drawing.Size(110, 20);
            this.label_RFIDnr.TabIndex = 20;
            this.label_RFIDnr.Text = "RFID number:";
            // 
            // Form_Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 606);
            this.Controls.Add(this.label_RFIDnr);
            this.Controls.Add(this.label_DB);
            this.Controls.Add(this.label_databasestatus);
            this.Controls.Add(this.label_SystemStatus);
            this.Controls.Add(this.label_SS);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_CS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView_main);
            this.Controls.Add(this.label_Toreturn);
            this.Controls.Add(this.label_Title);
            this.Name = "Form_Exit";
            this.Text = "Festival Exit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Exit_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Toreturn;
        private System.Windows.Forms.ListView listView_main;
        private System.Windows.Forms.ColumnHeader Name_Return;
        private System.Windows.Forms.ColumnHeader ID_Return;
        private System.Windows.Forms.ColumnHeader Price_Return;
        private System.Windows.Forms.ColumnHeader Amount_Return;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_CS;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_SS;
        private System.Windows.Forms.Label label_SystemStatus;
        private System.Windows.Forms.Label label_databasestatus;
        private System.Windows.Forms.Label label_DB;
        private System.Windows.Forms.Label label_RFIDnr;
    }
}