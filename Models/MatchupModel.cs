using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The set of teams that were involved in this match
        /// </summary
        public List<MatchupEntryModel> Entries { get; set; }

        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Which round this match is part of 
        /// </summary>
        public int MatchRound { get; set; }

    }
}
