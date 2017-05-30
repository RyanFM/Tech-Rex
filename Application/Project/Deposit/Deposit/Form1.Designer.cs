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
            this.label_BA = new System.Windows.Forms.Label();
            this.label_BankAccount = new System.Windows.Forms.Label();
            this.label_ST = new System.Windows.Forms.Label();
            this.label_StartTime = new System.Windows.Forms.Label();
            this.label_ET = new System.Windows.Forms.Label();
            this.label_EndTime = new System.Windows.Forms.Label();
            this.label_NOD = new System.Windows.Forms.Label();
            this.label_NumberOfDeposits = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_BA
            // 
            this.label_BA.AutoSize = true;
            this.label_BA.Location = new System.Drawing.Point(40, 56);
            this.label_BA.Name = "label_BA";
            this.label_BA.Size = new System.Drawing.Size(78, 13);
            this.label_BA.TabIndex = 0;
            this.label_BA.Text = "Bank Account:";
            // 
            // label_BankAccount
            // 
            this.label_BankAccount.AutoSize = true;
            this.label_BankAccount.Location = new System.Drawing.Point(150, 56);
            this.label_BankAccount.Name = "label_BankAccount";
            this.label_BankAccount.Size = new System.Drawing.Size(42, 13);
            this.label_BankAccount.TabIndex = 1;
            this.label_BankAccount.Text = "number";
            // 
            // label_ST
            // 
            this.label_ST.AutoSize = true;
            this.label_ST.Location = new System.Drawing.Point(40, 81);
            this.label_ST.Name = "label_ST";
            this.label_ST.Size = new System.Drawing.Size(54, 13);
            this.label_ST.TabIndex = 2;
            this.label_ST.Text = "Start-time:";
            // 
            // label_StartTime
            // 
            this.label_StartTime.AutoSize = true;
            this.label_StartTime.Location = new System.Drawing.Point(150, 81);
            this.label_StartTime.Name = "label_StartTime";
            this.label_StartTime.Size = new System.Drawing.Size(26, 13);
            this.label_StartTime.TabIndex = 3;
            this.label_StartTime.Text = "time";
            // 
            // label_ET
            // 
            this.label_ET.AutoSize = true;
            this.label_ET.Location = new System.Drawing.Point(40, 106);
            this.label_ET.Name = "label_ET";
            this.label_ET.Size = new System.Drawing.Size(51, 13);
            this.label_ET.TabIndex = 4;
            this.label_ET.Text = "End-time:";
            // 
            // label_EndTime
            // 
            this.label_EndTime.AutoSize = true;
            this.label_EndTime.Location = new System.Drawing.Point(150, 106);
            this.label_EndTime.Name = "label_EndTime";
            this.label_EndTime.Size = new System.Drawing.Size(26, 13);
            this.label_EndTime.TabIndex = 5;
            this.label_EndTime.Text = "time";
            // 
            // label_NOD
            // 
            this.label_NOD.AutoSize = true;
            this.label_NOD.Location = new System.Drawing.Point(40, 131);
            this.label_NOD.Name = "label_NOD";
            this.label_NOD.Size = new System.Drawing.Size(101, 13);
            this.label_NOD.TabIndex = 6;
            this.label_NOD.Text = "Number of deposits:";
            // 
            // label_NumberOfDeposits
            // 
            this.label_NumberOfDeposits.AutoSize = true;
            this.label_NumberOfDeposits.Location = new System.Drawing.Point(150, 131);
            this.label_NumberOfDeposits.Name = "label_NumberOfDeposits";
            this.label_NumberOfDeposits.Size = new System.Drawing.Size(42, 13);
            this.label_NumberOfDeposits.TabIndex = 7;
            this.label_NumberOfDeposits.Text = "number";
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Location = new System.Drawing.Point(40, 196);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(46, 13);
            this.label_Amount.TabIndex = 8;
            this.label_Amount.Text = "Amount:";
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(92, 193);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(100, 20);
            this.textBox_Amount.TabIndex = 9;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(198, 190);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 10;
            this.button_Add.Text = "ADD";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 287);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.label_Amount);
            this.Controls.Add(this.label_NumberOfDeposits);
            this.Controls.Add(this.label_NOD);
            this.Controls.Add(this.label_EndTime);
            this.Controls.Add(this.label_ET);
            this.Controls.Add(this.label_StartTime);
            this.Controls.Add(this.label_ST);
            this.Controls.Add(this.label_BankAccount);
            this.Controls.Add(this.label_BA);
            this.Name = "Main_Form";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_BA;
        private System.Windows.Forms.Label label_BankAccount;
        private System.Windows.Forms.Label label_ST;
        private System.Windows.Forms.Label label_StartTime;
        private System.Windows.Forms.Label label_ET;
        private System.Windows.Forms.Label label_EndTime;
        private System.Windows.Forms.Label label_NOD;
        private System.Windows.Forms.Label label_NumberOfDeposits;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.Button button_Add;
    }
}

