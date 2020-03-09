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
    public partial class Form5_Rankings : Form
    {
        string filePath;
        int speed = 3;
        Random rnd = new Random();
        List<Player> players = new List<Player>();
        public Form5_Rankings()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form5_Rankings_Load(object sender, EventArgs e)
        {
            ListRankings();
        }

        //Sorting Player list
        public void SortPlayers()
        {
            players.Sort(delegate (Player p1, Player p2)
            {
                return int.Parse(p2.ScoreRank).CompareTo(int.Parse(p1.ScoreRank));
            });
        }

        //--------------------------------------------------------------------------------
        //--------------------------------- RANKINGS -------------------------------------
        //--------------------------------------------------------------------------------
        private void ListRankings()
        {
            //filePath = @"C:\Users\ASteward1\OneDrive - KNEX\Documents\Dev_Build\Project_BreakWeek\RacingGameTutorial\Rankings";
            filePath = Directory.GetCurrentDirectory() + @"\Rankings";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            StringBuilder list = new StringBuilder();
            List<string> names = new List<string>();

            //Pulling players from txt file and adding them to Player list
            foreach (var l in lines)
            {
                string[] entries = l.Split(',');
                Player newPlayer = new Player();

                newPlayer.Name = entries[0];
                newPlayer.ScoreRank = entries[1];

                players.Add(newPlayer);
            }

            //Building the print string
            //delete duplicates once there are accounts
            if (lines.Count <= 10)
            {
                SortPlayers();
                for (int i = 0; i < lines.Count; i++)
                {
                    names.Add(players[i].Name);
                    list.Append($"{players[i].Name}  {int.Parse(players[i].ScoreRank):#,###}\n");
                    //if (!names.Contains(players[i].Name))
                    //{

                    //}
                }
            }
            else
            {
                SortPlayers();
                for (int i = 0; i < 10; i++)
                {
                    names.Add(players[i].Name);
                    list.Append($"{players[i].Name}   {int.Parse(players[i].ScoreRank):#,###}\n");
                    //if (!names.Contains(players[i].Name))
                    //{

                    //}
                }
            }

            //Printing to the Rankings_List lable
            Rankings_List.Text = list.ToString();
        }

        private void RankingsMM_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2_MainMenu f2 = new Form2_MainMenu();
            f2.ShowDialog();
            this.Close();
        }

        private void Cookie1_Mover_Tick(object sender, EventArgs e)
        {
            Cookie1.Top += speed / 2;
            if (Cookie1.Top >= ActiveForm.Height)
            {
                Cookie1.Top = -Cookie1.Height;
                Cookie1.Left = (int)Math.Ceiling(rnd.NextDouble() * 190);
            }
        }

        private void Cookie2_Mover_Tick(object sender, EventArgs e)
        {
            Cookie2.Top += speed / 2;
            if (Cookie2.Top >= ActiveForm.Height)
            {
                Cookie2.Top = -Cookie2.Height;
                Cookie2.Left = (int)Math.Ceiling(rnd.NextDouble() * 190);
            }
        }

        private void Cookie3_Mover_Tick(object sender, EventArgs e)
        {
            Cookie3.Top += speed / 2;
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
