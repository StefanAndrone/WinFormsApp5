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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Robin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Predator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrow)).BeginInit();
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
            this.Predator.Location = new System.Drawing.Point(483, 182);
            this.Predator.Name = "Predator";
            this.Predator.Size = new System.Drawing.Size(164, 222);
            this.Predator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Predator.TabIndex = 2;
            this.Predator.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
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
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox Robin;
        private PictureBox Predator;
        private PictureBox RightArrow;
        private PictureBox LeftArrow;
        private Button RedLine1;
    }
}