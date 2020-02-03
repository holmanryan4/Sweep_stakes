using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {

        //Member Variables (HAS A)
        ISweepstakesManager manager;

       

        //Constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        //Member Methods (CAN DO)
        public void CreateSweepstake()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
           
            manager.InsertSweepstakes(sweepstakes);
        }
       

    }
}
