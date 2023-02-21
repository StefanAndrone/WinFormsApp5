using System.Resources;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            Robin.Visible = true;
            Predator.Visible = false;
            LeftArrow.Visible = false;
            RightArrow.Visible = true;
            RedLine1.Visible= false;
        }

        private void RightArrow_Click(object sender, EventArgs e)
        {
            Robin.Visible = true;
            Predator.Visible = true;
            LeftArrow.Visible = true;
            RedLine1.Visible = true;
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            Robin.Visible = true;
            Predator.Visible = false;
            LeftArrow.Visible = false;
            RightArrow.Visible = true;
            RedLine1.Visible = false;
        }
    }

}