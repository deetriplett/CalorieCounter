using System;

namespace calorieCounter { 
        class Program
    {
        static void Main()
        {
            //prompt user for calories eaten
            Console.WriteLine("Enter Calories consumed: ");
        
            string entry = Console.ReadLine();


            //add calories to total
            //display total number on screen
            Console.WriteLine("You've eaten " + entry + " calories today.");

            //repeat til user quits

        }
    }
}
