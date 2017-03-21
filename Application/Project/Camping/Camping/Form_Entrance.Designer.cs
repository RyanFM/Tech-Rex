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
            this.button_Chekcin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(20, 23);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(240, 31);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Camping Entrance";
            // 
            // label_Sitenumber
            // 
            this.label_Sitenumber.AutoSize = true;
            this.label_Sitenumber.Location = new System.Drawing.Point(43, 114);
            this.label_Sitenumber.Name = "label_Sitenumber";
            this.label_Sitenumber.Size = new System.Drawing.Size(90, 17);
            this.label_Sitenumber.TabIndex = 2;
            this.label_Sitenumber.Text = "Site Number:";
            // 
            // button_Chekcin
            // 
            this.button_Chekcin.Location = new System.Drawing.Point(192, 343);
            this.button_Chekcin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Chekcin.Name = "button_Chekcin";
            this.button_Chekcin.Size = new System.Drawing.Size(266, 128);
            this.button_Chekcin.TabIndex = 5;
            this.button_Chekcin.Text = "Check In";
            this.button_Chekcin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(192, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 168);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Chekcin);
            this.Controls.Add(this.label_Sitenumber);
            this.Controls.Add(this.label_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Entrance";
            this.Text = "Form_Entrance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Sitenumber;
        private System.Windows.Forms.Button button_Chekcin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}