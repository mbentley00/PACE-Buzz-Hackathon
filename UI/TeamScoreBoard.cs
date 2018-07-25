using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PACEBuzz
{
    public partial class TeamScoreBoard : Form
    {
        TableLayoutPanel panel;
        public TeamScoreBoard(TeamScoreBoardWrapper ts)
        {
            InitializeComponent();

            panel= new TableLayoutPanel();
            this.Controls.Clear();
            //from ts, populate labels on the form
            panel.ColumnCount = 2;
            panel.RowCount = 1;
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            panel.Controls.Add(new Label() { Text = "Team Name" }, 0, 0);
            panel.Controls.Add(new Label() { Text = "Score" }, 1, 0);

            //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            foreach (var score in ts.teamScores)
            {
                panel.RowCount++;
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                panel.Controls.Add(new Label() { Text = score.Name, AutoSize = true },0, panel.RowCount-1);
                panel.Controls.Add(new Label()
                {
                    Text = score.score.ToString(),
                    AutoSize = true
                }, 1, panel.RowCount-1);
                

                ;
            }

            this.Controls.Add(panel);
        }

        public void UpdateScore(int teamId, int newScore)
        {
            //panel;
            //update 4 + 2n
            Label l = panel.Controls[3 + 2 * teamId] as Label;
            l.Text = newScore.ToString();
        }
    }
}
