using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface 
    {

        //Member Variables (HAS A)
       
        public  string firstName;
        public static string lastName;
        public static string emailAddress;



        //Constructor
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }


        //Member Methods (CAN DO)
        public void ContestantFirstName()
        {
            Console.WriteLine("Please enter your first name.");
            firstName = Console.ReadLine();
            
            
        }
        public void ContestantLastName()
        {
            Console.WriteLine("Please enter your last name.");
            LastName = Console.ReadLine();
        }
        public  void ContestantEmail()
        {
            Console.WriteLine("Please enter your email address. Ex. 123@gmail.com");
            EmailAddress = Console.ReadLine();
        }
        public void ContestantInfo()
        {
            
            ContestantFirstName();
            ContestantLastName();
            ContestantEmail();
        }
    }
}
