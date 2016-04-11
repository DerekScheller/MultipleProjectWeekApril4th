using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> sweepstakesContestants;
        int countOfEntries;
        string sweepstakeName;
        Random ran;
        public Sweepstakes(string name)
        {
            sweepstakesContestants = new Dictionary<int, Contestant>();
            countOfEntries = 0;
            sweepstakeName = name;
            ran = new Random();
        }
        public void RegisterContestant(Contestant contestant)
        {
            sweepstakesContestants.Add(countOfEntries, contestant);
            countOfEntries++;
        }
        public string PickWinner()
        {
            int winningNumber = ran.Next(countOfEntries + 1);
            Contestant winner = sweepstakesContestants[winningNumber];
            string winningComment = string.Format("The Sweepstakes {0} winner {1}", sweepstakeName, winner.ToString());
            return winningComment;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.ToString());
        }
    }
}
