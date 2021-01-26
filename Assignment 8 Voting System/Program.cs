using System;

namespace Assignment_8_Voting_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Vote[] Votes = new Vote[1000000];

            CastVotes(Votes);
        }

        static int VoteNumber = 0;
        static int VotesForDemo = 0;
        static int VotesForCom = 0;
        static int VotesForFas = 0;

        static void CastVotes(Vote[] Votes)
        {
            Console.WriteLine("Enter Name");
            string VoterName = Console.ReadLine();
            Console.WriteLine("1 for Demo, 2 for Com, 3 for Fas");
            string Voted = Console.ReadLine();
            while (Voted != "0")
            {
                if (Voted == "1")
                {
                    Votes[VoteNumber] = new Vote(VoterName,"Democrat");
                    VotesForDemo += 1;
                }
                else if (Voted == "2")
                {
                    Votes[VoteNumber] = new Vote(VoterName, "Communist");
                    VotesForCom += 1;
                }
                else if (Voted == "3")
                {
                    Votes[VoteNumber] = new Vote(VoterName, "Fascist");
                    VotesForFas += 1;
                }
                else
                {
                    Console.WriteLine("Enter 1,2 or 3 pls");
                    Voted = Console.
                }
                Console.WriteLine("Enter Name");
                VoterName = Console.ReadLine();
                Console.WriteLine("1 for Demo, 2 for Com, 3 for Fas");
                Voted = Console.ReadLine();
            }
            Console.WriteLine("Exit");
        }
    }
}
