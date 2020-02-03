using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes 
    {

        //Member Variables (HAS A)
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();

        //Constructor
       
        //Member Methods (CAN DO)
        public Sweepstakes(string name)
        {
            Console.WriteLine("What would you like to name the Sweepstakes?");
            string value = Console.ReadLine();
            Console.WriteLine("You have named the Sweepstakes: " + value);
            Console.ReadLine();
           

        }

        public Sweepstakes()
        {
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.Registrationnumber = contestants.Count;
            contestants.Add(contestants.Count, contestant);
            
        }
        public int Ran()
        {
            Random random = new Random();
            int contestants;
            contestants = random.Next(1, 4);
            return contestants;
        }
        public void PickWinner()
        {
            Console.WriteLine("The Sweepstakes Winner is: " + Ran());
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Enter the contestant name you want to print: ");
            string value = Console.ReadLine();
            foreach (KeyValuePair<int, Contestant> dictContestant in contestants)
            {
                if(Equals(dictContestant.Value, value))
                {
                    Console.WriteLine($"Contestant number: {dictContestant.Key} Contestant information: {dictContestant.Value}");
                }
            }
        }
        public void RunSweepstakes()
        {

        }
    }
}
