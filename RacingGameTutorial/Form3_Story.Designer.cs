namespace RacingGameTutorial
{
    partial class Form3_Story
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
            this.Story_Title = new System.Windows.Forms.Label();
            this.StoryContinue_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Story_Title
            // 
            this.Story_Title.AutoSize = true;
            this.Story_Title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Story_Title.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Story_Title.Location = new System.Drawing.Point(32, 203);
            this.Story_Title.Name = "Story_Title";
            this.Story_Title.Size = new System.Drawing.Size(162, 24);
            this.Story_Title.TabIndex = 0;
            this.Story_Title.Text = "Not long ago...";
            // 
            // StoryContinue_Button
            // 
            this.StoryContinue_Button.BackColor = System.Drawing.Color.Black;
            this.StoryContinue_Button.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.StoryContinue_Button.FlatAppearance.BorderSize = 10;
            this.StoryContinue_Button.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoryContinue_Button.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.StoryContinue_Button.Location = new System.Drawing.Point(283, 704);
            this.StoryContinue_Button.Name = "StoryContinue_Button";
            this.StoryContinue_Button.Size = new System.Drawing.Size(178, 54);
            this.StoryContinue_Button.TabIndex = 1;
            this.StoryContinue_Button.Text = "Continue";
            this.StoryContinue_Button.UseVisualStyleBackColor = false;
            this.StoryContinue_Button.Click += new System.EventHandler(this.StoryContinue_Button_Click);
            // 
            // Form3_Story
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 761);
            this.Controls.Add(this.StoryContinue_Button);
            this.Controls.Add(this.Story_Title);
            this.MaximumSize = new System.Drawing.Size(480, 800);
            this.MinimumSize = new System.Drawing.Size(480, 800);
            this.Name = "Form3_Story";
            this.Text = "Form3_Story";
            this.Load += new System.EventHandler(this.Form3_Story_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Story_Title;
        private System.Windows.Forms.Button StoryContinue_Button;
    }
}