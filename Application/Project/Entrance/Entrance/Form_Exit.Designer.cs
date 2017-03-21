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
            this.button_Checkout = new System.Windows.Forms.Button();
            this.button_Entrance = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount_Return = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
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
            // label_Toreturn
            // 
            this.label_Toreturn.AutoSize = true;
            this.label_Toreturn.Location = new System.Drawing.Point(65, 268);
            this.label_Toreturn.Name = "label_Toreturn";
            this.label_Toreturn.Size = new System.Drawing.Size(76, 17);
            this.label_Toreturn.TabIndex = 6;
            this.label_Toreturn.Text = "To Return:";
            // 
            // button_Checkout
            // 
            this.button_Checkout.Location = new System.Drawing.Point(457, 116);
            this.button_Checkout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Checkout.Name = "button_Checkout";
            this.button_Checkout.Size = new System.Drawing.Size(210, 129);
            this.button_Checkout.TabIndex = 7;
            this.button_Checkout.Text = "Check-out";
            this.button_Checkout.UseVisualStyleBackColor = true;
            // 
            // button_Entrance
            // 
            this.button_Entrance.Location = new System.Drawing.Point(487, 18);
            this.button_Entrance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Entrance.Name = "button_Entrance";
            this.button_Entrance.Size = new System.Drawing.Size(148, 43);
            this.button_Entrance.TabIndex = 8;
            this.button_Entrance.Text = "Festival entrance";
            this.button_Entrance.UseVisualStyleBackColor = true;
            this.button_Entrance.Click += new System.EventHandler(this.button_Entrance_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name_Return,
            this.ID_Return,
            this.Price_Return,
            this.Amount_Return});
            this.listView1.Location = new System.Drawing.Point(68, 67);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(331, 178);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.button1.Location = new System.Drawing.Point(68, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Purchase item";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_Entrance);
            this.Controls.Add(this.button_Checkout);
            this.Controls.Add(this.label_Toreturn);
            this.Controls.Add(this.label_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Exit";
            this.Text = "Form_Exit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Toreturn;
        private System.Windows.Forms.Button button_Checkout;
        private System.Windows.Forms.Button button_Entrance;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name_Return;
        private System.Windows.Forms.ColumnHeader ID_Return;
        private System.Windows.Forms.ColumnHeader Price_Return;
        private System.Windows.Forms.ColumnHeader Amount_Return;
        private System.Windows.Forms.Button button1;
    }
}