﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonCatchMe_MouseEnter_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - buttonCatchMe.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - buttonCatchMe.ClientSize.Height;
            this.buttonCatchMe.Location = new Point(rand.Next(maxWidth), rand.Next(maxHeight));
        }

       
        private void buttonCatchMe_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You win!", "Congratulations", MessageBoxButtons.OK);
        }
    }
}
