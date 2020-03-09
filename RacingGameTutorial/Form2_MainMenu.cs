using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace RacingGameTutorial
{
    public partial class Form2_MainMenu : Form
    {
        int speed = 3;
        Random rnd = new Random();
        public SoundPlayer player = new SoundPlayer();
        public Form2_MainMenu()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            //player.SoundLocation = @"C:\Users\ASteward1\OneDrive - Knex\Documents\Dev_Build\Project_BreakWeek\RacingGameTutorial\Song_Main.wav";
            player.SoundLocation = Directory.GetCurrentDirectory() + @"\Song_Main.wav";

            player.PlayLooping();
        }

        private void Form2_MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void Play_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6_GetName f6 = new Form6_GetName();
            f6.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5_Rankings f5 = new Form5_Rankings();
            f5.ShowDialog();
            this.Close();
        }

        private void MainMenu_Music_Click(object sender, EventArgs e)
        {
            if (MainMenu_Music.Text == "Music On")
            {
                MainMenu_Music.Text = "Music Off";
                player.PlayLooping();
            }
            else if (MainMenu_Music.Text == "Music Off")
            {
                MainMenu_Music.Text = "Music On";
                player.Stop();
            }
            
        }

        private void Cookie1_Mover_Tick(object sender, EventArgs e)
        {
            Cookie1.Top += speed/2;
            if (Cookie1.Top >= ActiveForm.Height)
            {
                Cookie1.Top = -Cookie1.Height;
                Cookie1.Left = (int)Math.Ceiling(rnd.NextDouble() * 190);
            }
        }

        private void Cookie2_Mover_Tick(object sender, EventArgs e)
        {
            Cookie2.Top += speed/2;
            if (Cookie2.Top >= ActiveForm.Height)
            {
                Cookie2.Top = -Cookie2.Height;
                Cookie2.Left = (int)Math.Ceiling(rnd.NextDouble() * 190);
            }
        }

        private void Cookie3_Mover_Tick(object sender, EventArgs e)
        {
            Cookie3.Top += speed/2;
            if (Cookie3.Top >= ActiveForm.Height)
            {
                Cookie3.Top = -Cookie3.Height;
                Cookie3.Left = (int)Math.Ceiling(rnd.NextDouble() * 190);
            }
        }

        private void Cookie4_Mover_Tick(object sender, EventArgs e)
        {
            Cookie4.Top += speed / 2;
            if (Cookie4.Top >= ActiveForm.Height)
            {
                Cookie4.Top = -Cookie4.Height;
                Cookie4.Left = (int)Math.Ceiling(rnd.NextDouble() * 190);
            }
        }
    }
}
