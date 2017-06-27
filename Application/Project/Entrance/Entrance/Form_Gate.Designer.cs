namespace Entrance
{
    partial class Form_Gate
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
            this.lbScan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlScan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlScan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbScan
            // 
            this.lbScan.AutoSize = true;
            this.lbScan.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScan.Location = new System.Drawing.Point(59, 170);
            this.lbScan.Name = "lbScan";
            this.lbScan.Size = new System.Drawing.Size(435, 46);
            this.lbScan.TabIndex = 0;
            this.lbScan.Text = "Scan your tag to enter\r\n";
            this.lbScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlScan
            // 
            this.pnlScan.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnlScan.Controls.Add(this.lbScan);
            this.pnlScan.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlScan.Location = new System.Drawing.Point(44, 93);
            this.pnlScan.Name = "pnlScan";
            this.pnlScan.Size = new System.Drawing.Size(556, 400);
            this.pnlScan.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 55);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Check in to festival";
            // 
            // Form_Gate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(641, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlScan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Gate";
            this.Text = "Form_Gate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Gate_FormClosed);
            this.pnlScan.ResumeLayout(false);
            this.pnlScan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbScan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlScan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}