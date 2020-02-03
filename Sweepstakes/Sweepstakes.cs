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
        Random random = new Random();
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        
        //Constructor
         
        //Member Methods (CAN DO)
        public Sweepstakes(string name)
        {
           
           

        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(1, contestant);
            contestants.Add(2, contestant);
            contestants.Add(3, contestant);
        }
        public int PickWinner()
        {
            Console.WriteLine("The Sweepstakes Winner is: " )
            int contestants;
            contestants = random.Next(1,4);
            return contestants;
            

        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
