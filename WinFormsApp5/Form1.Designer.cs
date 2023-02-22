namespace WinFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Robin = new System.Windows.Forms.PictureBox();
            this.Predator = new System.Windows.Forms.PictureBox();
            this.RightArrow = new System.Windows.Forms.PictureBox();
            this.LeftArrow = new System.Windows.Forms.PictureBox();
            this.RedLine1 = new System.Windows.Forms.Button();
            this.Laser1 = new System.Windows.Forms.Button();
            this.Laser2 = new System.Windows.Forms.Button();
            this.Lose1 = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Predator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lose1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-75, -64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 605);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Robin
            // 
            this.Robin.Image = ((System.Drawing.Image)(resources.GetObject("Robin.Image")));
            this.Robin.Location = new System.Drawing.Point(103, 197);
            this.Robin.Name = "Robin";
            this.Robin.Size = new System.Drawing.Size(187, 188);
            this.Robin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Robin.TabIndex = 1;
            this.Robin.TabStop = false;
            // 
            // Predator
            // 
            this.Predator.Image = ((System.Drawing.Image)(resources.GetObject("Predator.Image")));
            this.Predator.Location = new System.Drawing.Point(483, 183);
            this.Predator.Name = "Predator";
            this.Predator.Size = new System.Drawing.Size(164, 222);
            this.Predator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Predator.TabIndex = 2;
            this.Predator.TabStop = false;
            this.Predator.Click += new System.EventHandler(this.Predator_Click);
            // 
            // RightArrow
            // 
            this.RightArrow.Image = ((System.Drawing.Image)(resources.GetObject("RightArrow.Image")));
            this.RightArrow.Location = new System.Drawing.Point(706, 323);
            this.RightArrow.Name = "RightArrow";
            this.RightArrow.Size = new System.Drawing.Size(64, 35);
            this.RightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightArrow.TabIndex = 3;
            this.RightArrow.TabStop = false;
            this.RightArrow.Click += new System.EventHandler(this.RightArrow_Click);
            // 
            // LeftArrow
            // 
            this.LeftArrow.Image = ((System.Drawing.Image)(resources.GetObject("LeftArrow.Image")));
            this.LeftArrow.Location = new System.Drawing.Point(10, 323);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(64, 35);
            this.LeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrow.TabIndex = 4;
            this.LeftArrow.TabStop = false;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // RedLine1
            // 
            this.RedLine1.BackColor = System.Drawing.Color.Red;
            this.RedLine1.FlatAppearance.BorderSize = 0;
            this.RedLine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedLine1.Location = new System.Drawing.Point(366, 290);
            this.RedLine1.Name = "RedLine1";
            this.RedLine1.Size = new System.Drawing.Size(3, 166);
            this.RedLine1.TabIndex = 5;
            this.RedLine1.UseVisualStyleBackColor = false;
            // 
            // Laser1
            // 
            this.Laser1.BackColor = System.Drawing.Color.Red;
            this.Laser1.FlatAppearance.BorderSize = 0;
            this.Laser1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Laser1.Location = new System.Drawing.Point(350, 200);
            this.Laser1.Name = "Laser1";
            this.Laser1.Size = new System.Drawing.Size(194, 3);
            this.Laser1.TabIndex = 6;
            this.Laser1.UseVisualStyleBackColor = false;
            // 
            // Laser2
            // 
            this.Laser2.BackColor = System.Drawing.Color.Red;
            this.Laser2.FlatAppearance.BorderSize = 0;
            this.Laser2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Laser2.Location = new System.Drawing.Point(350, 207);
            this.Laser2.Name = "Laser2";
            this.Laser2.Size = new System.Drawing.Size(200, 3);
            this.Laser2.TabIndex = 7;
            this.Laser2.UseVisualStyleBackColor = false;
            // 
            // Lose1
            // 
            this.Lose1.Image = ((System.Drawing.Image)(resources.GetObject("Lose1.Image")));
            this.Lose1.Location = new System.Drawing.Point(-43, -28);
            this.Lose1.Name = "Lose1";
            this.Lose1.Size = new System.Drawing.Size(898, 505);
            this.Lose1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Lose1.TabIndex = 9;
            this.Lose1.TabStop = false;
            this.Lose1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(252, 333);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(257, 153);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 10;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Lose1);
            this.Controls.Add(this.Laser2);
            this.Controls.Add(this.Laser1);
            this.Controls.Add(this.RedLine1);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.RightArrow);
            this.Controls.Add(this.Predator);
            this.Controls.Add(this.Robin);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Predator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lose1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Robin;
        private PictureBox Predator;
        private PictureBox RightArrow;
        private PictureBox LeftArrow;
        private Button RedLine1;
        private Button Laser1;
        private Button Laser2;
        private PictureBox Lose1;
        private PictureBox Back;
    }
}