namespace Entrance
{
    partial class Form1
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
            this.label_Ticket = new System.Windows.Forms.Label();
            this.label_Ticket_type = new System.Windows.Forms.Label();
            this.button_Checkin = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(66, 26);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(218, 31);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Festival Entrance";
            // 
            // label_Ticket
            // 
            this.label_Ticket.AutoSize = true;
            this.label_Ticket.Location = new System.Drawing.Point(58, 120);
            this.label_Ticket.Name = "label_Ticket";
            this.label_Ticket.Size = new System.Drawing.Size(50, 17);
            this.label_Ticket.TabIndex = 4;
            this.label_Ticket.Text = "Ticket:";
            // 
            // label_Ticket_type
            // 
            this.label_Ticket_type.AutoSize = true;
            this.label_Ticket_type.Location = new System.Drawing.Point(108, 198);
            this.label_Ticket_type.Name = "label_Ticket_type";
            this.label_Ticket_type.Size = new System.Drawing.Size(0, 17);
            this.label_Ticket_type.TabIndex = 5;
            // 
            // button_Checkin
            // 
            this.button_Checkin.Location = new System.Drawing.Point(61, 198);
            this.button_Checkin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Checkin.Name = "button_Checkin";
            this.button_Checkin.Size = new System.Drawing.Size(234, 126);
            this.button_Checkin.TabIndex = 8;
            this.button_Checkin.Text = "Check-in";
            this.button_Checkin.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(408, 21);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(186, 36);
            this.button_Exit.TabIndex = 12;
            this.button_Exit.Text = "Festival exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 413);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Checkin);
            this.Controls.Add(this.label_Ticket_type);
            this.Controls.Add(this.label_Ticket);
            this.Controls.Add(this.label_Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Ticket;
        private System.Windows.Forms.Label label_Ticket_type;
        private System.Windows.Forms.Button button_Checkin;
        private System.Windows.Forms.Button button_Exit;
    }
}

