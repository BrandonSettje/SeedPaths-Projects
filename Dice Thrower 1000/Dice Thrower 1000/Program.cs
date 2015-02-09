using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Thrower_1000
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Class required calls
            throwDice("10d6");
            throwDice("3d20");
            throwDice("100d6");
            //Negative test
            throwDice("-1d6");
            throwDice("10d-6");
            //for fun...1000 sided die 10 times
            throwDice("10d1000");
            //control the flow
            Console.ReadKey();
        }
        /// <summary>
        /// Throws a die where sides and number of times are user input
        /// </summary>
        /// <param name="diceString">Ndn where N = number of throws and n = sides of the die</param>
        static void throwDice(string diceString)
        {
           //an random number gen
            Random rng = new Random(DateTime.Now.Millisecond);
            //split at the d so we know what we are dealing with
            string[] dicestringInput = diceString.Split('d');
            //parse the first set to Rolls
            int numberRolls = int.Parse(dicestringInput[0]);
            //parse second to sides
            int numberSides = int.Parse(dicestringInput[1]);
            //less than 2 sides check
            if (numberSides < 2)
            {
                Console.WriteLine("Sorry, we are out of Mobious Strips.");
                Console.WriteLine();
            }
            //less than one roll check
            else if (numberRolls < 1)
            {
                Console.WriteLine("You have to roll at least once. Else its pointless to play the dice thrower. Try a number greater than 0!");
                Console.WriteLine();
            }
            //the goods
            else
            {
                //show the dice
                Console.WriteLine("Throwing : " + diceString);
                //show the results
                Console.Write("Results : ");
                //hold the sum
                int sum = 0;
                //loop for the dice
                for (int i = 0; i < numberRolls; i++)
                {
                    //roll the die 
                    int randomRoll = rng.Next(1, numberSides + 1);
                    //write to console
                    Console.Write(randomRoll + " ");
                    //add to sum
                    sum += randomRoll;
                }
                //space to make the console read better
                Console.WriteLine();
                //write the average to the Console
                Console.WriteLine("Average is: " + (sum/numberRolls));
                //space to make the console read better
                Console.WriteLine();
                //space to make the console read better
                Console.WriteLine();
            }
        }
    }
}
