﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrance
{
    public partial class Form_Exit : Form
    {
        public Form_Exit()
        {
            InitializeComponent();
        }

        private void button_Entrance_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            this.Hide();
            Form.ShowDialog();
            this.Close();
        }
    }
}
