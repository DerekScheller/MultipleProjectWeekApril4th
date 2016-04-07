using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakesQueueManager Queuetest = new SweepstakesQueueManager();
            SweepstakesStackManager Stacktest = new SweepstakesStackManager();
            Contestant derek = new Contestant("Derek", 4145555555, "123 Fake Street, Mke, WI");
            Contestant jared = new Contestant("Jared", 4145555555, "123 Fake Street, Mke, WI");
            Contestant jim = new Contestant("Jim", 4145555555, "123 Fake Street, Mke, WI");
            Sweepstakes power = new Sweepstakes("Powerball");
            Sweepstakes pick = new Sweepstakes("BadgerPick5");
            Sweepstakes mega = new Sweepstakes("MegaBucks");
            Sweepstakes clear = new Sweepstakes("ClearingHouse");
            Sweepstakes loan = new Sweepstakes("Student Loan Payoff");
            Sweepstakes gift = new Sweepstakes("StarBucks Gift Card");
            power.RegisterContestant(jared);
            power.RegisterContestant(derek);
            pick.RegisterContestant(jim);
            clear.RegisterContestant(derek);
            gift.RegisterContestant(jared);
            power.RegisterContestant(jim);
            mega.RegisterContestant(derek);
            pick.RegisterContestant(jared);
            gift.RegisterContestant(derek);
            mega.RegisterContestant(jared);
            clear.RegisterContestant(jim);
            loan.RegisterContestant(jared);
            loan.RegisterContestant(derek);
            loan.RegisterContestant(jim);
            mega.RegisterContestant(jim);
            pick.RegisterContestant(derek);
            clear.RegisterContestant(jared);
            gift.RegisterContestant(jim);
            Queuetest.InsertSweepstakes(power);
            Queuetest.InsertSweepstakes(pick);
            Queuetest.InsertSweepstakes(mega);
            Stacktest.InsertSweepstakes(clear);
            Stacktest.InsertSweepstakes(loan);
            Stacktest.InsertSweepstakes(gift);
            Console.WriteLine(Queuetest.GetNextSweepstakesWinner().PickWinner());
            Console.ReadLine();
            Console.WriteLine(Stacktest.GetNextSweepstakesWinner().PickWinner());
            Console.ReadLine();
            Console.WriteLine(Queuetest.GetNextSweepstakesWinner().PickWinner());
            Console.ReadLine();
            Console.WriteLine(Stacktest.GetNextSweepstakesWinner().PickWinner());
            Console.ReadLine();
            Console.WriteLine(Queuetest.GetNextSweepstakesWinner().PickWinner());
            Console.ReadLine();
            Console.WriteLine(Stacktest.GetNextSweepstakesWinner().PickWinner());
            Console.ReadLine();
        }
    }
}
//Assignment #4:
//       Using a Systems.Collections.Generic.Dictionary as an underlying structure, create a Sweepstakes class with the following functions
//      (you will need to define a Contestant class containing appropriate fields for the purpose):

    //       Sweepstakes(string name)
//       void RegisterContestant(Contestant contestant)
//       string PickWinner()
//       void PrintContestantInfo(Contestant contestant)

    //    Create a sweepstakes management system:
//        Write an ISweepstakesManager interface with the following custom functions:
//        void InsertSweepstakes(Sweepstakes sweepstakes)
//        Sweepstakes GetNextSweepstakesWinner()
//        Inherit from the ISweepstakesManager interface to implement the following subclasses:
//        SweepstakesStackManager(using System.Collections.Generic.Stack)
//        SweepstakesQueueManager(using System.Collections.Generic.Queue)