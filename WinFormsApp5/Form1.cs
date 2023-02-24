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

        Button inventory = new Button();
        Button[] slot = new Button[6];

        int var;
        int box_taken = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Lemon.Visible = false;
            Staff.Visible = false;
            Apple.Visible = false;
            Bucketofwater.Visible = false;
            Box.Visible = true;
            Controls.Add(inventory);
            inventory.Location = new Point(0, 0);
            inventory.Height = 130;
            inventory.Width = 190;
            inventory.BackColor = Color.Brown;
            inventory.BringToFront();             
            inventory.FlatStyle = FlatStyle.Flat;
            inventory.FlatAppearance.BorderSize = 0;
            
            for (int i = 0; i < 6; i++)
            {
                slot[i] = new Button();
                Controls.Add(slot[i]);
                slot[i].Height = slot[i].Width = 50;
                slot[i].BackColor = Color.Black;
                i++;
                int a = (i % 2 + 1) % 2;
                int b = (i - 1) / 2;
                i--;
                slot[i].Location = new Point(10 + 60 * b, 10 + 60 * a);
                slot[i].BringToFront();
                slot[i].FlatStyle = FlatStyle.Flat;
                slot[i].FlatAppearance.BorderSize = 0;
            }
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
            Box.Visible = false;
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
               disp(inventory, slot);
               Lemon.Visible = false;
               Staff.Visible = false;
               Apple.Visible = false;
               Bucketofwater.Visible = false;
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
            if (box_taken == 0)
                Box.Visible = true;
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
            apare(inventory, slot);
            if (box_taken == 1)
            {
                Lemon.Visible = true;
                Staff.Visible = true;
                Apple.Visible = true;
                Bucketofwater.Visible = true;
            }
        }

        private void disp(Button inventory, Button[] slot)
        {
            inventory.Visible = false;
            for (int i = 0; i < 6; i++)
                slot[i].Visible = false;
        }

        private void apare(Button inventory, Button[] slot)
        {
            inventory.Visible = true;
            for (int i = 0; i < 6; i++)
                slot[i].Visible = true;
        }

        private void Box_Click(object sender, EventArgs e)
        {
            box_taken = 1;
            Box.Visible = false;
            Lemon.Visible = true;
            Lemon.BringToFront();
            Staff.Visible = true;
            Staff.BringToFront();
            Apple.Visible = true;
            Apple.BringToFront();
            Bucketofwater.Visible = true;
            Bucketofwater.BringToFront();
        }
    }

}