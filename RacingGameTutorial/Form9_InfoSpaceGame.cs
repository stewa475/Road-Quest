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
    public partial class Form9_InfoSpaceGame : Form
    {
        public Form9_InfoSpaceGame()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Info_ContButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8_SpaceGame f8 = new Form8_SpaceGame();
            f8.ShowDialog();
            this.Close();
        }
    }
}
