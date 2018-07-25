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
        public TeamScoreBoardWrapper (int numberOfTeams)
        {
            teamScores = new List<Team>();
            for (int i=1; i<=numberOfTeams; i++)
            {
                teamScores.Add(new Team { Name = "Team " + i, index = i, score = 0 });
            }
        }
    }

    public class Team
    {
        public String Name;
        public int index;
        public int score;
    }
}
