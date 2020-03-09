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
    public partial class Form3_Story : Form
    {
        public Form3_Story()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form3_Story_Load(object sender, EventArgs e)
        {
            Story_Title.Text = "Not long ago on a road somewhat far,\nfar away...";
        }

        private void StoryContinue_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1_StoryText f1 = new Form1_StoryText();
            f1.ShowDialog();
            this.Close();
        }
    }
}
