namespace RacingGameTutorial
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.Speed_Text = new System.Windows.Forms.Label();
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
            this.MainMenu_Box = new System.Windows.Forms.PictureBox();
            this.MainMenu_Title = new System.Windows.Forms.Label();
            this.MainMenu_Car = new System.Windows.Forms.PictureBox();
            this.Play_Button = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu_Car)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(55, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 82);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(163, -40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 82);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(55, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 82);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(163, 79);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 82);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(55, 199);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 82);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(163, 199);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 82);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Location = new System.Drawing.Point(55, 320);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 82);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.White;
            this.pictureBox8.Location = new System.Drawing.Point(163, 320);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(10, 82);
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
            this.Car.Location = new System.Drawing.Point(99, 269);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(33, 61);
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
            this.EnemyCar1.Location = new System.Drawing.Point(2, 145);
            this.EnemyCar1.Name = "EnemyCar1";
            this.EnemyCar1.Size = new System.Drawing.Size(32, 57);
            this.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar1.TabIndex = 2;
            this.EnemyCar1.TabStop = false;
            // 
            // EnemyCar2
            // 
            this.EnemyCar2.BackColor = System.Drawing.Color.Transparent;
            this.EnemyCar2.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar2.Image")));
            this.EnemyCar2.Location = new System.Drawing.Point(95, -28);
            this.EnemyCar2.Name = "EnemyCar2";
            this.EnemyCar2.Size = new System.Drawing.Size(32, 57);
            this.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EnemyCar2.TabIndex = 2;
            this.EnemyCar2.TabStop = false;
            // 
            // EnemyCar3
            // 
            this.EnemyCar3.BackColor = System.Drawing.Color.Transparent;
            this.EnemyCar3.Image = ((System.Drawing.Image)(resources.GetObject("EnemyCar3.Image")));
            this.EnemyCar3.Location = new System.Drawing.Point(192, 40);
            this.EnemyCar3.Name = "EnemyCar3";
            this.EnemyCar3.Size = new System.Drawing.Size(32, 57);
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
            this.End_Text.BackColor = System.Drawing.Color.White;
            this.End_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End_Text.ForeColor = System.Drawing.Color.Maroon;
            this.End_Text.Location = new System.Drawing.Point(33, 66);
            this.End_Text.Name = "End_Text";
            this.End_Text.Size = new System.Drawing.Size(162, 31);
            this.End_Text.TabIndex = 3;
            this.End_Text.Text = "Game Over";
            this.End_Text.Visible = false;
            // 
            // Score_Text
            // 
            this.Score_Text.AutoSize = true;
            this.Score_Text.BackColor = System.Drawing.Color.Black;
            this.Score_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Text.ForeColor = System.Drawing.Color.White;
            this.Score_Text.Location = new System.Drawing.Point(-2, 4);
            this.Score_Text.Name = "Score_Text";
            this.Score_Text.Size = new System.Drawing.Size(51, 13);
            this.Score_Text.TabIndex = 4;
            this.Score_Text.Text = "Score 0";
            // 
            // Replay_Button
            // 
            this.Replay_Button.BackColor = System.Drawing.Color.White;
            this.Replay_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replay_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Replay_Button.Location = new System.Drawing.Point(82, 135);
            this.Replay_Button.Name = "Replay_Button";
            this.Replay_Button.Size = new System.Drawing.Size(75, 51);
            this.Replay_Button.TabIndex = 5;
            this.Replay_Button.Text = "Replay";
            this.Replay_Button.UseVisualStyleBackColor = false;
            this.Replay_Button.Visible = false;
            this.Replay_Button.Click += new System.EventHandler(this.Replay_Button_Click);
            // 
            // Speed_Text
            // 
            this.Speed_Text.AutoSize = true;
            this.Speed_Text.BackColor = System.Drawing.Color.Black;
            this.Speed_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed_Text.ForeColor = System.Drawing.Color.White;
            this.Speed_Text.Location = new System.Drawing.Point(160, 345);
            this.Speed_Text.Name = "Speed_Text";
            this.Speed_Text.Size = new System.Drawing.Size(54, 13);
            this.Speed_Text.TabIndex = 4;
            this.Speed_Text.Text = "Speed 0";
            // 
            // Coin1
            // 
            this.Coin1.BackColor = System.Drawing.Color.Transparent;
            this.Coin1.Image = ((System.Drawing.Image)(resources.GetObject("Coin1.Image")));
            this.Coin1.Location = new System.Drawing.Point(14, 40);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(20, 20);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin1.TabIndex = 6;
            this.Coin1.TabStop = false;
            this.Coin1.Visible = false;
            // 
            // Coin2
            // 
            this.Coin2.BackColor = System.Drawing.Color.Transparent;
            this.Coin2.Image = ((System.Drawing.Image)(resources.GetObject("Coin2.Image")));
            this.Coin2.Location = new System.Drawing.Point(110, 109);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(20, 20);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin2.TabIndex = 6;
            this.Coin2.TabStop = false;
            this.Coin2.Visible = false;
            // 
            // Coin3
            // 
            this.Coin3.BackColor = System.Drawing.Color.Transparent;
            this.Coin3.Image = ((System.Drawing.Image)(resources.GetObject("Coin3.Image")));
            this.Coin3.Location = new System.Drawing.Point(192, 9);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(20, 20);
            this.Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Coin3.TabIndex = 6;
            this.Coin3.TabStop = false;
            this.Coin3.Visible = false;
            // 
            // Coin1_Mover
            // 
            this.Coin1_Mover.Enabled = true;
            this.Coin1_Mover.Interval = 10;
            this.Coin1_Mover.Tick += new System.EventHandler(this.Coin1_Mover_Tick);
            // 
            // Coin2_Mover
            // 
            this.Coin2_Mover.Enabled = true;
            this.Coin2_Mover.Interval = 10;
            this.Coin2_Mover.Tick += new System.EventHandler(this.Coin2_Mover_Tick);
            // 
            // Coin3_Mover
            // 
            this.Coin3_Mover.Enabled = true;
            this.Coin3_Mover.Interval = 10;
            this.Coin3_Mover.Tick += new System.EventHandler(this.Coin3_Mover_Tick);
            // 
            // Coins_Text
            // 
            this.Coins_Text.AutoSize = true;
            this.Coins_Text.BackColor = System.Drawing.Color.Black;
            this.Coins_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coins_Text.ForeColor = System.Drawing.Color.White;
            this.Coins_Text.Location = new System.Drawing.Point(2, 345);
            this.Coins_Text.Name = "Coins_Text";
            this.Coins_Text.Size = new System.Drawing.Size(63, 13);
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
            this.pictureBox9.Location = new System.Drawing.Point(-9, 340);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(246, 28);
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Black;
            this.pictureBox10.Location = new System.Drawing.Point(-9, -8);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(246, 28);
            this.pictureBox10.TabIndex = 7;
            this.pictureBox10.TabStop = false;
            // 
            // MainMenu_Button
            // 
            this.MainMenu_Button.BackColor = System.Drawing.Color.White;
            this.MainMenu_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Button.ForeColor = System.Drawing.Color.Black;
            this.MainMenu_Button.Location = new System.Drawing.Point(71, 199);
            this.MainMenu_Button.Name = "MainMenu_Button";
            this.MainMenu_Button.Size = new System.Drawing.Size(91, 23);
            this.MainMenu_Button.TabIndex = 8;
            this.MainMenu_Button.Text = "Main Menu";
            this.MainMenu_Button.UseVisualStyleBackColor = false;
            this.MainMenu_Button.Visible = false;
            this.MainMenu_Button.Click += new System.EventHandler(this.MainMenu_Button_Click);
            // 
            // MainMenu_Box
            // 
            this.MainMenu_Box.BackColor = System.Drawing.Color.Black;
            this.MainMenu_Box.Location = new System.Drawing.Point(-9, -8);
            this.MainMenu_Box.Name = "MainMenu_Box";
            this.MainMenu_Box.Size = new System.Drawing.Size(246, 376);
            this.MainMenu_Box.TabIndex = 9;
            this.MainMenu_Box.TabStop = false;
            // 
            // MainMenu_Title
            // 
            this.MainMenu_Title.AutoSize = true;
            this.MainMenu_Title.BackColor = System.Drawing.Color.Black;
            this.MainMenu_Title.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Title.ForeColor = System.Drawing.Color.White;
            this.MainMenu_Title.Location = new System.Drawing.Point(49, 57);
            this.MainMenu_Title.Name = "MainMenu_Title";
            this.MainMenu_Title.Size = new System.Drawing.Size(132, 21);
            this.MainMenu_Title.TabIndex = 10;
            this.MainMenu_Title.Text = "ROAD QUEST";
            // 
            // MainMenu_Car
            // 
            this.MainMenu_Car.BackColor = System.Drawing.Color.Black;
            this.MainMenu_Car.Image = ((System.Drawing.Image)(resources.GetObject("MainMenu_Car.Image")));
            this.MainMenu_Car.Location = new System.Drawing.Point(87, 116);
            this.MainMenu_Car.Name = "MainMenu_Car";
            this.MainMenu_Car.Size = new System.Drawing.Size(56, 86);
            this.MainMenu_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainMenu_Car.TabIndex = 11;
            this.MainMenu_Car.TabStop = false;
            // 
            // Play_Button
            // 
            this.Play_Button.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_Button.Location = new System.Drawing.Point(78, 240);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(75, 23);
            this.Play_Button.TabIndex = 12;
            this.Play_Button.Text = "PLAY";
            this.Play_Button.UseVisualStyleBackColor = true;
            this.Play_Button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(224, 361);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.MainMenu_Car);
            this.Controls.Add(this.MainMenu_Title);
            this.Controls.Add(this.MainMenu_Box);
            this.Controls.Add(this.MainMenu_Button);
            this.Controls.Add(this.Speed_Text);
            this.Controls.Add(this.Score_Text);
            this.Controls.Add(this.Coins_Text);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.End_Text);
            this.Controls.Add(this.Replay_Button);
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
            this.MaximumSize = new System.Drawing.Size(240, 400);
            this.MinimumSize = new System.Drawing.Size(240, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu_Car)).EndInit();
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
        private System.Windows.Forms.Label Speed_Text;
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
        private System.Windows.Forms.PictureBox MainMenu_Box;
        private System.Windows.Forms.Label MainMenu_Title;
        private System.Windows.Forms.PictureBox MainMenu_Car;
        private System.Windows.Forms.Button Play_Button;
    }
}

