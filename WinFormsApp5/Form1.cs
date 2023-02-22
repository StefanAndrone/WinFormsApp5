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

        int var;
        private void Form1_Load(object sender, EventArgs e)
        {
            Lose1.Visible = false;
            Back.Visible = false;
            Robin.Visible = true;
            Predator.Visible = false;
            LeftArrow.Visible = false;
            RightArrow.Visible = true;
            RedLine1.Visible= false;
            Laser1.Visible = false;
            Laser2.Visible = false;
            var = 1;
        }

        private async void RightArrow_Click(object sender, EventArgs e)
        {
            if (var == 1)
            {
                Lose1.Visible = false;
                Back.Visible = false;
                Robin.Visible = true;
                Predator.Visible = true;
                LeftArrow.Visible = true;
                RedLine1.Visible = true;
                var = 2;
                Laser1.Visible = false;
                Laser2.Visible = false;
            }
            else if(var == 2)
            {
               for(int i = 1; i <= 27; i++)
               {
                    Robin.Location = new Point(Robin.Location.X + 5, Robin.Location.Y);
                    Thread.Sleep(25);
               }
               Laser1.Visible = true;
               Laser2.Visible = true;
               await Task.Delay(500);
               Robin.Visible = false;
               Laser1.Visible = false;
               Laser2.Visible = false;
               await Task.Delay(1000);
               Lose1.Visible = true;
               Back.Visible = true;
               Robin.Location = new Point(Robin.Location.X - 135, Robin.Location.Y);             
            }
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            Lose1.Visible = false;
            Back.Visible = false;
            Robin.Visible = true;
            Predator.Visible = false;
            LeftArrow.Visible = false;
            RightArrow.Visible = true;
            RedLine1.Visible = false;
            var = 1;
            Laser1.Visible = false;
            Laser2.Visible = false;
        }

        private void Predator_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Lose1.Visible = Back.Visible = false;
            Robin.Visible = true;
        }
    }

}