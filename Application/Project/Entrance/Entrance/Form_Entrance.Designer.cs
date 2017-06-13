namespace Entrance
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Ticket = new System.Windows.Forms.Label();
            this.label_Ticket_type = new System.Windows.Forms.Label();
            this.label_CS = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_SS = new System.Windows.Forms.Label();
            this.label_SystemStatus = new System.Windows.Forms.Label();
            this.label_RFIDnr = new System.Windows.Forms.Label();
            this.label_DB = new System.Windows.Forms.Label();
            this.label_databasestatus = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(67, 26);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(218, 31);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Festival Entrance";
            // 
            // label_Ticket
            // 
            this.label_Ticket.AutoSize = true;
            this.label_Ticket.Location = new System.Drawing.Point(69, 132);
            this.label_Ticket.Name = "label_Ticket";
            this.label_Ticket.Size = new System.Drawing.Size(67, 17);
            this.label_Ticket.TabIndex = 4;
            this.label_Ticket.Text = "Ticket ID:";
            // 
            // label_Ticket_type
            // 
            this.label_Ticket_type.AutoSize = true;
            this.label_Ticket_type.Location = new System.Drawing.Point(108, 198);
            this.label_Ticket_type.Name = "label_Ticket_type";
            this.label_Ticket_type.Size = new System.Drawing.Size(0, 17);
            this.label_Ticket_type.TabIndex = 5;
            // 
            // label_CS
            // 
            this.label_CS.AutoSize = true;
            this.label_CS.Location = new System.Drawing.Point(69, 182);
            this.label_CS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CS.Name = "label_CS";
            this.label_CS.Size = new System.Drawing.Size(101, 17);
            this.label_CS.TabIndex = 13;
            this.label_CS.Text = "Current status:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(177, 182);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(18, 17);
            this.label_status.TabIndex = 14;
            this.label_status.Text = "--";
            // 
            // label_SS
            // 
            this.label_SS.AutoSize = true;
            this.label_SS.Location = new System.Drawing.Point(69, 368);
            this.label_SS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SS.Name = "label_SS";
            this.label_SS.Size = new System.Drawing.Size(85, 17);
            this.label_SS.TabIndex = 15;
            this.label_SS.Text = "RFID status:";
            // 
            // label_SystemStatus
            // 
            this.label_SystemStatus.AutoSize = true;
            this.label_SystemStatus.Location = new System.Drawing.Point(177, 368);
            this.label_SystemStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SystemStatus.Name = "label_SystemStatus";
            this.label_SystemStatus.Size = new System.Drawing.Size(18, 17);
            this.label_SystemStatus.TabIndex = 16;
            this.label_SystemStatus.Text = "--";
            // 
            // label_RFIDnr
            // 
            this.label_RFIDnr.AutoSize = true;
            this.label_RFIDnr.Location = new System.Drawing.Point(69, 105);
            this.label_RFIDnr.Name = "label_RFIDnr";
            this.label_RFIDnr.Size = new System.Drawing.Size(95, 17);
            this.label_RFIDnr.TabIndex = 17;
            this.label_RFIDnr.Text = "RFID number:";
            // 
            // label_DB
            // 
            this.label_DB.AutoSize = true;
            this.label_DB.Location = new System.Drawing.Point(69, 391);
            this.label_DB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DB.Name = "label_DB";
            this.label_DB.Size = new System.Drawing.Size(115, 17);
            this.label_DB.TabIndex = 18;
            this.label_DB.Text = "Database status:";
            // 
            // label_databasestatus
            // 
            this.label_databasestatus.AutoSize = true;
            this.label_databasestatus.Location = new System.Drawing.Point(193, 391);
            this.label_databasestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_databasestatus.Name = "label_databasestatus";
            this.label_databasestatus.Size = new System.Drawing.Size(18, 17);
            this.label_databasestatus.TabIndex = 19;
            this.label_databasestatus.Text = "--";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(69, 76);
            this.label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(25, 17);
            this.label_ID.TabIndex = 20;
            this.label_ID.Text = "ID:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(107, 74);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(132, 22);
            this.textBox_ID.TabIndex = 21;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 414);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_databasestatus);
            this.Controls.Add(this.label_DB);
            this.Controls.Add(this.label_RFIDnr);
            this.Controls.Add(this.label_SystemStatus);
            this.Controls.Add(this.label_SS);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_CS);
            this.Controls.Add(this.label_Ticket_type);
            this.Controls.Add(this.label_Ticket);
            this.Controls.Add(this.label_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Festival Entrance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Ticket;
        private System.Windows.Forms.Label label_Ticket_type;
        private System.Windows.Forms.Label label_CS;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_SS;
        private System.Windows.Forms.Label label_SystemStatus;
        private System.Windows.Forms.Label label_RFIDnr;
        private System.Windows.Forms.Label label_DB;
        private System.Windows.Forms.Label label_databasestatus;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_ID;
    }
}

