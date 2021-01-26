using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8_Voting_System
{
    class Vote
    {
        private string VoterName;
        private string PartyName;
        private DateTime TimeVoted;

        private static int TotalVotes;

        public Vote(string VoterName, string PartyName)
        {
            this.VoterName = VoterName;
            this.PartyName = PartyName;
            TimeVoted = DateTime.Now;
            TotalVotes += 1;
            
        }
        // ACCESSORS
        public string GetVoterParty()
        {
            return PartyName;
        }
        public DateTime GetTimeVoted()
        {
            return TimeVoted;
        }
        public static int GetTotalVotes()
        {
            return TotalVotes;
        }

        //MUTATORS
    }
}
