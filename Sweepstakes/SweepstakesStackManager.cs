using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> contestantNumberList; 
        public SweepstakesStackManager()
        {
            contestantNumberList = new Stack<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            return contestantNumberList.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            contestantNumberList.Push(sweepstakes);
           
        }

        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)
       



    }
    
}
