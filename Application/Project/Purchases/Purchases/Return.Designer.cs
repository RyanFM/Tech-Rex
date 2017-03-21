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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Finish = new System.Windows.Forms.Button();
            this.label_Total2 = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Button();
            this.listView_Return = new System.Windows.Forms.ListView();
            this.Name_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Deposit_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Days = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_Return.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Return
            // 
            this.groupBox_Return.Controls.Add(this.label1);
            this.groupBox_Return.Controls.Add(this.label_Total2);
            this.groupBox_Return.Controls.Add(this.button_Return);
            this.groupBox_Return.Controls.Add(this.listView_Return);
            this.groupBox_Return.Location = new System.Drawing.Point(34, 29);
            this.groupBox_Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Return.Name = "groupBox_Return";
            this.groupBox_Return.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Return.Size = new System.Drawing.Size(445, 313);
            this.groupBox_Return.TabIndex = 4;
            this.groupBox_Return.TabStop = false;
            this.groupBox_Return.Text = "RETURN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "$0.00";
            // 
            // button_Finish
            // 
            this.button_Finish.Location = new System.Drawing.Point(539, 11);
            this.button_Finish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Finish.Name = "button_Finish";
            this.button_Finish.Size = new System.Drawing.Size(112, 38);
            this.button_Finish.TabIndex = 18;
            this.button_Finish.Text = "Go back";
            this.button_Finish.UseVisualStyleBackColor = true;
            this.button_Finish.Click += new System.EventHandler(this.button_Finish_Click);
            // 
            // label_Total2
            // 
            this.label_Total2.AutoSize = true;
            this.label_Total2.Location = new System.Drawing.Point(32, 231);
            this.label_Total2.Name = "label_Total2";
            this.label_Total2.Size = new System.Drawing.Size(44, 17);
            this.label_Total2.TabIndex = 16;
            this.label_Total2.Text = "Total:";
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
            // 
            // listView_Return
            // 
            this.listView_Return.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_Return,
            this.ID_return,
            this.Deposit_Return,
            this.Days});
            this.listView_Return.Location = new System.Drawing.Point(23, 35);
            this.listView_Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Return.Name = "listView_Return";
            this.listView_Return.Size = new System.Drawing.Size(407, 157);
            this.listView_Return.TabIndex = 0;
            this.listView_Return.UseCompatibleStateImageBehavior = false;
            this.listView_Return.View = System.Windows.Forms.View.Details;
            // 
            // Name_Return
            // 
            this.Name_Return.Text = "Name";
            // 
            // ID_return
            // 
            this.ID_return.Text = "ID";
            // 
            // Deposit_Return
            // 
            this.Deposit_Return.Text = "Deposit";
            this.Deposit_Return.Width = 74;
            // 
            // Days
            // 
            this.Days.Text = "Days-Rented";
            this.Days.Width = 100;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 410);
            this.Controls.Add(this.groupBox_Return);
            this.Controls.Add(this.button_Finish);
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.groupBox_Return.ResumeLayout(false);
            this.groupBox_Return.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Finish;
        private System.Windows.Forms.Label label_Total2;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.ListView listView_Return;
        private System.Windows.Forms.ColumnHeader Name_Return;
        private System.Windows.Forms.ColumnHeader ID_return;
        private System.Windows.Forms.ColumnHeader Deposit_Return;
        private System.Windows.Forms.ColumnHeader Days;
    }
}