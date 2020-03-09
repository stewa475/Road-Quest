namespace RacingGameTutorial
{
    partial class Form4_RaceGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_RaceGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.RoadMover = new System.Windows.Forms.Timer(this.components);
            this.Car = new System.Windows.Forms.PictureBox();
            this.Left_mover = new System.Windows.Forms.Timer(this.components);
            this.Right_mover = new System.Windows.Forms.Timer(this.components);
            this.EnemyCar1 = new System.Windows.Forms.PictureBox();
            this.EnemyCar2 = new System.Windows.Forms.PictureBox();
            this.EnemyCar3 = new System.Windows.Forms.PictureBox();
            this.Enemy1_Mover = new System.Windows.Forms.Timer(this.components);
            this.Enemy2_Mover = new System.Windows.Forms.Timer(this.components);
            this.Enemy3_Mover = new System.Windows.Forms.Timer(this.components);
            this.End_Text = new System.Windows.Forms.Label();
            this.Score_Text = new System.Windows.Forms.Label();
            this.Replay_Button = new System.Windows.Forms.Button();
            this.Level_Text = new System.Windows.Forms.Label();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin1_Mover = new System.Windows.Forms.Timer(this.components);
            this.Coin2_Mover = new System.Windows.Forms.Timer(this.components);
            this.Coin3_Mover = new System.Windows.Forms.Timer(this.components);
            this.Coins_Text = new System.Windows.Forms.Label();
            this.Score_Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.MainMenu_Button = new System.Windows.Forms.Button();
            this.Grandpa_Mover = new System.Windows.Forms.Timer(this.components);
            this.GrandpaCar = new System.Windows.Forms.PictureBox();
            this.RaceGame_Grandpa = new System.Windows.Forms.Label();
            this.RaceGame_ContButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrandpaCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(120, -77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(328, -77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 164);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(120, 172);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 164);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(328, 172);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 164);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(120, 417);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 164);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(328, 417);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 164);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(120, 659);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 164);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(328, 659);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 164);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RoadMover
            // 
            this.RoadMover.Enabled = true;
            this.RoadMover.Interval = 10;
            this.RoadMover.Tick += new System.EventHandler(this.RoadMover_Tick);
            // 
            // Car
            // 
            this.Car.BackColor = System.Drawing.Color.Transparent;
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(202, 567);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(64, 120);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Car.TabIndex = 1;
            this.Car.TabStop = false;
            // 
            // Left_mover
            // 
            this.Left_mover.Interval = 10;
            this.Left_mover.Tick += new System.EventHandler(this.Left_mover_Tick);
            // 
            // Right_mover
            // 
            this.Right_mover.Interval = 10;
            this.Right_mover.Tick += new System.EventHandler(this.Right_mover_Tick);
            // 
            // EnemyCar1
            // 
            this.EnemyCar1.BackColor = System.Drawing.Color.Transparent;
            this.EnemyCar1.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar1.Image")));
            this.EnemyCar1.Location = new System.Drawing.Point(6, 264);
            this.EnemyCar1.Name = "EnemyCar1";
            this.EnemyCar1.Size = new System.Drawing.Size(64, 120);
            this.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar1.TabIndex = 2;
            this.EnemyCar1.TabStop = false;
            // 
            // EnemyCar2
            // 
            this.EnemyCar2.BackColor = System.Drawing.Color.Transparent;
            this.EnemyCar2.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar2.Image")));
            this.EnemyCar2.Location = new System.Drawing.Point(208, -14);
            this.EnemyCar2.Name = "EnemyCar2";
            this.EnemyCar2.Size = new System.Drawing.Size(64, 120);
            this.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar2.TabIndex = 2;
            this.EnemyCar2.TabStop = false;
            // 
            // EnemyCar3
            // 
            this.EnemyCar3.BackColor = System.Drawing.Color.Transparent;
            this.EnemyCar3.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar3.Image")));
            this.EnemyCar3.Location = new System.Drawing.Point(354, 287);
            this.EnemyCar3.Name = "EnemyCar3";
            this.EnemyCar3.Size = new System.Drawing.Size(64, 120);
            this.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar3.TabIndex = 2;
            this.EnemyCar3.TabStop = false;
            // 
            // Enemy1_Mover
            // 
            this.Enemy1_Mover.Enabled = true;
            this.Enemy1_Mover.Interval = 10;
            this.Enemy1_Mover.Tick += new System.EventHandler(this.Enemy1_Mover_Tick);
            // 
            // Enemy2_Mover
            // 
            this.Enemy2_Mover.Enabled = true;
            this.Enemy2_Mover.Interval = 10;
            this.Enemy2_Mover.Tick += new System.EventHandler(this.Enemy2_Mover_Tick);
            // 
            // Enemy3_Mover
            // 
            this.Enemy3_Mover.Enabled = true;
            this.Enemy3_Mover.Interval = 10;
            this.Enemy3_Mover.Tick += new System.EventHandler(this.Enemy3_Mover_Tick);
            // 
            // End_Text
            // 
            this.End_Text.AutoSize = true;
            this.End_Text.BackColor = System.Drawing.Color.Black;
            this.End_Text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.End_Text.Font = new System.Drawing.Font("Algerian", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Text.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.End_Text.Location = new System.Drawing.Point(67, 130);
            this.End_Text.Name = "End_Text";
            this.End_Text.Size = new System.Drawing.Size(321, 61);
            this.End_Text.TabIndex = 3;
            this.End_Text.Text = "Game Over";
            this.End_Text.Visible = false;
            // 
            // Score_Text
            // 
            this.Score_Text.AutoSize = true;
            this.Score_Text.BackColor = System.Drawing.Color.Black;
            this.Score_Text.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Text.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Score_Text.Location = new System.Drawing.Point(12, 16);
            this.Score_Text.Name = "Score_Text";
            this.Score_Text.Size = new System.Drawing.Size(86, 24);
            this.Score_Text.TabIndex = 4;
            this.Score_Text.Text = "Score 0";
            // 
            // Replay_Button
            // 
            this.Replay_Button.BackColor = System.Drawing.Color.Black;
            this.Replay_Button.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.Replay_Button.FlatAppearance.BorderSize = 10;
            this.Replay_Button.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replay_Button.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Replay_Button.Location = new System.Drawing.Point(140, 287);
            this.Replay_Button.Name = "Replay_Button";
            this.Replay_Button.Size = new System.Drawing.Size(184, 64);
            this.Replay_Button.TabIndex = 5;
            this.Replay_Button.Text = "Replay";
            this.Replay_Button.UseVisualStyleBackColor = false;
            this.Replay_Button.Visible = false;
            this.Replay_Button.Click += new System.EventHandler(this.Replay_Button_Click);
            // 
            // Level_Text
            // 
            this.Level_Text.AutoSize = true;
            this.Level_Text.BackColor = System.Drawing.Color.Black;
            this.Level_Text.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level_Text.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Level_Text.Location = new System.Drawing.Point(357, 723);
            this.Level_Text.Name = "Level_Text";
            this.Level_Text.Size = new System.Drawing.Size(84, 24);
            this.Level_Text.TabIndex = 4;
            this.Level_Text.Text = "Level 0";
            // 
            // Coin1
            // 
            this.Coin1.BackColor = System.Drawing.Color.Transparent;
            this.Coin1.Image = ((System.Drawing.Image)(resources.GetObject("Coin1.Image")));
            this.Coin1.Location = new System.Drawing.Point(52, 218);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(40, 40);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 6;
            this.Coin1.TabStop = false;
            this.Coin1.Visible = false;
            // 
            // Coin2
            // 
            this.Coin2.BackColor = System.Drawing.Color.Transparent;
            this.Coin2.Image = ((System.Drawing.Image)(resources.GetObject("Coin2.Image")));
            this.Coin2.Location = new System.Drawing.Point(223, 356);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(40, 40);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 6;
            this.Coin2.TabStop = false;
            this.Coin2.Visible = false;
            // 
            // Coin3
            // 
            this.Coin3.BackColor = System.Drawing.Color.Transparent;
            this.Coin3.Image = ((System.Drawing.Image)(resources.GetObject("Coin3.Image")));
            this.Coin3.Location = new System.Drawing.Point(361, 75);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(40, 40);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin3.TabIndex = 6;
            this.Coin3.TabStop = false;
            this.Coin3.Visible = false;
            // 
            // Coin1_Mover
            // 
            this.Coin1_Mover.Interval = 10;
            this.Coin1_Mover.Tick += new System.EventHandler(this.Coin1_Mover_Tick);
            // 
            // Coin2_Mover
            // 
            this.Coin2_Mover.Interval = 10;
            this.Coin2_Mover.Tick += new System.EventHandler(this.Coin2_Mover_Tick);
            // 
            // Coin3_Mover
            // 
            this.Coin3_Mover.Interval = 10;
            this.Coin3_Mover.Tick += new System.EventHandler(this.Coin3_Mover_Tick);
            // 
            // Coins_Text
            // 
            this.Coins_Text.AutoSize = true;
            this.Coins_Text.BackColor = System.Drawing.Color.Black;
            this.Coins_Text.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coins_Text.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Coins_Text.Location = new System.Drawing.Point(12, 723);
            this.Coins_Text.Name = "Coins_Text";
            this.Coins_Text.Size = new System.Drawing.Size(109, 24);
            this.Coins_Text.TabIndex = 4;
            this.Coins_Text.Text = "Cookies 0";
            // 
            // Score_Timer
            // 
            this.Score_Timer.Enabled = true;
            this.Score_Timer.Tick += new System.EventHandler(this.Score_Timer_Tick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Black;
            this.pictureBox9.Location = new System.Drawing.Point(-16, 706);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(496, 56);
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Black;
            this.pictureBox10.Location = new System.Drawing.Point(-16, -1);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(496, 56);
            this.pictureBox10.TabIndex = 7;
            this.pictureBox10.TabStop = false;
            // 
            // MainMenu_Button
            // 
            this.MainMenu_Button.BackColor = System.Drawing.Color.Black;
            this.MainMenu_Button.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.MainMenu_Button.FlatAppearance.BorderSize = 10;
            this.MainMenu_Button.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Button.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.MainMenu_Button.Location = new System.Drawing.Point(140, 480);
            this.MainMenu_Button.Name = "MainMenu_Button";
            this.MainMenu_Button.Size = new System.Drawing.Size(184, 64);
            this.MainMenu_Button.TabIndex = 8;
            this.MainMenu_Button.Text = "Main Menu";
            this.MainMenu_Button.UseVisualStyleBackColor = false;
            this.MainMenu_Button.Visible = false;
            this.MainMenu_Button.Click += new System.EventHandler(this.MainMenu_Button_Click);
            // 
            // Grandpa_Mover
            // 
            this.Grandpa_Mover.Interval = 10;
            this.Grandpa_Mover.Tick += new System.EventHandler(this.Grandpa_Mover_Tick);
            // 
            // GrandpaCar
            // 
            this.GrandpaCar.BackColor = System.Drawing.Color.Transparent;
            this.GrandpaCar.Image = ((System.Drawing.Image)(resources.GetObject("GrandpaCar.Image")));
            this.GrandpaCar.Location = new System.Drawing.Point(380, -67);
            this.GrandpaCar.Name = "GrandpaCar";
            this.GrandpaCar.Size = new System.Drawing.Size(64, 136);
            this.GrandpaCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GrandpaCar.TabIndex = 2;
            this.GrandpaCar.TabStop = false;
            this.GrandpaCar.Visible = false;
            // 
            // RaceGame_Grandpa
            // 
            this.RaceGame_Grandpa.AutoSize = true;
            this.RaceGame_Grandpa.BackColor = System.Drawing.Color.Black;
            this.RaceGame_Grandpa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RaceGame_Grandpa.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceGame_Grandpa.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.RaceGame_Grandpa.Location = new System.Drawing.Point(73, 240);
            this.RaceGame_Grandpa.Name = "RaceGame_Grandpa";
            this.RaceGame_Grandpa.Size = new System.Drawing.Size(51, 26);
            this.RaceGame_Grandpa.TabIndex = 9;
            this.RaceGame_Grandpa.Text = "Text";
            this.RaceGame_Grandpa.Visible = false;
            // 
            // RaceGame_ContButton
            // 
            this.RaceGame_ContButton.BackColor = System.Drawing.Color.Black;
            this.RaceGame_ContButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceGame_ContButton.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.RaceGame_ContButton.Location = new System.Drawing.Point(142, 430);
            this.RaceGame_ContButton.Name = "RaceGame_ContButton";
            this.RaceGame_ContButton.Size = new System.Drawing.Size(178, 54);
            this.RaceGame_ContButton.TabIndex = 10;
            this.RaceGame_ContButton.Text = "Continue";
            this.RaceGame_ContButton.UseVisualStyleBackColor = false;
            this.RaceGame_ContButton.Visible = false;
            this.RaceGame_ContButton.Click += new System.EventHandler(this.RaceGame_ContButton_Click);
            // 
            // Form4_RaceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(464, 761);
            this.Controls.Add(this.Score_Text);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.RaceGame_ContButton);
            this.Controls.Add(this.RaceGame_Grandpa);
            this.Controls.Add(this.GrandpaCar);
            this.Controls.Add(this.MainMenu_Button);
            this.Controls.Add(this.Replay_Button);
            this.Controls.Add(this.End_Text);
            this.Controls.Add(this.Level_Text);
            this.Controls.Add(this.Coins_Text);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.EnemyCar3);
            this.Controls.Add(this.EnemyCar1);
            this.Controls.Add(this.EnemyCar2);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(480, 800);
            this.MinimumSize = new System.Drawing.Size(480, 800);
            this.Name = "Form4_RaceGame";
            this.Text = "Form4_RaceGame";
            this.Load += new System.EventHandler(this.Form4_RaceGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrandpaCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer RoadMover;
        private System.Windows.Forms.PictureBox Car;
        private System.Windows.Forms.Timer Left_mover;
        private System.Windows.Forms.Timer Right_mover;
        private System.Windows.Forms.PictureBox EnemyCar1;
        private System.Windows.Forms.PictureBox EnemyCar2;
        private System.Windows.Forms.PictureBox EnemyCar3;
        private System.Windows.Forms.Timer Enemy1_Mover;
        private System.Windows.Forms.Timer Enemy2_Mover;
        private System.Windows.Forms.Timer Enemy3_Mover;
        private System.Windows.Forms.Label End_Text;
        private System.Windows.Forms.Label Score_Text;
        private System.Windows.Forms.Button Replay_Button;
        private System.Windows.Forms.Label Level_Text;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.Timer Coin1_Mover;
        private System.Windows.Forms.Timer Coin2_Mover;
        private System.Windows.Forms.Timer Coin3_Mover;
        private System.Windows.Forms.Label Coins_Text;
        private System.Windows.Forms.Timer Score_Timer;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button MainMenu_Button;
        private System.Windows.Forms.Timer Grandpa_Mover;
        private System.Windows.Forms.PictureBox GrandpaCar;
        private System.Windows.Forms.Label RaceGame_Grandpa;
        private System.Windows.Forms.Button RaceGame_ContButton;
    }
}

