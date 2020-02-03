using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {

            Simulation simulation = new Simulation();
            SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();

            MarketingFirm marketingFirm = new MarketingFirm();
            SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
            Sweepstakes sweepstakes = new Sweepstakes();
            Contestant contestant = new Contestant();
            UserInterface userInterface = new UserInterface();
            
            
            
        }
    }
}
