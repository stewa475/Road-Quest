using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RacingGameTutorial
{
    public partial class Form8_SpaceGame : Form
    {
        int speed;
        int speedUPLevel = 0;
        int score = Form4_RaceGame.score;
        int cookieFuel = Form4_RaceGame.coins + 500;
        int level = Form4_RaceGame.level;
        int level4 = 2000;
        int level5 = 5000;
        int level6 = 10000000;
        int pointsPerCookie = 10;
        int pointsPerEnemy = 100;
        const int enemyCookieX = 399;
        const int cookieX = 423;
        int halfCarWidth = 26;
        int carSpaceX = 400;
        int laserPosition = 562;
        //string filePath = @"C:\Users\ASteward1\OneDrive - KNEX\Documents\Dev_Build\Project_BreakWeek\RacingGameTutorial\Rankings";
        string filePath = Directory.GetCurrentDirectory() + @"\Rankings";

        Random rnd = new Random();
        PictureBox[] space = new PictureBox[2];
        PictureBox[] enemies = new PictureBox[6];
        PictureBox[] enemies2 = new PictureBox[6];

        public Form8_SpaceGame()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form8_SpaceGame_Load(object sender, EventArgs e)
        {
            speed = 4;
            //space[0] = SpaceBack_1;
            //space[1] = SpaceBack_2;

            enemies[0] = EnemyCookie_1;
            enemies[1] = EnemyCookie_2;
            enemies[2] = EnemyCookie_3;
            enemies[3] = EnemyCookie_4;
            enemies[4] = EnemyCookie_5;
            enemies[5] = EnemyCookie_6;

            enemies2[0] = EnemyCookie_7;
            enemies2[1] = EnemyCookie_8;
            enemies2[2] = EnemyCookie_9;
            enemies2[3] = EnemyCookie_10;
            enemies2[4] = EnemyCookie_11;
            enemies2[5] = EnemyCookie_12;
        }

        //--------------------------------------------------------------------------------
        //--------------------------- GAME OVER AND REPLAY -------------------------------
        //--------------------------------------------------------------------------------
        private void GameOver()
        {
            Space_Mover.Stop();
            Score_Mover.Stop();
            EnemyCookies_Mover.Stop();
            EnemyCookies2_Mover.Stop();
            CookieFuel1_Mover.Stop();
            CookieFuel2_Mover.Stop();
            CookieFuel3_Mover.Stop();
            CookieBunch_Mover.Stop();
            LaserSpeed_Mover.Stop();
            CookiesFuel_Mover.Stop();
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
            cookieFuel = 0;
            level = 1;
            Controls.Clear();
            //Form4_RaceGame.score = 0;
            //Form4_RaceGame.coins = 0;
            //Form4_RaceGame.level = 1;
            this.Hide();
            Form4_RaceGame f4 = new Form4_RaceGame();
            f4.ShowDialog();
            this.Close();
        }

        private void MainMenu_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_MainMenu f2 = new Form2_MainMenu();
            f2.ShowDialog();
            this.Close();
        }

        private void Space_Mover_Tick(object sender, EventArgs e)
        {
            //--------------------------- SPACE MOVEMENT ----------------------------------
            //for (int i = 0; i < space.Length; i++)
            //{
            //    space[i].Top += speed*2;
            //    if (space[i].Top >= ActiveForm.Height)
            //    {
            //        space[i].Top = -space[i].Height;
            //    }
            //}

            //-------------------------- SPEED INCREMENT ---------------------------------
            if (score > level4 && score <= level5)
            {
                level = 4;
                EnemyCookie_7.Visible = true;
                EnemyCookie_8.Visible = true;
                EnemyCookie_9.Visible = true;
                EnemyCookie_10.Visible = true;
                EnemyCookie_11.Visible = true;
                EnemyCookie_12.Visible = true;
                EnemyCookies2_Mover.Start();
            }
            if (score > level5 && score <= level6)
            {
                level = 5;
                speed = 4;
            }

            //------------------ SHOWS LEVEL --------------------------------------------
            Level_Text.Text = $"Level {level}";

            //------------------------- ENEMY COOKIE INTERSECTS ----------------------------------
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_1.Bounds))
            {
                if (EnemyCookie_1.Visible == true)
                {
                    GameOver();
                }
            }
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_2.Bounds))
            {
                if (EnemyCookie_2.Visible == true)
                {
                    GameOver();
                }
            }
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_3.Bounds))
            {
                if (EnemyCookie_3.Visible == true)
                {
                    GameOver();
                }
            }
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_4.Bounds))
            {
                if (EnemyCookie_4.Visible == true)
                {
                    GameOver();
                }
            }
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_5.Bounds))
            {
                if (EnemyCookie_5.Visible == true)
                {
                    GameOver();
                }
            }
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_6.Bounds))
            {
                if (EnemyCookie_6.Visible == true)
                {
                    GameOver();
                }
            }
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_7.Bounds))
            {
                if (EnemyCookie_7.Visible == true)
                {
                    GameOver();
                }
            }
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_8.Bounds))
            {
                if (EnemyCookie_8.Visible == true)
                {
                    GameOver();
                }
            }
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_9.Bounds))
            {
                if (EnemyCookie_9.Visible == true)
                {
                    GameOver();
                }
            }
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_10.Bounds))
            {
                if (EnemyCookie_10.Visible == true)
                {
                    GameOver();
                }
            }
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_11.Bounds))
            {
                if (EnemyCookie_11.Visible == true)
                {
                    GameOver();
                }
            }
            if (Car_Space.Bounds.IntersectsWith(EnemyCookie_12.Bounds))
            {
                if (EnemyCookie_12.Visible == true)
                {
                    GameOver();
                }
            }

            //------------------------- LASER INTERSECTS ----------------------------------
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_1.Bounds))
            {
                if (EnemyCookie_1.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_1.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }

            }
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_2.Bounds))
            {
                if (EnemyCookie_2.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_2.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }
            }
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_3.Bounds))
            {
                if (EnemyCookie_3.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_3.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }
            }
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_4.Bounds))
            {
                if (EnemyCookie_4.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_4.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }
            }
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_5.Bounds))
            {
                if (EnemyCookie_5.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_5.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }
            }
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_6.Bounds))
            {
                if (EnemyCookie_6.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_6.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }
            }
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_7.Bounds))
            {
                if (EnemyCookie_7.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_7.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }
            }
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_8.Bounds))
            {
                if (EnemyCookie_8.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_8.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }
            }
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_9.Bounds))
            {
                if (EnemyCookie_9.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_9.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }
            }
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_10.Bounds))
            {
                if (EnemyCookie_10.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_10.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }
            }
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_11.Bounds))
            {
                if (EnemyCookie_11.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_11.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }
            }
            if (Car_Laser.Bounds.IntersectsWith(EnemyCookie_12.Bounds))
            {
                if (EnemyCookie_12.Visible == true)
                {
                    score += pointsPerEnemy;
                    Score_Text.Text = $"Score {score:#,###}";
                    int x = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    int y = 0;
                    EnemyCookie_12.Location = new Point(x, y);
                    Laser_Mover.Stop();
                    Car_Laser.Top = Car_Space.Location.Y;
                    Car_Laser.Left = Car_Space.Left + halfCarWidth;
                    Car_Laser.Visible = false;
                }
            }

            //----------------------------- COOKIE INTERSECTS -----------------------------
            if (Car_Space.Bounds.IntersectsWith(Cookie_1.Bounds))
            {
                cookieFuel += 5;
                score += pointsPerCookie;
                Cookies_Text.Text = $"Cookies {cookieFuel}";
                Score_Text.Text = $"Score {score:#,###}";
                int x = (int)Math.Ceiling(rnd.NextDouble() * cookieX);
                int y = 0;
                Cookie_1.Location = new Point(x, y);
            }
            if (Car_Space.Bounds.IntersectsWith(Cookie_2.Bounds))
            {
                cookieFuel += 5;
                score += pointsPerCookie;
                Cookies_Text.Text = $"Cookies {cookieFuel}";
                Score_Text.Text = $"Score {score:#,###}";
                int x = (int)Math.Ceiling(rnd.NextDouble() * cookieX);
                int y = 0;
                Cookie_2.Location = new Point(x, y);
            }
            if (Car_Space.Bounds.IntersectsWith(Cookie_3.Bounds))
            {
                cookieFuel += 5;
                score += pointsPerCookie;
                Cookies_Text.Text = $"Cookies {cookieFuel}";
                Score_Text.Text = $"Score {score:#,###}";
                int x = (int)Math.Ceiling(rnd.NextDouble() * cookieX);
                int y = 0;
                Cookie_3.Location = new Point(x, y);
            }
            if (Car_Space.Bounds.IntersectsWith(Cookie_Bunch.Bounds))
            {
                cookieFuel += 50;
                score += pointsPerCookie * 10;
                Cookies_Text.Text = $"Cookies {cookieFuel}";
                Score_Text.Text = $"Score {score:#,###}";
                int x = (int)Math.Ceiling(rnd.NextDouble() * cookieX);
                int y = 0;
                Cookie_Bunch.Location = new Point(x, y);
            }
            if (Car_Space.Bounds.IntersectsWith(SpeedUp_Laser.Bounds))
            {
                speedUPLevel++;
                score += pointsPerCookie * 10;
                Score_Text.Text = $"Score {score:#,###}";
                int x = (int)Math.Ceiling(rnd.NextDouble() * cookieX);
                int y = 0;
                SpeedUp_Laser.Location = new Point(x, y);
            }

            if (cookieFuel == 0)
            {
                GameOver();
            }
        }



        private void Form8_SpaceGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (score <= level6)
            {
                if (e.KeyCode == Keys.Right)
                {
                    Right_Mover.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    Left_Mover.Start();
                }

                if (e.KeyCode == Keys.Space)
                {
                    if (Car_Laser.Top > laserPosition)
                    {
                        Car_Laser.Left = Car_Space.Left + halfCarWidth;
                        Laser_Mover.Start();
                        Car_Laser.Visible = true;
                    }
                }
            }
        }


        private void Left_Mover_Tick(object sender, EventArgs e)
        {
            if (Car_Space.Location.X > 1)
            {
                Car_Space.Left -= 10;
            }
        }

        private void Right_Mover_Tick(object sender, EventArgs e)
        {
            if (Car_Space.Location.X < carSpaceX)
            {
                Car_Space.Left += 10;
            }
        }

        private void Form8_SpaceGame_KeyUp(object sender, KeyEventArgs e)
        {
            Right_Mover.Stop();
            Left_Mover.Stop();
        }



        private void EnemyCookies_Mover_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Top += speed/3;
                if (enemies[i].Top >= ActiveForm.Height)
                {
                    enemies[i].Left = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    enemies[i].Top = -enemies[i].Height;
                }
            }
        }
        private void EnemyCookies2_Mover_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemies2.Length; i++)
            {
                enemies2[i].Top += speed/2;
                if (enemies2[i].Top >= ActiveForm.Height)
                {
                    enemies2[i].Left = (int)Math.Ceiling(rnd.NextDouble() * enemyCookieX);
                    enemies2[i].Top = -enemies2[i].Height;
                }
            }
        }

        //-------------------- Laser Movement ------------------------------------------
        private void Laser_Mover_Tick(object sender, EventArgs e)
        {
            Car_Laser.Top -= speed + speedUPLevel;
            if (Car_Laser.Top <= 0)
            {
                Laser_Mover.Stop();
                Car_Laser.Top = Car_Space.Location.Y;
                Car_Laser.Left = Car_Space.Left + halfCarWidth;
                Car_Laser.Visible = false;
            }
        }

        private void Score_Mover_Tick(object sender, EventArgs e)
        {
            score++;
            Score_Text.Text = $"Score {score:#,###}";
        }

        private void CookiesFuel_Mover_Tick(object sender, EventArgs e)
        {
            cookieFuel--;
            Cookies_Text.Text = $"Cookies {cookieFuel:#,###}";
        }

        private void CookieFuel1_Mover_Tick(object sender, EventArgs e)
        {
            Cookie_1.Top += speed;
            if (Cookie_1.Top >= ActiveForm.Height)
            {
                Cookie_1.Top = -Cookie_1.Height;
                Cookie_1.Left = (int)Math.Ceiling(rnd.NextDouble() * cookieX);
            }
        }

        private void CookieFuel2_Mover_Tick(object sender, EventArgs e)
        {
            Cookie_2.Top += speed;
            if (Cookie_2.Top >= ActiveForm.Height)
            {
                Cookie_2.Top = -Cookie_2.Height;
                Cookie_2.Left = (int)Math.Ceiling(rnd.NextDouble() * cookieX);
            }
        }

        private void CookieFuel3_Mover_Tick(object sender, EventArgs e)
        {
            Cookie_3.Top += speed;
            if (Cookie_3.Top >= ActiveForm.Height)
            {
                Cookie_3.Top = -Cookie_3.Height;
                Cookie_3.Left = (int)Math.Ceiling(rnd.NextDouble() * cookieX);
            }
        }

        private void CookieBunch_Mover_Tick(object sender, EventArgs e)
        {
            Cookie_Bunch.Top += speed / 2;
            if (Cookie_Bunch.Top >= ActiveForm.Height)
            {
                Cookie_Bunch.Top = -Cookie_Bunch.Height;
                Cookie_Bunch.Left = (int)Math.Ceiling(rnd.NextDouble() * cookieX);
            }
        }

        private void LaserSpeed_Mover_Tick(object sender, EventArgs e)
        {
            SpeedUp_Laser.Top += speed / 3;
            if (SpeedUp_Laser.Top >= ActiveForm.Height)
            {
                SpeedUp_Laser.Top = -SpeedUp_Laser.Height;
                SpeedUp_Laser.Left = (int)Math.Ceiling(rnd.NextDouble() * cookieX);
            }
        }


    }
}
