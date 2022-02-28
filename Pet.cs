using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    class Pet
    {
        private string name; //name of the pet
        private int age; //age as an integer
        private bool isFemale; //true if Female, otherwise false

        public void Start()
        {
            Console.WriteLine(); //blankline
            Console.WriteLine("Greetings from the Pet Owner application!"); //Greetings text
            Console.WriteLine(); //blankline

            ReadAndSavePetData();
            DisplayPetInfo();

        }
        public void ReadAndSavePetData()
        {
            //Read a line of text
            Console.Write("What's the name of your pet? ");
            name = Console.ReadLine();
                
            //Read a whole number
            Console.Write("What is " + name + "'s age? ");
            string textValue = Console.ReadLine();  

            //convert string to number
            age = int.Parse(textValue); 

            //Read a logical value (y/n)
            Console.Write("Is your pet a female (y/n)? ");
            string strGender = Console.ReadLine();
            strGender = strGender.Trim(); //delete leading and trailing spaces
            char response = strGender[0];

            if ((response == 'Y') || (response == 'y')) 
                isFemale = true;
            else
                isFemale = false;

        }
        public void DisplayPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++");
            string textOut = "name: " + name + " Age: " + age;
            Console.WriteLine(textOut);
                
            if (isFemale == true)
            {
                string textGender = name + " is a good girl";
                Console.WriteLine(textGender);          
                Console.WriteLine("++++++++++++++++++++++++");  
            }
            if (isFemale == false)
            {
                string textGender = name + " is a good boy";
                Console.WriteLine(textGender);
                Console.WriteLine("++++++++++++++++++++++++");
            }




                            
        }
        
    }

}
