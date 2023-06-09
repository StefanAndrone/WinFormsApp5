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
        Button Speak = new Button();

        int var;
        int box_taken = 0;
        int blocked1 = 0;
        int blocked2 = 0;
        int defeated = 0;
        int i_can_combine_staff_with_apple = 0;
        int i_combined_staff_with_apple = 0;
        int door_unlocked = 0;
        int i_defeated_laser = 0;
        int i_made_the_ladder_slippery = 0;
        int covered = 0;
        string s = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            Back4.Visible = false;
            Lose8.Visible = false;
            Image6.Visible = false;
            Remote.Visible = false;
            LaserSafe.Visible = false;
            Back3.Visible = false;
            MathProblem.Visible = false;
            Safe.Visible = false;
            SafeBack.Visible = false;
            DownArrow.Visible = false;
            Lose7.Visible = false;
            SeemoreLaser.Visible = false;
            SeemoreLeft.Visible = false;
            SeemoreRight.Visible = false;
            RedLine3.Visible = false;
            RobinBalance.Visible = false;
            RightArrow4.Visible = false;
            Plank2.Visible = false;
            pictureBox31.Visible = false;
            Black.Visible = false;
            SkatePB.Visible = PlankPB.Visible = StaffPB.Visible = ShovelPB.Visible = false;
            Box2.Visible = false;
            Basement5.Visible = false;
            Lose6.Visible = false;
            Image3.Visible = Image4.Visible = Image5.Visible = Speak2.Visible = false;
            Lose5.Visible = false;
            Image1.Visible = false;
            Basement4.Visible = Robin2.Visible = LaserBasement.Visible = RedLine2.Visible = LeftArrow3.Visible = Button.Visible = false;
            RightArrow3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            Back2.Visible = false;
            Keypad.Visible = false;
            Keypad2.Visible = false;
            pictureBox2.Location = new Point(10000, 10000);
            Lose4.Visible = false;
            B.Visible = false;
            MadModLaser.Visible = false;
            LeftArrow2.Visible = false;
            RightArrow2.Visible = false;
            Basement2.Visible = false;
            Ladder.Visible = false;
            UpArrow.Visible = false;
            Basement1.Visible = false;
            Hole.Visible = false;
            MadMod.Visible = false;
            Controls.Add(Speak);
            Speak.BackColor = Color.Blue;
            Speak.Visible = false;
            Fight1.Visible = Fight2.Visible = false;
            Lose3.Visible = false;
            RobinWithStaff.Visible = false;
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
            RedLine1.Visible = false;
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
            else if (var == 2)
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
            else if (var == 3)
            {
                LeftArrow.Visible = true;
                var = 4;
                Hole.Visible = true;
            }
            else if (var == 4)
            {
                for (int i = 0; i < 6; i++)
                    but[i].Visible = false;
                blocked1 = 1;
                var = 5;
                RightArrow.Visible = false;
                Hole.Visible = false;
                MadMod.Visible = true;
                MadModLaser.Visible = true;
                await Task.Delay(500);
                B.Visible = true;
                await Task.Delay(500);
                Robin.Visible = false;
                B.Visible = false;
                await Task.Delay(1000);
                Lose4.Visible = true;
                Lose4.Height = 450;
                Lose4.Width = 783;
                Lose4.BringToFront();
                Back.Visible = true;
                Back.BringToFront();
            }
            else if(var == 8)
            {
                LeftArrow.Visible = true;
                RightArrow.Visible = false;
                var = 9;
                Box2.Visible = false;
                Black.Visible = true;         
                if (covered == 1)
                {
                    Plank2.Visible = true;
                    RightArrow4.Visible = true;
                }
                return;
            }
            else if(var == 10)
            {
                DownArrow.Visible = false;
                RightArrow.Visible = false;
                SeemoreRight.Visible = true;
                timebut.Visible = true;
                timebut.Text = "00:03";
                await Task.Delay(1000);
                timebut.Text = "00:02";
                await Task.Delay(1000);
                timebut.Text = "00:01";
                await Task.Delay(1000);
                timebut.Visible = false;
                blocked1 = 1;
                pictureBox31.Visible = false;
                SeemoreLeft.Visible = true;
                await Task.Delay(500);
                SeemoreLaser.Visible = true;
                await Task.Delay(1000);
                SeemoreLaser.Visible = Robin.Visible = false;
                await Task.Delay(1000);
                Lose7.Visible = true;
                Lose7.BringToFront();
                Back.Visible = true;
                Back.BringToFront();
            }
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            if (blocked1 == 1 || blocked2 == 1)
                return;
            if (var == 9)
            {
                LeftArrow.Visible = false;
                RightArrow.Visible = true;
                var = 8;
                Box2.Visible = true;
                Black.Visible = false;
                Plank2.Visible = false;
                RightArrow4.Visible = false;
                return;
            }         
            if (var == 5)
            {
                var = 4;
                RightArrow.Visible = true;
                Hole.Visible = true;
                MadMod.Visible = false;
                return;
            }
            if (var == 4)
            {
                var = 3;
                RightArrow.Visible = true;
                Hole.Visible = false;
                LeftArrow.Visible = false;
                return;
            }
            if(var == 11)
            {
                Remote.Visible = false;
                Safe.Visible = false;
                LaserSafe.Visible = false;
                SafeBack.Visible = false;
                RedLine3.Visible = false;
                var = 10;
                RightArrow.Visible = true;
                DownArrow.Visible = true;
                LeftArrow.Visible = false;
                Robin.Location = new Point(Robin.Location.X - 100, Robin.Location.Y);
                Safe.Location = new Point(Safe.Location.X + 100, Safe.Location.Y);
                SafeBack.Location = new Point(SafeBack.Location.X + 100, SafeBack.Location.Y);
                return;
            }
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
            if (but[1].Visible == true && timebut.Visible == true)
            {
                but[1].Visible = but[2].Visible = but[3].Visible = false;
                RedLine1.Visible = false;
                blocked1 = 1;
                RobinWithStaff.Visible = true;
                RobinWithStaff.Location = new Point(Robin.Location.X, Robin.Location.Y);
                RobinWithStaff.Height = Robin.Height;
                RobinWithStaff.Width = Robin.Width;
                Robin.Visible = false;
                defeated = 1;
                timebut.Visible = false;
                for (int i = 1; i <= 42; i++)
                {
                    RobinWithStaff.Location = new Point(RobinWithStaff.Location.X + 5, RobinWithStaff.Location.Y);
                    await Task.Delay(25);
                }
                RobinWithStaff.Visible = Predator.Visible = false;
                for (int i = 1; i <= 3; i++)
                {
                    Fight1.Visible = true;
                    await Task.Delay(500);
                    Fight1.Visible = false;
                    Fight2.Visible = true;
                    await Task.Delay(500);
                    Fight2.Visible = false;
                }
                RobinWithStaff.Visible = true;
                Speak.Visible = true;
                Speak.Location = new Point(450, 160);
                Speak.Height = 70;
                Speak.Width = 200;
                Speak.BringToFront();
                Speak.FlatStyle = FlatStyle.Flat;
                Speak.FlatAppearance.BorderSize = 0;
                RightArrow.Visible = false;
                LeftArrow.Visible = false;
                Speak.Text = "I defeated the Predator, now let's get out of here...";
                await Task.Delay(2000);
                Speak.Visible = false;
                for (int i = 1; i <= 120; i++)
                {
                    RobinWithStaff.Location = new Point(RobinWithStaff.Location.X + 5, RobinWithStaff.Location.Y);
                    await Task.Delay(10);
                }
                RightArrow.Visible = true;
                Robin.Visible = true;
                blocked1 = 0;
                var = 3;
                blocked2 = 0;
                i_can_combine_staff_with_apple = 1;
            }
            else if (but[1].Visible == true && timebut.Visible == false)
            {
                Button b = new Button();
                Controls.Add(b);
                b.BackColor = Color.Red;
                b.Location = new Point(RedLine1.Location.X, RedLine1.Location.Y);
                b.Width = RedLine1.Width;
                b.Height = RedLine1.Height;
                b.BringToFront();
                for (int i = 0; i < 6; i++)
                    but[i].Visible = false;
                blocked1 = 1;
                RobinWithStaff.Visible = true;
                RobinWithStaff.Location = new Point(Robin.Location.X, Robin.Location.Y);
                RobinWithStaff.Height = Robin.Height;
                RobinWithStaff.Width = Robin.Width;
                Robin.Visible = false;
                for (int i = 1; i <= 27; i++)
                {
                    RobinWithStaff.Location = new Point(RobinWithStaff.Location.X + 5, RobinWithStaff.Location.Y);
                    await Task.Delay(25);
                }
                Laser1.Visible = true;
                Laser1.BringToFront();
                Laser2.BringToFront();
                Laser2.Visible = true;
                await Task.Delay(500);
                RobinWithStaff.Visible = false;
                b.Visible = false;
                Laser1.Visible = false;
                Laser2.Visible = false;
                await Task.Delay(1000);
                Lose3.Visible = true;
                Lose3.BringToFront();
                Lose3.Location = new Point(0, 0);
                Lose3.Height = 450;
                Lose3.Width = 783;
                Back.Visible = true;
                Back.BringToFront();
            }
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
                if (defeated == 0)
                {
                    blocked1 = 1;
                    Speak.Visible = false;
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (Lose1.Visible == true)
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
            else if (Lose2.Visible == true)
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
            else if (Lose3.Visible == true)
            {
                Back.Visible = false;
                Lose3.Visible = false;
                blocked1 = 0;
                Robin.Visible = true;
                RobinWithStaff.Location = new Point(RobinWithStaff.Location.X - 135, RobinWithStaff.Location.Y);
            }
            else if (Lose4.Visible == true)
            {
                Lose4.Visible = false;
                Back.Visible = false;
                blocked1 = 0;
                var = 4;
                RightArrow.Visible = true;
                Hole.Visible = true;
                MadMod.Visible = MadModLaser.Visible = false;
                Robin.Visible = true;
            }
            else if (Lose5.Visible == true)
            {
                blocked1 = 0;
                Robin2.Location = new Point(Robin2.Location.X - 110, Robin2.Location.Y);
                Robin2.Visible = true;
                Lose5.Visible = Back.Visible = false;
            }
            else if (Lose6.Visible == true)
            {              
                Image3.Visible = false;
                Speak2.Visible = false;
                Image5.Visible = false;
                Image4.Visible = false;
                Lose6.Visible = false;
                Back.Visible = false;
            }
            else if(Lose7.Visible == true)
            {           
                RightArrow.Visible = true;
                var = 10;
                SeemoreRight.Visible = SeemoreLeft.Visible = false;
                blocked1 = 0;
                Robin.Visible = true;
                Lose7.Visible = Back.Visible = false;
                DownArrow.Visible = true;
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

        private async void Staff_Click(object sender, EventArgs e)
        {
            if (blocked1 == 1)
                return;
            if (but[3].Visible == true)
            {
                if (i_can_combine_staff_with_apple == 1)
                {
                    Staff.Image = pictureBox2.Image;
                    i_combined_staff_with_apple = 1;
                    Apple.Visible = false;
                    but[3].Visible = false;
                }
                else
                {
                    blocked1 = 1;
                    Speak.Visible = true;
                    Speak.Location = new Point(250, 160);
                    Speak.Height = 70;
                    Speak.Width = 200;
                    Speak.BringToFront();
                    Speak.FlatStyle = FlatStyle.Flat;
                    Speak.FlatAppearance.BorderSize = 0;
                    Speak.Text = "I should combine these objects, but not yet";
                    await Task.Delay(1500);
                    Speak.Visible = false;
                    blocked1 = 0;
                }
            }
            else
            {
                but[1].Visible = true;
                Staff.BringToFront();
                but[2].Visible = false;
                but[0].Visible = false;
                but[3].Visible = false;
                but[4].Visible = false;
                but[5].Visible = false;
            }
        }

        private void Hole_Click(object sender, EventArgs e)
        {
            Basement1.Visible = true;
            Basement1.Location = new Point(0, 0);
            Basement1.Height = 450;
            Basement1.Width = 783;
            //Basement1.BringToFront();       
            UpArrow.Visible = true;
            UpArrow.BringToFront();
            Ladder.Visible = true;
            Ladder.BringToFront();
            RightArrow2.Visible = true;
            RightArrow2.BringToFront();

        }

        private void UpArrow_Click(object sender, EventArgs e)
        {
            Basement1.Visible = false;
            UpArrow.Visible = false;
            Ladder.Visible = false;
            RightArrow2.Visible = false;
            RightArrow.Visible = true;
        }

        private void RightArrow2_Click(object sender, EventArgs e)
        {
            if(blocked1 != 1)
            {
                Basement2.Visible = true;
                //Basement2.BringToFront();
                UpArrow.Visible = false;
                Ladder.Visible = RightArrow2.Visible = false;
                Basement2.Height = 450;
                Basement2.Width = 783;
                Basement2.Location = new Point(0, 0);
                RightArrow.Visible = false;
                LeftArrow2.Visible = true;
                LeftArrow2.BringToFront();
                Keypad.Visible = true;
                if (door_unlocked == 1)
                    RightArrow3.Visible = true;
            }       
        }

        private void LeftArrow2_Click(object sender, EventArgs e)
        {
            UpArrow.Visible = true;
            Ladder.Visible = RightArrow2.Visible = true;
            Basement2.Visible = false;
            LeftArrow2.Visible = false;
            RightArrow2.Visible = true;
            Keypad.Visible = false;
            RightArrow3.Visible = false;
        }

        private void Keypad_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            Back2.Visible = true;
            Keypad2.Visible = true;
            Keypad2.BringToFront();
            button1.BringToFront();
            button2.BringToFront();
            button3.BringToFront();
            button4.BringToFront();
            button5.BringToFront();
            button6.BringToFront();
            button7.BringToFront();
            button8.BringToFront();
            button9.BringToFront();
            button10.BringToFront();
            button11.BringToFront();
            button12.BringToFront();
            button13.BringToFront();
            Back2.BringToFront();
            s = "Enter 8 digits";
            button1.Text = s;
            s = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            s = s + "3";
            button1.Text = s;
        }

        private void Back2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            button13.Visible = false;
            Back2.Visible = false;
            Keypad2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s = s + "2";
            button1.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s = s + "1";
            button1.Text = s;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s = s + "4";
            button1.Text = s;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            s = s + "5";
            button1.Text = s;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s = s + "6";
            button1.Text = s;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            s = s + "7";
            button1.Text = s;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            s = s + "8";
            button1.Text = s;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            s = s + "9";
            button1.Text = s;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            s = s + "0";
            button1.Text = s;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            s = "";
            button1.Text = s;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (s != "31415926")
            {
                s = "";
                button1.Text = s;
            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = false;
                button13.Visible = false;
                Back2.Visible = false;
                Keypad2.Visible = false;
                Basement2.Image = pictureBox3.Image;
                Keypad.Dispose();
                RightArrow3.Visible = true;
                door_unlocked = 1;
            }
        }

        private void RightArrow3_Click(object sender, EventArgs e)
        {
            Basement4.Visible = Robin2.Visible = LaserBasement.Visible = RedLine2.Visible = LeftArrow3.Visible = Button.Visible = true;
            LeftArrow2.Visible = false;
        }

        private void LeftArrow3_Click(object sender, EventArgs e)
        {
            if (blocked1 == 0)
            {
                Basement4.Visible = Robin2.Visible = LaserBasement.Visible = RedLine2.Visible = LeftArrow3.Visible = Button.Visible = false;
                LeftArrow2.Visible = true;
            }
        }

        private async void Button_Click(object sender, EventArgs e)
        {
            if (i_defeated_laser == 0)
            {
                if (blocked1 == 0)
                {
                    blocked1 = 1;
                    for (int i = 0; i < 6; i++)
                        but[i].Visible = false;
                    for (int i = 1; i <= 22; i++)
                    {
                        Robin2.Location = new Point(Robin2.Location.X + 5, Robin2.Location.Y);
                        await Task.Delay(25);
                    }
                    Image1.Visible = true;
                    await Task.Delay(750);
                    Image1.Visible = Robin2.Visible = false;
                    await Task.Delay(750);
                    Lose5.Visible = true;
                    Lose5.BringToFront();
                    Back.Visible = true;
                    Back.BringToFront();
                }
            }
            else if(i_made_the_ladder_slippery == 0)
            {
                //361, 188
                //469, 135
                //284, 151
                for (int i = 0; i < 6; i++)
                    but[i].Visible = false;
                blocked1 = 1;
                Image3.Visible = true;
                Image3.BringToFront();
                Speak2.Visible = true;
                Speak2.BringToFront();
                Speak2.BackColor = Speak.BackColor;
                Speak2.Location = new Point(361, 188);
                Speak2.Text = "Why is the laser not working? I should go check it out";
                await Task.Delay(2500);
                Image5.Visible = true;
                Image5.BringToFront();
                Speak2.BringToFront();
                Speak2.Location = new Point(469, 135);
                Speak2.Text = "Robin thinks he's so smart he deactivates my laser, now he'll see...";
                await Task.Delay(2500);
                Image4.Visible = true;
                Image4.BringToFront();
                Speak2.Location = new Point(284, 151);
                Speak2.Text = "You've got to be kidding me...";
                Speak2.BringToFront();
                await Task.Delay(2500);
                Lose6.Visible = true;
                Lose6.BringToFront();
                Back.Visible = true;
                Back.BringToFront();
                blocked1 = 0;
            }
            else
            {
                if(blocked1 == 0)
                {
                    for (int i = 0; i < 6; i++)
                        but[i].Visible = false;
                    blocked1 = 1;
                    Image3.Visible = true;
                    Image3.BringToFront();
                    Speak2.Visible = true;
                    Speak2.BringToFront();
                    Speak2.BackColor = Speak.BackColor;
                    Speak2.Location = new Point(361, 188);
                    Speak2.Text = "Why is the laser not working? I should go check it out";
                    await Task.Delay(2500);
                    Basement5.Visible = true;
                    Basement5.BringToFront();
                    Ladder.Visible = true;
                    Ladder.BringToFront();
                    int[] v = new int[7];
                    v[0] = -93;
                    v[1] = -60;
                    v[2] = -27;
                    v[3] = 6;
                    v[4] = 39;
                    v[5] = 72;
                    v[6] = 103;
                    MadMod2.BringToFront();
                    MadMod2.Visible = true;
                    for (int i = 0; i < 7; i++)
                    {
                        await Task.Delay(25);
                        MadMod2.Location = new Point(288, v[i]);
                    }
                    await Task.Delay(25);
                    MadMod2.Visible = false;
                    Basement5.Image = Basement6.Image;
                    await Task.Delay(1000);
                    Basement5.Visible = Ladder.Visible = false;
                    Image3.Visible = false;
                    Speak2.Location = new Point(284, 151);
                    Speak2.Text = "Guess I finally got rid of Mad Mod, now let's keep moving...";
                    await Task.Delay(2500);
                    Basement4.Visible = Robin2.Visible = LaserBasement.Visible = RedLine2.Visible = LeftArrow3.Visible = Button.Visible = false;
                    Speak2.Visible = false;
                    RightArrow3.Visible = false;
                    Basement1.Visible = Basement2.Visible = false;
                    Hole.Visible = false;
                    LeftArrow.Visible = false;
                    RightArrow.Visible = true;
                    var = 8;
                    blocked1 = 0;
                    Box2.Visible = true;
                    for (int i = 0; i < 6; i++)
                        but[i].Dispose();
                    StaffPB.Visible = true;
                    StaffPB.BringToFront();
                }           
            }
        }


        private void Image1_Click(object sender, EventArgs e)
        {

        }

        private async void LaserBasement_Click(object sender, EventArgs e)
        {
            if(i_combined_staff_with_apple == 1 && but[1].Visible == true && i_defeated_laser == 0)
            {
                for (int i = 0; i < 6; i++)
                    but[i].Visible = false;
                blocked1 = 1;
                Staff.Image = StaffAgain.Image;
                Robin2.Visible = LaserBasement.Visible = RedLine2.Visible = LeftArrow3.Visible = Button.Visible = false;
                Basement4.Image = pictureBox5.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox6.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox7.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox8.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox9.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox10.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox11.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox12.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox13.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox14.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox15.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox16.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox17.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox18.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox19.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox20.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox21.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox22.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox23.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox24.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox25.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox26.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox27.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox28.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox29.Image;
                await Task.Delay(20);
                Basement4.Image = pictureBox30.Image;
                await Task.Delay(20);
                Basement4.Image = Basement4Again.Image;
                Robin2.Visible = LaserBasement.Visible = RedLine2.Visible = LeftArrow3.Visible = Button.Visible = true;
                LaserBasement.Image = BrokenLaser.Image;
                blocked1 = 0;
                i_defeated_laser = 1;
                RedLine2.Dispose();
            }           
        }

        private void Lose5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private async void Ladder_Click_1(object sender, EventArgs e)
        {
            if (but[2].Visible == true)
            {
                but[2].Visible = false;
                if(i_combined_staff_with_apple == 0)
                {
                    swap_buttons(but[2], but[3]);
                    swap_pictures(Bucketofwater, Apple);
                }
                Bucketofwater.Visible = false;
                UpArrow.Dispose();
                blocked1 = 1;
                Speak.Visible = true;
                Speak.BringToFront();
                Speak.Location = new Point(Speak.Location.X - 180, Speak.Location.Y - 50);
                string sss = Speak.Text;
                Speak.Text = "Now the ladder is slippery...";
                await Task.Delay(2000);
                Speak.Visible = false;
                Speak.Text = sss;
                Speak.Location = new Point(Speak.Location.X + 180, Speak.Location.Y + 50);
                blocked1 = 0;
                i_made_the_ladder_slippery = 1;
            }
        }       

        private void button14_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Box2_Click(object sender, EventArgs e)
        {
            SkatePB.Visible = PlankPB.Visible  = ShovelPB.Visible = true;
            SkatePB.BringToFront();
            ShovelPB.BringToFront();
            StaffPB.BringToFront();
            PlankPB.BringToFront();
            Box2.Dispose();
        }

        private void StaffPB_Click(object sender, EventArgs e)
        {
            if (blocked1 == 1)
                return;
            pictureBox31.Visible = true;
            pictureBox31.BringToFront();
            StaffPB.BringToFront();
            pictureBox31.Location = new Point(StaffPB.Location.X - 5, StaffPB.Location.Y - 5);
            pictureBox31.BackColor = Color.Green;
        }

        private void PlankPB_Click(object sender, EventArgs e)
        {
            if (blocked1 == 1)
                return;
            pictureBox31.Visible = true;
            pictureBox31.BringToFront();
            PlankPB.BringToFront();
            pictureBox31.Location = new Point(PlankPB.Location.X - 5, PlankPB.Location.Y - 5);
            pictureBox31.BackColor = Color.Green;
        }

        private void ShovelPB_Click(object sender, EventArgs e)
        {
            if (blocked1 == 1)
                return;
            pictureBox31.Visible = true;
            pictureBox31.BringToFront();
            ShovelPB.BringToFront();
            pictureBox31.Location = new Point(ShovelPB.Location.X - 5, ShovelPB.Location.Y - 5);
            pictureBox31.BackColor = Color.Green;
        }

        private void SkatePB_Click(object sender, EventArgs e)
        {
            if (blocked1 == 1)
                return;
            pictureBox31.Visible = true;
            pictureBox31.BringToFront();
            SkatePB.BringToFront();
            pictureBox31.Location = new Point(SkatePB.Location.X - 5, SkatePB.Location.Y - 5);
            pictureBox31.BackColor = Color.Green;
        }

        private void Black_Click(object sender, EventArgs e)
        {
            if(pictureBox31.Location.X == PlankPB.Location.X - 5 && pictureBox31.Location.Y == PlankPB.Location.Y - 5)
            {
                swap_pictures(PlankPB, SkatePB);
                PlankPB.Visible = false;
                Plank2.Visible = true;
                pictureBox31.Visible = false;
                covered = 1;
                RightArrow4.Visible = true;
            }
        }

        private async void RightArrow4_Click(object sender, EventArgs e)
        {
            if (blocked1 == 1)
                return;
            pictureBox31.Visible = false;
            Speak.Visible = true;
            Speak.Text = "I do not have enough confidence to walk on that thin plank...";
            Speak.Location = new Point(261, 188);
            blocked1 = 1;
            await Task.Delay(2000);
            Speak.Visible = false;
            blocked1 = 0;
        }

        private async void Plank2_Click(object sender, EventArgs e)
        {
            if(pictureBox31.Location.X == StaffPB.Location.X - 5 && pictureBox31.Location.Y == StaffPB.Location.Y - 5)
            {
                pictureBox31.Visible = false;
                blocked1 = 1;
                RobinBalance.Visible = true;
                Robin2.Visible = Robin.Visible = false;
                RightArrow4.Visible = false;
                for (int i = 1; i <= 32; i++)
                {
                    RobinBalance.Location = new Point(RobinBalance.Location.X + 5, RobinBalance.Location.Y);
                    await Task.Delay(40);
                }
                Robin.Visible = true;
                Robin.Location = new Point(Robin.Location.X + 425, Robin.Location.Y);
                RobinBalance.Visible = false;
                for (int i = 1; i <= 60; i++)
                {
                    Robin.Location = new Point(Robin.Location.X + 5, Robin.Location.Y);
                    await Task.Delay(40);
                }
                Robin.Visible = true;
                Robin.Location = new Point(Robin.Location.X - 425 - 300, Robin.Location.Y);
                Black.Visible = false;
                Plank2.Visible = false;
                LeftArrow.Visible = false;
                var = 10;
                blocked1 = 0;
                PlankPB.Visible = true;
                RightArrow.Visible = true;
                DownArrow.Visible = true;
                //RedLine3.Visible = true;
            }        
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void SeemoreLaser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click_1(object sender, EventArgs e)
        {
            Robin.Location = new Point(Robin.Location.X + 100, Robin.Location.Y);
            Safe.Location = new Point(Safe.Location.X - 100, Safe.Location.Y);
            SafeBack.Location = new Point(SafeBack.Location.X - 100, SafeBack.Location.Y);
            Remote.Visible = true;
            LaserSafe.Visible = true;
            Safe.Visible = true;
            SafeBack.Visible = true;
            RedLine3.Visible = true;
            DownArrow.Visible = false;
            RightArrow.Visible = false;
            LeftArrow.Visible = true;
            var = 11;
        }

        private void SafeBack_Click(object sender, EventArgs e)
        {
            if(blocked1 != 1)
            {
                MathProblem.Visible = true;
                MathProblem.BringToFront();
                Back3.Visible = true;
                Back3.BringToFront();
            }        
        }

        private void Back3_Click(object sender, EventArgs e)
        {
            Back3.Visible = false;
            MathProblem.Visible = false;
        }

        private async void Remote_Click(object sender, EventArgs e)
        {
            if(blocked1 != 1)
            {
                blocked1 = 1;
                pictureBox31.Visible = false;
                for (int i = 1; i <= 9; i++)
                {
                    Robin.Location = new Point(Robin.Location.X + 5, Robin.Location.Y);
                    await Task.Delay(25);
                }
                Image6.Visible = true;
                await Task.Delay(750);
                Image6.Visible = Robin.Visible = false;
                await Task.Delay(1000);
                Lose8.Visible = true;
                Lose8.BringToFront();
                Back4.Visible = true;
                Back4.BringToFront();
            }          
        }

        private void Back4_Click(object sender, EventArgs e)
        {
            Lose8.Visible = false;
            Back4.Visible = false;
            Robin.Visible = true;
            Robin.Location = new Point(Robin.Location.X - 45, Robin.Location.Y);
            blocked1 = 0;
        }

        private void Safe_Click(object sender, EventArgs e)
        {
            Keypad2.Visible = true;
            Keypad2.BringToFront();
            Back2.Visible = true;
            Back2.BringToFront();
        }
    }
}