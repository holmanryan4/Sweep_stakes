using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager //: ISweepstakesManager
    {

        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)
        public void StackPush()
        {
            Stack<int> contestantNumberList = new Stack<int>();
            contestantNumberList.Push(1001);
            contestantNumberList.Push(1002);
            contestantNumberList.Push(1003);
            contestantNumberList.Push(1004);
            contestantNumberList.Push(1005);


            Console.WriteLine("Contestant registration numbers: ");
            foreach(int number in contestantNumberList)
            {
                Console.WriteLine(number);
            }
            int topOfStack = contestantNumberList.Pop();

            contestantNumberList.Push(5);




        }




    }
    
}
