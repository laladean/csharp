using System;

namespace mission2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numRoll = new int[11]; //Instantiating array to hold number of rolls
            Random r = new Random();

            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            var x = Convert.ToInt32(Console.ReadLine());//ask user for number of rolls

            //simulate roll of the die
            for (int i = 0; i < x; i++)
            {
                int die1 = r.Next(1,7);
                int die2 = r.Next(1,7);


                int roll = die1 + die2;

                numRoll[roll - 2]++;

            }

            int percentage = 0;
            //print out results from the array
            for (int i = 0; i < numRoll.Length; i++)
            {
                percentage = (int)((numRoll[i]/(float)x)*100);

                string stars = "";

                for (int j = 0; j < percentage; j++)
                {
                    stars += "*";
                }

                Console.WriteLine((i + 2) + ": " + stars);
            }

            

            
        }
    }
}
