using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RacingGameTutorial
{
    public partial class Form4_RaceGame : Form
    {
        int cookiesSpawn = 50;
        int level2 = 500;
        int level3 = 1000;
        int speedToNextArea = 30;
        int pointsPerCookie = 100;
        int coinsX = 423;
        int carsX = 400;
        int grandpaY = 220;

        int speed;
        public static int level;
        public static int score;
        public static int coins;
        Random rnd = new Random();
        PictureBox[] road = new PictureBox[8];
        //string filePath = @"C:\Users\ASteward1\OneDrive - KNEX\Documents\Dev_Build\Project_BreakWeek\RacingGameTutorial\Rankings";
        string filePath = Directory.GetCurrentDirectory() + @"\Rankings";

        public Form4_RaceGame()
        {
            StartPosition = FormStartPosition.CenterScreen;
            level = 1;
            score = 0;
            coins = 0;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------
        //---------------------------------- FORM1 ---------------------------------------
        //--------------------------------------------------------------------------------
        private void Form4_RaceGame_Load(object sender, EventArgs e)
        {
            speed = 4;
            road[0] = pictureBox1;
            road[1] = pictureBox2;
            road[2] = pictureBox3;
            road[3] = pictureBox4;
            road[4] = pictureBox5;
            road[5] = pictureBox6;
            road[6] = pictureBox7;
            road[7] = pictureBox8;
        }

        //--------------------------------------------------------------------------------
        //--------------------------------- MAIN MENUE -----------------------------------
        //--------------------------------------------------------------------------------
        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_MainMenu f2 = new Form2_MainMenu();
            f2.ShowDialog();
            this.Close();
        }

        //--------------------------------------------------------------------------------
        //-------------------------------- ROAD GAME -------------------------------------
        //--------------------------------------------------------------------------------
        private void RoadMover_Tick(object sender, EventArgs e)
        {
            //--------------------------- ROAD MOVEMENT ----------------------------------
            for (int i = 0; i < road.Length; i++)
            {
                road[i].Top += speed;
                if (road[i].Top >= ActiveForm.Height)
                {
                    road[i].Top = -road[i].Height;
                }
            }

            //-------------------------- SPEED INCREMENT ---------------------------------
            if (score > level2 && score <= level3)
            {
                speed = 5;
                level = 2;
            }
            if (score > level3 && speed <= speedToNextArea)
            {
                speed++;
                level = 3;
                Score_Timer.Stop();
                Enemy1_Mover.Stop();
                Enemy2_Mover.Stop();
                Enemy3_Mover.Stop();
                Coin1_Mover.Stop();
                Coin2_Mover.Stop();
                Coin3_Mover.Stop();
                Left_mover.Stop();
                Right_mover.Stop();
                EnemyCar1.Visible = false;
                EnemyCar2.Visible = false;
                EnemyCar3.Visible = false;
                Coin1.Visible = false;
                Coin2.Visible = false;
                Coin3.Visible = false;
                Grandpa_Mover.Start();
                GrandpaCar.Visible = true;
            }

            //---------------------------- COOKIE START ----------------------------------
            if (score > cookiesSpawn && score <= level3)
            {
                Coin1.Visible = true;
                Coin2.Visible = true;
                Coin3.Visible = true;
                Coin1_Mover.Start();
                Coin2_Mover.Start();
                Coin3_Mover.Start();
            }

            //------------------ SHOWS LEVEL --------------------------------------------
            Level_Text.Text = $"Level {level}";

            //------------------------- CAR INTERSECTS ----------------------------------
            if (Car.Bounds.IntersectsWith(EnemyCar1.Bounds))
            {
                GameOver();
            }
            if (Car.Bounds.IntersectsWith(EnemyCar2.Bounds))
            {
                GameOver();
            }
            if (Car.Bounds.IntersectsWith(EnemyCar3.Bounds))
            {
                GameOver();
            }

            //----------------------------- COIN INTERSECTS -----------------------------
            if (Car.Bounds.IntersectsWith(Coin1.Bounds))
            {
                coins++;
                score += pointsPerCookie;
                Coins_Text.Text = $"Cookies {coins}";
                Score_Text.Text = $"Score {score:#,###}";
                int x = (int)Math.Ceiling(rnd.NextDouble() * coinsX);
                int y = 0;
                Coin1.Location = new Point(x, y);
            }
            if (Car.Bounds.IntersectsWith(Coin2.Bounds))
            {
                coins++;
                score += pointsPerCookie;
                Coins_Text.Text = $"Cookies {coins}";
                Score_Text.Text = $"Score {score:#,###}";
                int x = (int)Math.Ceiling(rnd.NextDouble() * coinsX);
                int y = 0;
                Coin2.Location = new Point(x, y);
            }
            if (Car.Bounds.IntersectsWith(Coin3.Bounds))
            {
                coins++;
                score += pointsPerCookie;
                Coins_Text.Text = $"Cookies {coins}";
                Score_Text.Text = $"Score {score:#,###}";
                int x = (int)Math.Ceiling(rnd.NextDouble() * coinsX);
                int y = 0;
                Coin3.Location = new Point(x, y);
            }
        }

        //--------------------------------------------------------------------------------
        //--------------------------- GAME OVER AND REPLAY -------------------------------
        //--------------------------------------------------------------------------------
        private void GameOver()
        {
            RoadMover.Stop();
            Score_Timer.Stop();
            Enemy1_Mover.Stop();
            Enemy2_Mover.Stop();
            Enemy3_Mover.Stop();
            Coin1_Mover.Stop();
            Coin2_Mover.Stop();
            Coin3_Mover.Stop();
            End_Text.Visible = true;
            Replay_Button.Visible = true;
            MainMenu_Button.Visible = true;
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine($"{Form6_GetName.playerName},{score}");
                sw.Close();
            }
        }

        private void Replay_Button_Click(object sender, EventArgs e)
        {
            score = 0;
            coins = 0;
            level = 1;
            Controls.Clear();
            InitializeComponent();
            Form4_RaceGame_Load(e, e);
        }

        //--------------------------------------------------------------------------------
        //------------------------ LEFT AND RIGHT MOVEMENT MAIN CAR ----------------------
        //--------------------------------------------------------------------------------
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (score <= level3)
            {
                if (e.KeyCode == Keys.Right)
                {
                    Right_mover.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    Left_mover.Start();
                }
            }
        }

        private void Right_mover_Tick(object sender, EventArgs e)
        {
            if (Car.Location.X < carsX)
            {
                Car.Left += 10;
            }
        }

        private void Left_mover_Tick(object sender, EventArgs e)
        {
            if (Car.Location.X > 1)
            {
                Car.Left -= 10;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Right_mover.Stop();
            Left_mover.Stop();
        }

        //--------------------------------------------------------------------------------
        //----------------------------- ENEMY CAR MOVEMENT -------------------------------
        //--------------------------------------------------------------------------------
        private void Enemy1_Mover_Tick(object sender, EventArgs e)
        {
            EnemyCar1.Top += speed / 2;
            if (EnemyCar1.Top >= ActiveForm.Height)
            {
                score += 1;
                Score_Text.Text = $"Score {score:#,###}";
                //EnemyCar1.Top = -((int)Math.Ceiling(rnd.NextDouble() * 500)) + EnemyCar1.Height;
                EnemyCar1.Top = -EnemyCar1.Height;
                EnemyCar1.Left = ((int)Math.Ceiling(rnd.NextDouble() * 100)) + 0;
            }
        }

        private void Enemy2_Mover_Tick(object sender, EventArgs e)
        {
            EnemyCar2.Top += speed;
            if (EnemyCar2.Top >= ActiveForm.Height)
            {
                score += 1;
                Score_Text.Text = $"Score {score:#,###}";
                EnemyCar2.Top = -EnemyCar2.Height;
                EnemyCar2.Left = ((int)Math.Ceiling(rnd.NextDouble() * 100)) + 150;
            }
        }

        private void Enemy3_Mover_Tick(object sender, EventArgs e)
        {
            EnemyCar3.Top += speed * 3 / 2;
            if (EnemyCar3.Top >= ActiveForm.Height)
            {
                score += 1;
                Score_Text.Text = $"Score {score:#,###}";
                EnemyCar3.Top = -EnemyCar3.Height;
                EnemyCar3.Left = ((int)Math.Ceiling(rnd.NextDouble() * 100)) + 301;
            }
        }

        //--------------------------------------------------------------------------------
        //------------------------------- COINS MOVEMENT ---------------------------------
        //--------------------------------------------------------------------------------
        private void Coin1_Mover_Tick(object sender, EventArgs e)
        {
            Coin1.Top += speed;
            if (Coin1.Top >= ActiveForm.Height)
            {
                Coin1.Top = -Coin1.Height;
                Coin1.Left = (int)Math.Ceiling(rnd.NextDouble() * coinsX);
            }
        }

        private void Coin2_Mover_Tick(object sender, EventArgs e)
        {
            Coin2.Top += speed;
            if (Coin2.Top >= ActiveForm.Height)
            {
                Coin2.Top = -Coin2.Height;
                Coin2.Left = (int)Math.Ceiling(rnd.NextDouble() * coinsX);
            }
        }

        private void Coin3_Mover_Tick(object sender, EventArgs e)
        {
            Coin3.Top += speed;
            if (Coin3.Top >= ActiveForm.Height)
            {
                Coin3.Top = -Coin3.Height;
                Coin3.Left = (int)Math.Ceiling(rnd.NextDouble() * coinsX);
            }
        }

        private void Score_Timer_Tick(object sender, EventArgs e)
        {
            score++;
            Score_Text.Text = $"Score {score:#,###}";
        }

        private void Grandpa_Mover_Tick(object sender, EventArgs e)
        {
            if (GrandpaCar.Top <= grandpaY)
            {
                GrandpaCar.Top += speed/30;
            }
            if (GrandpaCar.Top == grandpaY)
            {
                RaceGame_Grandpa.Text = $"{Form6_GetName.playerName}, get in if you\nwant any chance of\neating fresh out of\nthe oven cookies!!";
                RaceGame_Grandpa.Visible = true;
                RaceGame_ContButton.Visible = true;
            }
        }

        private void RaceGame_ContButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7_Grandpa f7 = new Form7_Grandpa();
            f7.ShowDialog();
            this.Close();
        }
    }
}
