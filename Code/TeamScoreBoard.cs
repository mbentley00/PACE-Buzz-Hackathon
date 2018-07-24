using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACEBuzz
{
    public class TeamScoreBoardWrapper
    {
        public List<Team> teamScores;
        private int index;
        public TeamScoreBoardWrapper ()
        {
            index = 0;
            teamScores = new List<Team>();
            teamScores.Add(new Team { Name = "Team A", index = this.index++, score = 0 });
            teamScores.Add(new Team { Name = "Team B", index = this.index++, score = 0 });
            teamScores.Add(new Team { Name = "Team C", index = this.index++, score = 0 });
            teamScores.Add(new Team { Name = "Team D", index = this.index++, score = 0 });
            teamScores.Add(new Team { Name = "Team E", index = this.index++, score = 0 });
        }
    }

    public class Team
    {
        public String Name;
        public int index;
        public int score;
    }
}
