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
            this.label_Ticket_type = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_SystemStatus = new System.Windows.Forms.Label();
            this.label_databasestatus = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlScan = new System.Windows.Forms.Panel();
            this.lbScan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlScan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.SystemColors.Menu;
            this.label_Title.Location = new System.Drawing.Point(17, 12);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(218, 31);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Festival Entrance";
            // 
            // label_Ticket_type
            // 
            this.label_Ticket_type.AutoSize = true;
            this.label_Ticket_type.Location = new System.Drawing.Point(108, 198);
            this.label_Ticket_type.Name = "label_Ticket_type";
            this.label_Ticket_type.Size = new System.Drawing.Size(0, 17);
            this.label_Ticket_type.TabIndex = 5;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.SystemColors.Control;
            this.label_status.Enabled = false;
            this.label_status.Location = new System.Drawing.Point(176, 272);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(18, 17);
            this.label_status.TabIndex = 14;
            this.label_status.Text = "--";
            this.label_status.Visible = false;
            // 
            // label_SystemStatus
            // 
            this.label_SystemStatus.AutoSize = true;
            this.label_SystemStatus.Location = new System.Drawing.Point(617, 348);
            this.label_SystemStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SystemStatus.Name = "label_SystemStatus";
            this.label_SystemStatus.Size = new System.Drawing.Size(18, 17);
            this.label_SystemStatus.TabIndex = 16;
            this.label_SystemStatus.Text = "--";
            // 
            // label_databasestatus
            // 
            this.label_databasestatus.AutoSize = true;
            this.label_databasestatus.Location = new System.Drawing.Point(563, 395);
            this.label_databasestatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_databasestatus.Name = "label_databasestatus";
            this.label_databasestatus.Size = new System.Drawing.Size(18, 17);
            this.label_databasestatus.TabIndex = 19;
            this.label_databasestatus.Text = "--";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_ID.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label_ID.Location = new System.Drawing.Point(21, 38);
            this.label_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(246, 29);
            this.label_ID.TabIndex = 20;
            this.label_ID.Text = "Enter ticket number:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(275, 45);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ID.MaxLength = 6;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(86, 22);
            this.textBox_ID.TabIndex = 21;
            this.textBox_ID.TextChanged += new System.EventHandler(this.textBox_ID_TextChanged);
            this.textBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label_Title);
            this.panel1.Location = new System.Drawing.Point(-5, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 52);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.pnlScan);
            this.panel2.Controls.Add(this.textBox_ID);
            this.panel2.Controls.Add(this.label_ID);
            this.panel2.Controls.Add(this.label_status);
            this.panel2.Location = new System.Drawing.Point(36, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 265);
            this.panel2.TabIndex = 23;
            // 
            // pnlScan
            // 
            this.pnlScan.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlScan.Controls.Add(this.lbScan);
            this.pnlScan.Location = new System.Drawing.Point(49, 134);
            this.pnlScan.Name = "pnlScan";
            this.pnlScan.Size = new System.Drawing.Size(292, 50);
            this.pnlScan.TabIndex = 23;
            this.pnlScan.Visible = false;
            // 
            // lbScan
            // 
            this.lbScan.AutoSize = true;
            this.lbScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbScan.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbScan.Location = new System.Drawing.Point(52, 9);
            this.lbScan.Name = "lbScan";
            this.lbScan.Size = new System.Drawing.Size(178, 31);
            this.lbScan.TabIndex = 22;
            this.lbScan.Text = "Scan new tag";
            this.lbScan.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(449, 389);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_databasestatus);
            this.Controls.Add(this.label_SystemStatus);
            this.Controls.Add(this.label_Ticket_type);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Festival Entrance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlScan.ResumeLayout(false);
            this.pnlScan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Ticket_type;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_SystemStatus;
        private System.Windows.Forms.Label label_databasestatus;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlScan;
        private System.Windows.Forms.Label lbScan;
    }
}

