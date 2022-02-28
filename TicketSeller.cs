using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{

    internal class TicketSeller
    {
        private string name; //name
        private double price = 100; //price
        private double discountPrice = 15;//price for children
        private int numOfAdults; //number of adults
        private int numOfChildren; //number of children
        private double amountToPay; //amount to pay

        public void Start()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Welcome to KIDS' FAIR!"); //Greetings text
            Console.WriteLine("Children get always a 75% discount!"); //Discount info
            Console.WriteLine(); //blankline

            ReadAndSaveGuestData();
            DisplayReceiptInfo();
        }
        public void ReadAndSaveGuestData()
        {
            //Read a line of text
            Console.Write("Your name please ");
            name = Console.ReadLine();

            //Read a number of adults
            Console.Write("Number of adults ");
            string adults = Console.ReadLine();
            //convert string to number
            numOfAdults = int.Parse(adults);
                    

            //read a number of children
            Console.Write("Number of children ");
            string children = Console.ReadLine();
            //convert string to number
            numOfChildren = int.Parse(children);
        }                   
        public void DisplayReceiptInfo()
        {
            //Read a line of text                                           
             Console.WriteLine();                       
             Console.WriteLine("+++ Your receipt +++");
             string amountToPay = "Amount to pay: "+(numOfAdults*price+numOfChildren*discountPrice);  
             Console.WriteLine(amountToPay);
             Console.WriteLine("+++ Thank you, " +name +", and come back! +++");
             Console.WriteLine();
        }
    }   
}           
