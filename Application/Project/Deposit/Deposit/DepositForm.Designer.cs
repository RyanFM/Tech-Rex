namespace Deposit
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.button_Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAdded = new System.Windows.Forms.Label();
            this.pnlAdded = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlAdded.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.button_Add.FlatAppearance.BorderSize = 4;
            this.button_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_Add.ForeColor = System.Drawing.SystemColors.Menu;
            this.button_Add.Location = new System.Drawing.Point(147, 21);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(162, 70);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 55);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert Paypal deposit info";
            // 
            // lbAdded
            // 
            this.lbAdded.AutoSize = true;
            this.lbAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbAdded.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbAdded.Location = new System.Drawing.Point(29, 13);
            this.lbAdded.Name = "lbAdded";
            this.lbAdded.Size = new System.Drawing.Size(239, 31);
            this.lbAdded.TabIndex = 12;
            this.lbAdded.Text = "Information added ";
            this.lbAdded.Visible = false;
            // 
            // pnlAdded
            // 
            this.pnlAdded.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlAdded.Controls.Add(this.lbAdded);
            this.pnlAdded.Location = new System.Drawing.Point(84, 121);
            this.pnlAdded.Name = "pnlAdded";
            this.pnlAdded.Size = new System.Drawing.Size(295, 56);
            this.pnlAdded.TabIndex = 13;
            this.pnlAdded.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.button_Add);
            this.panel2.Controls.Add(this.pnlAdded);
            this.panel2.Location = new System.Drawing.Point(29, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 211);
            this.panel2.TabIndex = 14;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 307);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main_Form";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAdded.ResumeLayout(false);
            this.pnlAdded.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAdded;
        private System.Windows.Forms.Panel pnlAdded;
        private System.Windows.Forms.Panel panel2;
    }
}

