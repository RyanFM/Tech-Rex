namespace Purchases
{
    partial class Return
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
            this.groupBox_Return = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbMoney = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.listView_Return = new System.Windows.Forms.ListView();
            this.Name_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deposit_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Days = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Finish = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbShop = new System.Windows.Forms.ComboBox();
            this.Sub_total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_Return.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Return
            // 
            this.groupBox_Return.Controls.Add(this.lbTotal);
            this.groupBox_Return.Controls.Add(this.lbMoney);
            this.groupBox_Return.Controls.Add(this.button_Return);
            this.groupBox_Return.Controls.Add(this.listView_Return);
            this.groupBox_Return.Location = new System.Drawing.Point(30, 86);
            this.groupBox_Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Return.Name = "groupBox_Return";
            this.groupBox_Return.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Return.Size = new System.Drawing.Size(655, 313);
            this.groupBox_Return.TabIndex = 4;
            this.groupBox_Return.TabStop = false;
            this.groupBox_Return.Text = "RETURN";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(109, 231);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(44, 17);
            this.lbTotal.TabIndex = 19;
            this.lbTotal.Text = "€0.00";
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(32, 231);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(71, 17);
            this.lbMoney.TabIndex = 16;
            this.lbMoney.Text = "To return:";
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(258, 231);
            this.button_Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(112, 38);
            this.button_Return.TabIndex = 14;
            this.button_Return.Text = "RETURN";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // listView_Return
            // 
            this.listView_Return.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_Return,
            this.Deposit_Return,
            this.Amount,
            this.Days,
            this.Sub_total});
            this.listView_Return.Location = new System.Drawing.Point(23, 35);
            this.listView_Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Return.Name = "listView_Return";
            this.listView_Return.Size = new System.Drawing.Size(594, 157);
            this.listView_Return.TabIndex = 0;
            this.listView_Return.UseCompatibleStateImageBehavior = false;
            this.listView_Return.View = System.Windows.Forms.View.Details;
            // 
            // Name_Return
            // 
            this.Name_Return.Text = "Name";
            this.Name_Return.Width = 176;
            // 
            // Deposit_Return
            // 
            this.Deposit_Return.Text = "Deposit";
            this.Deposit_Return.Width = 74;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 68;
            // 
            // Days
            // 
            this.Days.Text = "Days-Rented";
            this.Days.Width = 100;
            // 
            // button_Finish
            // 
            this.button_Finish.Location = new System.Drawing.Point(592, 11);
            this.button_Finish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Finish.Name = "button_Finish";
            this.button_Finish.Size = new System.Drawing.Size(112, 38);
            this.button_Finish.TabIndex = 18;
            this.button_Finish.Text = "Go back";
            this.button_Finish.UseVisualStyleBackColor = true;
            this.button_Finish.Click += new System.EventHandler(this.button_Finish_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Shop ID:";
            // 
            // cbShop
            // 
            this.cbShop.FormattingEnabled = true;
            this.cbShop.Location = new System.Drawing.Point(118, 19);
            this.cbShop.Name = "cbShop";
            this.cbShop.Size = new System.Drawing.Size(54, 24);
            this.cbShop.TabIndex = 22;
            // 
            // Sub_total
            // 
            this.Sub_total.Text = "Subtotal";
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 505);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbShop);
            this.Controls.Add(this.groupBox_Return);
            this.Controls.Add(this.button_Finish);
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.groupBox_Return.ResumeLayout(false);
            this.groupBox_Return.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Return;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button button_Finish;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.ListView listView_Return;
        private System.Windows.Forms.ColumnHeader Name_Return;
        private System.Windows.Forms.ColumnHeader Deposit_Return;
        private System.Windows.Forms.ColumnHeader Days;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbShop;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Sub_total;
    }
}