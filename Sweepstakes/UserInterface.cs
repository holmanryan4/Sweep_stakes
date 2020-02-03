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


        //Constructor
        public bool IsEmailValid(string emailAddress)
        {
            //Console.WriteLine("Please enter your email address. Ex. 123@gmail.com");
            //string emailAddress = Console.ReadLine();


            //-------------------get help with making this work------------------------
            try
            {
                Console.WriteLine("Valid email address");

                var email = new System.Net.Mail.MailAddress(emailAddress);
                return true;

            }
            catch (FormatException)
            {
               Console.WriteLine("Invalid email address please try again"); ContestantEmail();
                return false;
            }
            //----------------------------------------------------------------------------------///
        }
        //Member Methods (CAN DO)
        public string ContestantFirstName()
        {
            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();
            return firstName;

        }
        public string ContestantLastName()
        {
            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();
            return lastName;
        }
        public string ContestantEmail()
        {

            Console.WriteLine("Please enter your email address. Ex. 123@gmail.com");
            string emailAddress = Console.ReadLine();
            

            return emailAddress;

        }
        public void ContestantInfo()
        {
            // add to this do to the changes above
            ContestantFirstName();
            ContestantLastName();
            ContestantEmail();
        }
    }

}
