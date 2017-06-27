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
            this.DaysRented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbRent = new System.Windows.Forms.Label();
            this.gbRent = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbRent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.SystemColors.Menu;
            this.label_Title.Location = new System.Drawing.Point(20, 11);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(157, 31);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Festival Exit";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbMoney.Location = new System.Drawing.Point(24, 306);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(183, 29);
            this.lbMoney.TabIndex = 6;
            this.lbMoney.Text = "Visitor receives:";
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
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReturn.Location = new System.Drawing.Point(27, 348);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(332, 50);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return product";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTotal.Location = new System.Drawing.Point(211, 306);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(71, 29);
            this.lbTotal.TabIndex = 21;
            this.lbTotal.Text = "€0.00";
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
            this.gbRent.BackColor = System.Drawing.SystemColors.ControlLight;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.label_Title);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 53);
            this.panel1.TabIndex = 24;
            // 
            // Form_Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbRent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Exit";
            this.Text = "z";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Exit_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Exit_FormClosed);
            this.gbRent.ResumeLayout(false);
            this.gbRent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.ListView listView_main;
        private System.Windows.Forms.ColumnHeader Name_Return;
        private System.Windows.Forms.ColumnHeader Price_Return;
        private System.Windows.Forms.ColumnHeader Amount_Return;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ColumnHeader DaysRented;
        private System.Windows.Forms.ColumnHeader clmSubtotal;
        private System.Windows.Forms.Label lbRent;
        private System.Windows.Forms.GroupBox gbRent;
        private System.Windows.Forms.Panel panel1;
    }
}