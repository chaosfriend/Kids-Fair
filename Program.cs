using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KidsFair
{
    class MainProgram  
    {
        static void Main (string[]args)
    {
            //Arrange the console window
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear(); //Paint the background with above color
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Pet Owner";

            //Create object (instance) of the Pet class
            Pet petObj = new Pet();
            //Use the object
            petObj.Start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            //Create object (instance) of the TicketSeller class
            TicketSeller TicketSellerObj = new TicketSeller();
            //Use the object
            TicketSellerObj.Start();

            Console.WriteLine("Press Enter to start next part!");
            Console.ReadLine();

            //Create object (instance) of the Album class
            Album AlbumObj = new Album();
            //Use the object
            AlbumObj.Start();

            Console.WriteLine("Press Enter to exit!");
            Console.ReadLine();
        }
        static void PrepareConsolesLook()
        {
            //Arrange the Console Window
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); //Paint the background with above
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "KIDS' FAIR";

        }
    }
}   
