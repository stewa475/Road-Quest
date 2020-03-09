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
    public partial class Form7_Grandpa : Form
    {
        public Form7_Grandpa()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form7_Grandpa_Load(object sender, EventArgs e)
        {

        }

        private void Grandpa_ContButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9_InfoSpaceGame f9 = new Form9_InfoSpaceGame();
            f9.ShowDialog();
            this.Close();
        }
    }
}
