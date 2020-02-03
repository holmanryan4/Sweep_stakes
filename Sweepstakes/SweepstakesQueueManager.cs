using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {

        //Member Variables (HAS A)
        Queue<Sweepstakes> contestantNumberList;

        //Constructor
        public SweepstakesQueueManager()
        {
            contestantNumberList = new Queue<Sweepstakes>();
        }
        //Member Methods (CAN DO)
        public Sweepstakes GetSweepstakes()
        {
            return contestantNumberList.Dequeue();

        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            contestantNumberList.Enqueue(sweepstakes);
        }

    }
}
