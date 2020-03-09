using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGameTutorial
{
    public partial class Form1_StoryText : Form
    {
        int speedText;
        public Form1_StoryText()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form1_StoryText_Load(object sender, EventArgs e)
        {
            speedText = 3;
        }

        private void Story2Continue_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4_RaceGame f4 = new Form4_RaceGame();
            f4.ShowDialog();
            this.Close();
        }

        private void Text_Mover_Tick(object sender, EventArgs e)
        {
            if (Story_Text.Top >= 56)
            {
                Story_Text.Top -= speedText;
            }
        }
    }
}
