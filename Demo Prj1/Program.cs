using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Prj1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Prompt the user to enter the height of the pyramid
            Console.Write("Enter the height of the pyramid: ");

            if (int.TryParse(Console.ReadLine(), out int height))
            {
                // Call the method to generate and display the pyramid
                GeneratePyramid(height);
            }
            else
            {
                // Display an error message if the input is not a valid integer
                Console.WriteLine("Please enter a valid integer for the height.");
            }
            Console.ReadLine();
        }
        static void GeneratePyramid(int num)
        {
            int numberoflayer = num, Space, Number;
            Console.WriteLine("Print paramid");
            for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++) //increase the value  
                    Console.Write(Number);
                for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
                    Console.Write(Number);
                Console.WriteLine();
            }
        }

    }
}
