using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGameTutorial
{
    public partial class Form6_GetName : Form
    {
        public static string playerName;

        public Form6_GetName()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form6_GetName_Load(object sender, EventArgs e)
        {
            
        }

        private void GetName_ContButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3_Story f3 = new Form3_Story();
            f3.ShowDialog();
            this.Close();
        }

        private void GetName_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetName_AddPlayer_Click(object sender, EventArgs e)
        {
            if (GetName_Input.Text.Length > 10)
            {
                GetName_Welcome.Text = $"Name is too long..";
                GetName_Input.Text = "";
            }
            else if (GetName_Input.Text.Length < 1)
            {
                GetName_Welcome.Text = $"Name must be provided..";
                GetName_Input.Text = "";
            }
            else if (GetName_Input.Text.Contains(" ") || GetName_Input.Text.Contains(","))
            {
                GetName_Welcome.Text = $"Name may not have\nspaces or commas..";
                GetName_Input.Text = "";
            }
            else
            {
                playerName = GetName_Input.Text;
                GetName_Welcome.Text = $"Welcome {playerName}!";
                GetName_ContButton.Visible = true;
            }
        }
    }
}
