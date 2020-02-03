using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {

        //Member Variables (HAS A)
         public string firstName;
         public  string lastName;
         public string emailAddress;
         public int registrationNumber;
       

        //Constructor
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; }set { lastName = value; } }   
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }
        public int RegistrationNumber { get { return registrationNumber; } set { registrationNumber = value; } }

        //Member Methods (CAN DO)


    }
}
