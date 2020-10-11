namespace AssesementIOne
{
    partial class MainForm
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
            this.ShootingButton = new System.Windows.Forms.Button();
            this.SpinningButton = new System.Windows.Forms.Button();
            this.Shooter = new System.Windows.Forms.Button();
            this.Gun = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShootingButton
            // 
            this.ShootingButton.Location = new System.Drawing.Point(672, 12);
            this.ShootingButton.Name = "ShootingButton";
            this.ShootingButton.Size = new System.Drawing.Size(99, 80);
            this.ShootingButton.TabIndex = 1;
            this.ShootingButton.Text = "Shoot At Head";
            this.ShootingButton.UseVisualStyleBackColor = true;
            this.ShootingButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpinningButton
            // 
            this.SpinningButton.Location = new System.Drawing.Point(672, 108);
            this.SpinningButton.Name = "SpinningButton";
            this.SpinningButton.Size = new System.Drawing.Size(99, 73);
            this.SpinningButton.TabIndex = 2;
            this.SpinningButton.Text = "Spin";
            this.SpinningButton.UseVisualStyleBackColor = true;
            this.SpinningButton.Click += new System.EventHandler(this.SpinningButton_Click);
            // 
            // Shooter
            // 
            this.Shooter.Location = new System.Drawing.Point(672, 215);
            this.Shooter.Name = "Shooter";
            this.Shooter.Size = new System.Drawing.Size(99, 85);
            this.Shooter.TabIndex = 3;
            this.Shooter.Text = "Shoot Away";
            this.Shooter.UseVisualStyleBackColor = true;
            this.Shooter.Click += new System.EventHandler(this.button3_Click);
            // 
            // Gun
            // 
            this.Gun.Location = new System.Drawing.Point(672, 323);
            this.Gun.Name = "Gun";
            this.Gun.Size = new System.Drawing.Size(99, 89);
            this.Gun.TabIndex = 4;
            this.Gun.Text = "Weapon Load";
            this.Gun.UseVisualStyleBackColor = true;
            this.Gun.Click += new System.EventHandler(this.button4_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(35, 26);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(51, 20);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AssesementIOne.Properties.Resources.gun;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Gun);
            this.Controls.Add(this.Shooter);
            this.Controls.Add(this.SpinningButton);
            this.Controls.Add(this.ShootingButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ShootingButton;
        private System.Windows.Forms.Button SpinningButton;
        private System.Windows.Forms.Button Shooter;
        private System.Windows.Forms.Button Gun;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.TextBox textBox1;
    }
}

