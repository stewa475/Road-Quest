namespace RacingGameTutorial
{
    partial class Form2_MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2_MainMenu));
            this.MainMenu_Title = new System.Windows.Forms.Label();
            this.MainMenu_Car = new System.Windows.Forms.PictureBox();
            this.Play_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainMenu_Music = new System.Windows.Forms.Button();
            this.Cookie1 = new System.Windows.Forms.PictureBox();
            this.Cookie2 = new System.Windows.Forms.PictureBox();
            this.Cookie3 = new System.Windows.Forms.PictureBox();
            this.Cookie1_Mover = new System.Windows.Forms.Timer(this.components);
            this.Cookie2_Mover = new System.Windows.Forms.Timer(this.components);
            this.Cookie3_Mover = new System.Windows.Forms.Timer(this.components);
            this.Cookie4 = new System.Windows.Forms.PictureBox();
            this.Cookie4_Mover = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu_Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie4)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu_Title
            // 
            this.MainMenu_Title.AutoSize = true;
            this.MainMenu_Title.BackColor = System.Drawing.Color.Black;
            this.MainMenu_Title.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Title.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.MainMenu_Title.Location = new System.Drawing.Point(82, 51);
            this.MainMenu_Title.Name = "MainMenu_Title";
            this.MainMenu_Title.Size = new System.Drawing.Size(305, 54);
            this.MainMenu_Title.TabIndex = 11;
            this.MainMenu_Title.Text = "ROAD QUEST";
            // 
            // MainMenu_Car
            // 
            this.MainMenu_Car.BackColor = System.Drawing.Color.Black;
            this.MainMenu_Car.Image = ((System.Drawing.Image)(resources.GetObject("MainMenu_Car.Image")));
            this.MainMenu_Car.Location = new System.Drawing.Point(184, 165);
            this.MainMenu_Car.Name = "MainMenu_Car";
            this.MainMenu_Car.Size = new System.Drawing.Size(112, 172);
            this.MainMenu_Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainMenu_Car.TabIndex = 12;
            this.MainMenu_Car.TabStop = false;
            // 
            // Play_Button
            // 
            this.Play_Button.BackColor = System.Drawing.Color.Black;
            this.Play_Button.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.Play_Button.FlatAppearance.BorderSize = 10;
            this.Play_Button.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_Button.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Play_Button.Location = new System.Drawing.Point(148, 409);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(184, 64);
            this.Play_Button.TabIndex = 13;
            this.Play_Button.Text = "Play";
            this.Play_Button.UseVisualStyleBackColor = false;
            this.Play_Button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(148, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 64);
            this.button1.TabIndex = 14;
            this.button1.Text = "Rankings";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu_Music
            // 
            this.MainMenu_Music.BackColor = System.Drawing.Color.Black;
            this.MainMenu_Music.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Music.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.MainMenu_Music.Location = new System.Drawing.Point(310, 711);
            this.MainMenu_Music.Name = "MainMenu_Music";
            this.MainMenu_Music.Size = new System.Drawing.Size(150, 46);
            this.MainMenu_Music.TabIndex = 16;
            this.MainMenu_Music.Text = "Music Off";
            this.MainMenu_Music.UseVisualStyleBackColor = false;
            this.MainMenu_Music.Click += new System.EventHandler(this.MainMenu_Music_Click);
            // 
            // Cookie1
            // 
            this.Cookie1.BackColor = System.Drawing.Color.Transparent;
            this.Cookie1.Image = ((System.Drawing.Image)(resources.GetObject("Cookie1.Image")));
            this.Cookie1.Location = new System.Drawing.Point(30, 244);
            this.Cookie1.Name = "Cookie1";
            this.Cookie1.Size = new System.Drawing.Size(40, 40);
            this.Cookie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cookie1.TabIndex = 17;
            this.Cookie1.TabStop = false;
            // 
            // Cookie2
            // 
            this.Cookie2.BackColor = System.Drawing.Color.Transparent;
            this.Cookie2.Image = ((System.Drawing.Image)(resources.GetObject("Cookie2.Image")));
            this.Cookie2.Location = new System.Drawing.Point(172, -11);
            this.Cookie2.Name = "Cookie2";
            this.Cookie2.Size = new System.Drawing.Size(40, 40);
            this.Cookie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cookie2.TabIndex = 17;
            this.Cookie2.TabStop = false;
            // 
            // Cookie3
            // 
            this.Cookie3.BackColor = System.Drawing.Color.Transparent;
            this.Cookie3.Image = ((System.Drawing.Image)(resources.GetObject("Cookie3.Image")));
            this.Cookie3.Location = new System.Drawing.Point(412, 450);
            this.Cookie3.Name = "Cookie3";
            this.Cookie3.Size = new System.Drawing.Size(40, 40);
            this.Cookie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cookie3.TabIndex = 17;
            this.Cookie3.TabStop = false;
            // 
            // Cookie1_Mover
            // 
            this.Cookie1_Mover.Enabled = true;
            this.Cookie1_Mover.Interval = 10;
            this.Cookie1_Mover.Tick += new System.EventHandler(this.Cookie1_Mover_Tick);
            // 
            // Cookie2_Mover
            // 
            this.Cookie2_Mover.Enabled = true;
            this.Cookie2_Mover.Interval = 10;
            this.Cookie2_Mover.Tick += new System.EventHandler(this.Cookie2_Mover_Tick);
            // 
            // Cookie3_Mover
            // 
            this.Cookie3_Mover.Enabled = true;
            this.Cookie3_Mover.Interval = 10;
            this.Cookie3_Mover.Tick += new System.EventHandler(this.Cookie3_Mover_Tick);
            // 
            // Cookie4
            // 
            this.Cookie4.BackColor = System.Drawing.Color.Transparent;
            this.Cookie4.Image = ((System.Drawing.Image)(resources.GetObject("Cookie4.Image")));
            this.Cookie4.Location = new System.Drawing.Point(305, 694);
            this.Cookie4.Name = "Cookie4";
            this.Cookie4.Size = new System.Drawing.Size(40, 40);
            this.Cookie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cookie4.TabIndex = 17;
            this.Cookie4.TabStop = false;
            // 
            // Cookie4_Mover
            // 
            this.Cookie4_Mover.Enabled = true;
            this.Cookie4_Mover.Interval = 10;
            this.Cookie4_Mover.Tick += new System.EventHandler(this.Cookie4_Mover_Tick);
            // 
            // Form2_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 761);
            this.Controls.Add(this.MainMenu_Music);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.MainMenu_Car);
            this.Controls.Add(this.MainMenu_Title);
            this.Controls.Add(this.Cookie4);
            this.Controls.Add(this.Cookie3);
            this.Controls.Add(this.Cookie2);
            this.Controls.Add(this.Cookie1);
            this.MaximumSize = new System.Drawing.Size(480, 800);
            this.MinimumSize = new System.Drawing.Size(480, 800);
            this.Name = "Form2_MainMenu";
            this.Text = "Form2_MainMenu";
            this.Load += new System.EventHandler(this.Form2_MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu_Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainMenu_Title;
        private System.Windows.Forms.PictureBox MainMenu_Car;
        private System.Windows.Forms.Button Play_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MainMenu_Music;
        private System.Windows.Forms.PictureBox Cookie1;
        private System.Windows.Forms.PictureBox Cookie2;
        private System.Windows.Forms.PictureBox Cookie3;
        private System.Windows.Forms.Timer Cookie1_Mover;
        private System.Windows.Forms.Timer Cookie2_Mover;
        private System.Windows.Forms.Timer Cookie3_Mover;
        private System.Windows.Forms.PictureBox Cookie4;
        private System.Windows.Forms.Timer Cookie4_Mover;
    }
}