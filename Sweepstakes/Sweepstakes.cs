using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes : Contestant
    {

        //Member Variables (HAS A)

        //Constructor

        //Member Methods (CAN DO)
        public Sweepstakes()
        {
            Dictionary<int, string> addContestant = new Dictionary<int, string>();
            addContestant.Add(1001, firstName);
            addContestant.Add(1002, firstName);
            addContestant.Add(1003, firstName);
            addContestant.Add(1004, firstName);
            addContestant.Add(1005, firstName);

        }
        public void RegisterContestant(Contestant contestant)
        {

        }
        public void PickWinner()
        {

        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
