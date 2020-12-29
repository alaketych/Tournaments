using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    class Matchup {
        public int Id { get; set; }
        public int WinnerId { get; set; }
        public Team Winner { get; set; }
        public int MatchupRound { get; set; }
        public List<MatchupEntry> Entries { get; set; } = new List<MatchupEntry>();

        public string DisplayName {
            get {
                string output = "";

                foreach (MatchupEntry me in Entries) {
                    if (me.TeamCompeting != null) {
                        if (output.Length == 0) {
                            output = me.TeamCompeting.TeamName;
                        }
                        else {
                            output += $" vs. { me.TeamCompeting.TeamName }";
                        }
                    }
                    else {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }

                return output;
            }
        }
    }
}
