using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {

        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)
        public ISweepstakesManager CreatingmarketingFirmWithManager()
        {
            Console.WriteLine("What type of manager would you like to use to manage the sweepstake? Queue or Stack.");
            string input = Console.ReadLine();
            ISweepstakesManager manager = null;
            if(input == "Queue")
            {
                manager = new SweepstakesQueueManager(); 
            }
            else if(input == "Stack")
            {
                manager = new SweepstakesStackManager();
            }

            return manager;
           
        }
        //public void RunSimulation()
        //{
        //    ISweepstakesManager manager = CreatingmarketingFirmWithManager();
        //    MarketingFirm marketingFirm = new MarketingFirm(manager);
        //    marketingFirm.CreateSweepstake();
        //    SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();

        //    SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
        //    Sweepstakes sweepstakes = new Sweepstakes();

            
        //}
}
}
