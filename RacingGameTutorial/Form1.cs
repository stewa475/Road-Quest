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

namespace RacingGameTutorial
{
    public partial class Form1 : Form
    {
        int speed;
        int level = 1;
        int score = 0;
        int coins = 0;
        Random rnd = new Random();
        PictureBox[] road = new PictureBox[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //--------------------------------------------------------------------------------
        //---------------------------------- FORM1 ---------------------------------------
        //--------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            speed = 2;
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
        public void MainMenu()
        {
            MainMenu_Title.Visible = true;
            MainMenu_Car.Visible = true;
            Play_Button.Visible = true;
            MainMenu_Box.Visible = true;
            MainMenu_Button.Visible = false;
            Replay_Button.Visible = false;
            End_Text.Visible = false;
        }
        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            MainMenu();
        }

        private void Play_Button_Click(object sender, EventArgs e)
        {
            score = 0;
            coins = 0;
            level = 1;
            Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
            MainMenu_Box.Visible = false;
            MainMenu_Title.Visible = false;
            MainMenu_Car.Visible = false;
            Play_Button.Visible = false;
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
            if (score > 1000 && score <= 10000)
            {
                speed = 3;
                level = 2;
            }
            if (score > 10000 && score <= 100000)
            {
                speed = 4;
                level = 3;
            }

            //---------------------------- COOKIE START ----------------------------------
            if (score <= 50)
            {
                Coin1_Mover.Stop();
                Coin2_Mover.Stop();
                Coin3_Mover.Stop();
            }
            if (score > 50)
            {
                Coin1.Visible = true;
                Coin2.Visible = true;
                Coin3.Visible = true;
                Coin1_Mover.Start();
                Coin2_Mover.Start();
                Coin3_Mover.Start();
            }

            //------------------ SHOWS SPEED --------------------------------------------
            Speed_Text.Text = $"Speed {speed}";

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
                score+=100;
                Coins_Text.Text = $"Cookies {coins}";
                Score_Text.Text = $"Score {score:#,###}";
                int x = (int)Math.Ceiling(rnd.NextDouble() * 190);
                int y = 0;
                Coin1.Location = new Point(x, y);
            }
            if (Car.Bounds.IntersectsWith(Coin2.Bounds))
            {
                coins++;
                score+=100;
                Coins_Text.Text = $"Cookies {coins}";
                Score_Text.Text = $"Score {score:#,###}";
                int x = (int)Math.Ceiling(rnd.NextDouble() * 190);
                int y = 0;
                Coin2.Location = new Point(x, y);
            }
            if (Car.Bounds.IntersectsWith(Coin3.Bounds))
            {
                coins++;
                score+=100;
                Coins_Text.Text = $"Cookies {coins}";
                Score_Text.Text = $"Score {score:#,###}";
                int x = (int)Math.Ceiling(rnd.NextDouble() * 190);
                int y = 0;
                Coin3.Location = new Point(x, y);
            }
        }

        //--------------------------------------------------------------------------------
        //--------------------------- GAME OVER AND REPLAY -------------------------------
        //--------------------------------------------------------------------------------
        private void GameOver()
        {
            Replay_Button.Visible = true;
            End_Text.Visible = true;
            RoadMover.Stop();
            Enemy1_Mover.Stop();
            Enemy2_Mover.Stop();
            Enemy3_Mover.Stop();
            Coin1_Mover.Stop();
            Coin2_Mover.Stop();
            Coin3_Mover.Stop();
            Score_Timer.Stop();
            MainMenu_Button.Visible = true;
        }

        private void Replay_Button_Click(object sender, EventArgs e)
        {
            Play_Button_Click(e, e);
        }

        //--------------------------------------------------------------------------------
        //------------------------ LEFT AND RIGHT MOVEMENT MAIN CAR ----------------------
        //--------------------------------------------------------------------------------
        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        private void Right_mover_Tick(object sender, EventArgs e)
        {
            if (Car.Location.X < 191)
            {
                Car.Left += 5;
            }
        }

        private void Left_mover_Tick(object sender, EventArgs e)
        {
            if (Car.Location.X > 1)
            {
                Car.Left -= 5;
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
                EnemyCar1.Left = ((int)Math.Ceiling(rnd.NextDouble() * 50)) + 0;
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
                EnemyCar2.Left = ((int)Math.Ceiling(rnd.NextDouble() * 50)) + 75;
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
                EnemyCar3.Left = ((int)Math.Ceiling(rnd.NextDouble() * 50)) + 140;
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
                Coin1.Left = (int)Math.Ceiling(rnd.NextDouble() * 190);
            }
        }

        private void Coin2_Mover_Tick(object sender, EventArgs e)
        {
            Coin2.Top += speed;
            if (Coin2.Top >= ActiveForm.Height)
            {
                Coin2.Top = -Coin2.Height;
                Coin2.Left = (int)Math.Ceiling(rnd.NextDouble() * 190);
            }
        }

        private void Coin3_Mover_Tick(object sender, EventArgs e)
        {
            Coin3.Top += speed;
            if (Coin3.Top >= ActiveForm.Height)
            {
                Coin3.Top = -Coin3.Height;
                Coin3.Left = (int)Math.Ceiling(rnd.NextDouble() * 190);
            }
        }

        private void Score_Timer_Tick(object sender, EventArgs e)
        {
            score++;
            Score_Text.Text = $"Score {score:#,###}";
        }
    }
}
