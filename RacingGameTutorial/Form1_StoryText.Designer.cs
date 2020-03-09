namespace RacingGameTutorial
{
    partial class Form1_StoryText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_StoryText));
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.Story2Continue_Button = new System.Windows.Forms.Button();
            this.Text_Mover = new System.Windows.Forms.Timer(this.components);
            this.Story_Text = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Story_Text)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Black;
            this.pictureBox9.Location = new System.Drawing.Point(-14, 693);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(492, 72);
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // Story2Continue_Button
            // 
            this.Story2Continue_Button.BackColor = System.Drawing.Color.Black;
            this.Story2Continue_Button.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.Story2Continue_Button.FlatAppearance.BorderSize = 10;
            this.Story2Continue_Button.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Story2Continue_Button.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Story2Continue_Button.Location = new System.Drawing.Point(281, 701);
            this.Story2Continue_Button.Name = "Story2Continue_Button";
            this.Story2Continue_Button.Size = new System.Drawing.Size(178, 54);
            this.Story2Continue_Button.TabIndex = 9;
            this.Story2Continue_Button.Text = "Continue";
            this.Story2Continue_Button.UseVisualStyleBackColor = false;
            this.Story2Continue_Button.Click += new System.EventHandler(this.Story2Continue_Button_Click);
            // 
            // Text_Mover
            // 
            this.Text_Mover.Enabled = true;
            this.Text_Mover.Tick += new System.EventHandler(this.Text_Mover_Tick);
            // 
            // Story_Text
            // 
            this.Story_Text.Image = ((System.Drawing.Image)(resources.GetObject("Story_Text.Image")));
            this.Story_Text.Location = new System.Drawing.Point(67, 701);
            this.Story_Text.Name = "Story_Text";
            this.Story_Text.Size = new System.Drawing.Size(328, 556);
            this.Story_Text.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Story_Text.TabIndex = 10;
            this.Story_Text.TabStop = false;
            // 
            // Form1_StoryText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 761);
            this.Controls.Add(this.Story2Continue_Button);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.Story_Text);
            this.MaximumSize = new System.Drawing.Size(480, 800);
            this.MinimumSize = new System.Drawing.Size(480, 800);
            this.Name = "Form1_StoryText";
            this.Text = "Form1_StoryText";
            this.Load += new System.EventHandler(this.Form1_StoryText_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Story_Text)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button Story2Continue_Button;
        private System.Windows.Forms.Timer Text_Mover;
        private System.Windows.Forms.PictureBox Story_Text;
    }
}