namespace RacingGameTutorial
{
    partial class Form6_GetName
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
            this.GetName_Title = new System.Windows.Forms.Label();
            this.GetName_Input = new System.Windows.Forms.TextBox();
            this.GetName_ContButton = new System.Windows.Forms.Button();
            this.GetName_AddPlayer = new System.Windows.Forms.Button();
            this.GetName_Welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetName_Title
            // 
            this.GetName_Title.AutoSize = true;
            this.GetName_Title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetName_Title.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.GetName_Title.Location = new System.Drawing.Point(138, 192);
            this.GetName_Title.Name = "GetName_Title";
            this.GetName_Title.Size = new System.Drawing.Size(170, 33);
            this.GetName_Title.TabIndex = 0;
            this.GetName_Title.Text = "Enter Name";
            // 
            // GetName_Input
            // 
            this.GetName_Input.BackColor = System.Drawing.Color.Black;
            this.GetName_Input.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetName_Input.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.GetName_Input.Location = new System.Drawing.Point(122, 263);
            this.GetName_Input.Name = "GetName_Input";
            this.GetName_Input.Size = new System.Drawing.Size(200, 33);
            this.GetName_Input.TabIndex = 1;
            this.GetName_Input.TextChanged += new System.EventHandler(this.GetName_Input_TextChanged);
            // 
            // GetName_ContButton
            // 
            this.GetName_ContButton.BackColor = System.Drawing.Color.Black;
            this.GetName_ContButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.GetName_ContButton.FlatAppearance.BorderSize = 10;
            this.GetName_ContButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetName_ContButton.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.GetName_ContButton.Location = new System.Drawing.Point(284, 705);
            this.GetName_ContButton.Name = "GetName_ContButton";
            this.GetName_ContButton.Size = new System.Drawing.Size(178, 54);
            this.GetName_ContButton.TabIndex = 2;
            this.GetName_ContButton.Text = "Continue";
            this.GetName_ContButton.UseVisualStyleBackColor = false;
            this.GetName_ContButton.Visible = false;
            this.GetName_ContButton.Click += new System.EventHandler(this.GetName_ContButton_Click);
            // 
            // GetName_AddPlayer
            // 
            this.GetName_AddPlayer.BackColor = System.Drawing.Color.Black;
            this.GetName_AddPlayer.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetName_AddPlayer.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.GetName_AddPlayer.Location = new System.Drawing.Point(133, 326);
            this.GetName_AddPlayer.Name = "GetName_AddPlayer";
            this.GetName_AddPlayer.Size = new System.Drawing.Size(178, 54);
            this.GetName_AddPlayer.TabIndex = 3;
            this.GetName_AddPlayer.Text = "Create";
            this.GetName_AddPlayer.UseVisualStyleBackColor = false;
            this.GetName_AddPlayer.Click += new System.EventHandler(this.GetName_AddPlayer_Click);
            // 
            // GetName_Welcome
            // 
            this.GetName_Welcome.AutoSize = true;
            this.GetName_Welcome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetName_Welcome.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.GetName_Welcome.Location = new System.Drawing.Point(127, 492);
            this.GetName_Welcome.Name = "GetName_Welcome";
            this.GetName_Welcome.Size = new System.Drawing.Size(0, 24);
            this.GetName_Welcome.TabIndex = 4;
            // 
            // Form6_GetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 761);
            this.Controls.Add(this.GetName_Welcome);
            this.Controls.Add(this.GetName_AddPlayer);
            this.Controls.Add(this.GetName_ContButton);
            this.Controls.Add(this.GetName_Input);
            this.Controls.Add(this.GetName_Title);
            this.MaximumSize = new System.Drawing.Size(480, 800);
            this.MinimumSize = new System.Drawing.Size(480, 800);
            this.Name = "Form6_GetName";
            this.Text = "Form6_GetName";
            this.Load += new System.EventHandler(this.Form6_GetName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GetName_Title;
        private System.Windows.Forms.TextBox GetName_Input;
        private System.Windows.Forms.Button GetName_ContButton;
        private System.Windows.Forms.Button GetName_AddPlayer;
        private System.Windows.Forms.Label GetName_Welcome;
    }
}