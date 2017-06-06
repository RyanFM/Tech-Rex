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
            this.label_Line1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_Line1
            // 
            this.label_Line1.AutoSize = true;
            this.label_Line1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Line1.Location = new System.Drawing.Point(138, 258);
            this.label_Line1.Name = "label_Line1";
            this.label_Line1.Size = new System.Drawing.Size(643, 56);
            this.label_Line1.TabIndex = 0;
            this.label_Line1.Text = "Scan your bracelet to enter\r\n";
            this.label_Line1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            //this.timer1.Enabled = true;
            //this.timer1.Interval = 3000;
            //this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Gate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(199)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(933, 825);
            this.Controls.Add(this.label_Line1);
            this.Name = "Form_Gate";
            this.Text = "Form_Gate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Line1;
        private System.Windows.Forms.Timer timer1;
    }
}