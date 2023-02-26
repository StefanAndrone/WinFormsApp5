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
        Button[] but = new Button[6];

        int var;
        int box_taken = 0;
        int blocked1 = 0;
        int blocked2 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Lose2.Visible = false;
            timebut.Visible = false;
            Attack1.Visible = false;
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
                but[i] = new Button();
                Controls.Add(slot[i]);
                Controls.Add(but[i]);
                slot[i].Height = slot[i].Width = 50;
                but[i].Height = but[i].Width = 60;
                slot[i].BackColor = Color.Black;
                but[i].BackColor = Color.Green;
                i++;
                int a = (i % 2 + 1) % 2;
                int b = (i - 1) / 2;
                i--;
                slot[i].Location = new Point(10 + 60 * b, 10 + 60 * a);
                but[i].Location = new Point(slot[i].Location.X - 5, slot[i].Location.Y - 5);
                slot[i].BringToFront();
                slot[i].FlatStyle = FlatStyle.Flat;
                slot[i].FlatAppearance.BorderSize = 0;
                but[i].FlatStyle = FlatStyle.Flat;
                but[i].FlatAppearance.BorderSize = 0;
                but[i].BringToFront();
                but[i].Visible = false;
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
            if (blocked1 == 1 || blocked2 == 1)
                return;
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
               blocked1 = 1;
               for (int i = 0; i <= 5; i++)
                   but[i].Visible = false;
               for (int i = 1; i <= 27; i++)
               {
                    Robin.Location = new Point(Robin.Location.X + 5, Robin.Location.Y);
                    await Task.Delay(25);
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
            if (blocked1 == 1 || blocked2 == 1)
                return;
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

        private async void Predator_Click(object sender, EventArgs e)
        {
            if (but[0].Visible == true)
            {
                blocked2 = 1;
                Lemon.Visible = false;
                Staff.Visible = false;
                Bucketofwater.Visible = false;
                Apple.Visible = false;
                but[0].Visible = false;
                disp(inventory, slot);
                Attack1.Location = new Point(0, 0);
                Attack1.Height = 450;
                Attack1.Width = 783;
                Attack1.Visible = true;
                await Task.Delay(1000);
                Attack1.Visible = false;
                apare(inventory, slot);
                swap_pictures(Lemon, Staff);
                swap_pictures(Lemon, Bucketofwater);
                swap_pictures(Lemon, Apple);
                for (int i = 1; i <= 3; i++)
                    swap_buttons(but[0], but[i]);
                Apple.Visible = true;
                Bucketofwater.Visible = true;
                Staff.Visible = true;
                timebut.Visible = true;
                await Task.Delay(1000);
                timebut.Text = "00:02";
                await Task.Delay(1000);
                timebut.Text = "00:01";
                await Task.Delay(1000);
                but[1].Visible = but[2].Visible = but[3].Visible = false;
                blocked1 = 1;
                timebut.Visible = false;
                Laser1.Visible = true;
                Laser2.Visible = true;
                Laser1.Location = new Point(Laser1.Location.X - 140, Laser1.Location.Y);
                Laser1.Width = Laser1.Width + 140;
                Laser2.Location = new Point(Laser2.Location.X - 140, Laser2.Location.Y);
                Laser2.Width = Laser2.Width + 140;
                await Task.Delay(500);
                Laser1.Visible = Laser2.Visible = Robin.Visible = false;
                await Task.Delay(1000);
                disp(inventory, slot);
                Apple.Visible = false;
                Bucketofwater.Visible = false;
                Staff.Visible = false;
                Lose2.Location = new Point(0, 0);
                Lose2.Height = 450;
                Lose2.Width = 783;
                Lose2.Visible = true;
                Back.Visible = true;
                Back.BringToFront();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            if(Lose1.Visible == true)
            {
                blocked1 = 0;
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
            else if(Lose2.Visible == true)
            {
                swap_pictures(Lemon, Apple);
                swap_pictures(Lemon, Bucketofwater);
                swap_pictures(Lemon, Staff);
                for (int i = 3; i >= 1; i--)
                    swap_buttons(but[0], but[i]);
                apare(inventory, slot);
                blocked2 = 0;
                blocked1 = 0;
                Lose2.Visible = false;
                Back.Visible = false;
                Robin.Visible = true;
                Lemon.Visible = true;
                Staff.Visible = true;
                Bucketofwater.Visible = true;
                Apple.Visible = true;
                timebut.Text = "00:03";
                Laser1.Location = new Point(Laser1.Location.X + 140, Laser1.Location.Y);
                Laser1.Width = Laser1.Width - 140;
                Laser2.Location = new Point(Laser2.Location.X + 140, Laser2.Location.Y);
                Laser2.Width = Laser2.Width - 140;
            }
        }

        private void swap_pictures(PictureBox p1, PictureBox p2)
        {         
            Point aux = new Point();
            aux.X = p1.Location.X;            
            aux.Y = p1.Location.Y;
            p1.Location = new Point(p2.Location.X, p2.Location.Y);
            p2.Location = new Point(aux.X, aux.Y);
        }

        private void swap_buttons(Button p1, Button p2)
        {
            Point aux = new Point();
            aux.X = p1.Location.X;
            aux.Y = p1.Location.Y;
            p1.Location = new Point(p2.Location.X, p2.Location.Y);
            p2.Location = new Point(aux.X, aux.Y);
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
        
        private void Lemon_Click(object sender, EventArgs e)
        {
            if (blocked1 == 1)
                return;
            but[0].Visible = true;
            Lemon.BringToFront();
            but[1].Visible = false;
            but[2].Visible = false;
            but[3].Visible = false;
            but[4].Visible = false;
            but[5].Visible = false;
        }

        private void Bucketofwater_Click(object sender, EventArgs e)
        {
            if (blocked1 == 1)
                return;
            but[2].Visible = true;
            Bucketofwater.BringToFront();
            but[0].Visible = false;
            but[1].Visible = false;
            but[3].Visible = false;
            but[4].Visible = false;
            but[5].Visible = false;
        }

        private void Apple_Click(object sender, EventArgs e)
        {
            if (blocked1 == 1)
                return;
            but[3].Visible = true;
            Apple.BringToFront();
            but[1].Visible = false;
            but[2].Visible = false;
            but[0].Visible = false;
            but[4].Visible = false;
            but[5].Visible = false;
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            if (blocked1 == 1)
                return;
            but[1].Visible = true;
            Staff.BringToFront();
            but[2].Visible = false;
            but[0].Visible = false;
            but[3].Visible = false;
            but[4].Visible = false;
            but[5].Visible = false;
        }
    }

}