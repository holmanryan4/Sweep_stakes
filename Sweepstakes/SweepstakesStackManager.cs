using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //Member Variables (HAS A)
        Stack<Sweepstakes> contestantNumberList;

        //Constructor
        public SweepstakesStackManager()
        {
            contestantNumberList = new Stack<Sweepstakes>();
        }

        //Member Methods (CAN DO)
        public Sweepstakes GetSweepstakes()
        {
            return contestantNumberList.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            contestantNumberList.Push(sweepstakes);
           
        }

        

       

       
       



    }
    
}
