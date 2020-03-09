namespace RacingGameTutorial
{
    partial class Form5_Rankings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5_Rankings));
            this.Rankings_Title = new System.Windows.Forms.Label();
            this.RankingsMM_Button = new System.Windows.Forms.Button();
            this.Rankings_List = new System.Windows.Forms.Label();
            this.Rankings_Ranks = new System.Windows.Forms.Label();
            this.Cookie1 = new System.Windows.Forms.PictureBox();
            this.Cookie2 = new System.Windows.Forms.PictureBox();
            this.Cookie3 = new System.Windows.Forms.PictureBox();
            this.Cookie4 = new System.Windows.Forms.PictureBox();
            this.Cookie1_Mover = new System.Windows.Forms.Timer(this.components);
            this.Cookie2_Mover = new System.Windows.Forms.Timer(this.components);
            this.Cookie3_Mover = new System.Windows.Forms.Timer(this.components);
            this.Cookie4_Mover = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Cookie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie4)).BeginInit();
            this.SuspendLayout();
            // 
            // Rankings_Title
            // 
            this.Rankings_Title.AutoSize = true;
            this.Rankings_Title.BackColor = System.Drawing.Color.Black;
            this.Rankings_Title.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rankings_Title.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Rankings_Title.Location = new System.Drawing.Point(103, 61);
            this.Rankings_Title.Name = "Rankings_Title";
            this.Rankings_Title.Size = new System.Drawing.Size(254, 54);
            this.Rankings_Title.TabIndex = 12;
            this.Rankings_Title.Text = "RANKINGS";
            // 
            // RankingsMM_Button
            // 
            this.RankingsMM_Button.BackColor = System.Drawing.Color.Black;
            this.RankingsMM_Button.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.RankingsMM_Button.FlatAppearance.BorderSize = 20;
            this.RankingsMM_Button.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankingsMM_Button.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.RankingsMM_Button.Location = new System.Drawing.Point(283, 703);
            this.RankingsMM_Button.Name = "RankingsMM_Button";
            this.RankingsMM_Button.Size = new System.Drawing.Size(178, 54);
            this.RankingsMM_Button.TabIndex = 14;
            this.RankingsMM_Button.Text = "Main Menu";
            this.RankingsMM_Button.UseVisualStyleBackColor = false;
            this.RankingsMM_Button.Click += new System.EventHandler(this.RankingsMM_Button_Click);
            // 
            // Rankings_List
            // 
            this.Rankings_List.AutoSize = true;
            this.Rankings_List.BackColor = System.Drawing.Color.Black;
            this.Rankings_List.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rankings_List.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Rankings_List.Location = new System.Drawing.Point(142, 145);
            this.Rankings_List.Name = "Rankings_List";
            this.Rankings_List.Size = new System.Drawing.Size(26, 30);
            this.Rankings_List.TabIndex = 15;
            this.Rankings_List.Text = "0";
            // 
            // Rankings_Ranks
            // 
            this.Rankings_Ranks.AutoSize = true;
            this.Rankings_Ranks.BackColor = System.Drawing.Color.Black;
            this.Rankings_Ranks.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rankings_Ranks.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Rankings_Ranks.Location = new System.Drawing.Point(83, 145);
            this.Rankings_Ranks.Name = "Rankings_Ranks";
            this.Rankings_Ranks.Size = new System.Drawing.Size(53, 300);
            this.Rankings_Ranks.TabIndex = 15;
            this.Rankings_Ranks.Text = "1. \r\n2.\r\n3.\r\n4.\r\n5.\r\n6.\r\n7.\r\n8.\r\n9.\r\n10. ";
            // 
            // Cookie1
            // 
            this.Cookie1.BackColor = System.Drawing.Color.Transparent;
            this.Cookie1.Image = ((System.Drawing.Image)(resources.GetObject("Cookie1.Image")));
            this.Cookie1.Location = new System.Drawing.Point(28, 228);
            this.Cookie1.Name = "Cookie1";
            this.Cookie1.Size = new System.Drawing.Size(40, 40);
            this.Cookie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cookie1.TabIndex = 18;
            this.Cookie1.TabStop = false;
            // 
            // Cookie2
            // 
            this.Cookie2.BackColor = System.Drawing.Color.Transparent;
            this.Cookie2.Image = ((System.Drawing.Image)(resources.GetObject("Cookie2.Image")));
            this.Cookie2.Location = new System.Drawing.Point(158, 3);
            this.Cookie2.Name = "Cookie2";
            this.Cookie2.Size = new System.Drawing.Size(40, 40);
            this.Cookie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cookie2.TabIndex = 19;
            this.Cookie2.TabStop = false;
            // 
            // Cookie3
            // 
            this.Cookie3.BackColor = System.Drawing.Color.Transparent;
            this.Cookie3.Image = ((System.Drawing.Image)(resources.GetObject("Cookie3.Image")));
            this.Cookie3.Location = new System.Drawing.Point(380, 437);
            this.Cookie3.Name = "Cookie3";
            this.Cookie3.Size = new System.Drawing.Size(40, 40);
            this.Cookie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cookie3.TabIndex = 20;
            this.Cookie3.TabStop = false;
            // 
            // Cookie4
            // 
            this.Cookie4.BackColor = System.Drawing.Color.Transparent;
            this.Cookie4.Image = ((System.Drawing.Image)(resources.GetObject("Cookie4.Image")));
            this.Cookie4.Location = new System.Drawing.Point(252, 673);
            this.Cookie4.Name = "Cookie4";
            this.Cookie4.Size = new System.Drawing.Size(40, 40);
            this.Cookie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cookie4.TabIndex = 21;
            this.Cookie4.TabStop = false;
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
            // Cookie4_Mover
            // 
            this.Cookie4_Mover.Enabled = true;
            this.Cookie4_Mover.Interval = 10;
            this.Cookie4_Mover.Tick += new System.EventHandler(this.Cookie4_Mover_Tick);
            // 
            // Form5_Rankings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 761);
            this.Controls.Add(this.Rankings_Ranks);
            this.Controls.Add(this.Rankings_List);
            this.Controls.Add(this.RankingsMM_Button);
            this.Controls.Add(this.Rankings_Title);
            this.Controls.Add(this.Cookie3);
            this.Controls.Add(this.Cookie2);
            this.Controls.Add(this.Cookie1);
            this.Controls.Add(this.Cookie4);
            this.MaximumSize = new System.Drawing.Size(480, 800);
            this.MinimumSize = new System.Drawing.Size(480, 800);
            this.Name = "Form5_Rankings";
            this.Text = "Form5_Rankings";
            this.Load += new System.EventHandler(this.Form5_Rankings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cookie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cookie4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rankings_Title;
        private System.Windows.Forms.Button RankingsMM_Button;
        private System.Windows.Forms.Label Rankings_List;
        private System.Windows.Forms.Label Rankings_Ranks;
        private System.Windows.Forms.PictureBox Cookie1;
        private System.Windows.Forms.PictureBox Cookie2;
        private System.Windows.Forms.PictureBox Cookie3;
        private System.Windows.Forms.PictureBox Cookie4;
        private System.Windows.Forms.Timer Cookie1_Mover;
        private System.Windows.Forms.Timer Cookie2_Mover;
        private System.Windows.Forms.Timer Cookie3_Mover;
        private System.Windows.Forms.Timer Cookie4_Mover;
    }
}