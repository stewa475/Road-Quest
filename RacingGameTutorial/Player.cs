using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGameTutorial
{
    public class Player
    {
        private string name;
        private string scoreRank;

        public string Name { get => name; set => name = value; }
        public string ScoreRank { get => scoreRank; set => scoreRank = value; }
    }
}
