namespace Camping
{
    partial class Form_Entrance
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
            this.label_Sitenumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox_member = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(15, 19);
            this.label_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(194, 25);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Camping Entrance";
            // 
            // label_Sitenumber
            // 
            this.label_Sitenumber.AutoSize = true;
            this.label_Sitenumber.Location = new System.Drawing.Point(32, 93);
            this.label_Sitenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Sitenumber.Name = "label_Sitenumber";
            this.label_Sitenumber.Size = new System.Drawing.Size(68, 13);
            this.label_Sitenumber.TabIndex = 2;
            this.label_Sitenumber.Text = "Site Number:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(144, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 136);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // listBox_member
            // 
            this.listBox_member.FormattingEnabled = true;
            this.listBox_member.Location = new System.Drawing.Point(144, 253);
            this.listBox_member.Name = "listBox_member";
            this.listBox_member.Size = new System.Drawing.Size(206, 147);
            this.listBox_member.TabIndex = 7;
            // 
            // Form_Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 446);
            this.Controls.Add(this.listBox_member);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Sitenumber);
            this.Controls.Add(this.label_Title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Entrance";
            this.Text = "Entrance";
            this.Load += new System.EventHandler(this.Form_Entrance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Sitenumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox_member;
    }
}