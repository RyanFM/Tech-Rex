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
            this.label_Line1.Location = new System.Drawing.Point(188, 256);
            this.label_Line1.Name = "label_Line1";
            this.label_Line1.Size = new System.Drawing.Size(435, 46);
            this.label_Line1.TabIndex = 0;
            this.label_Line1.Text = "Scan your tag to enter\r\n";
            this.label_Line1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Gate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(829, 660);
            this.Controls.Add(this.label_Line1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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