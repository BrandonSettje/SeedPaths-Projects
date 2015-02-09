using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with $4.19.  
            //Notice that when using the decimal format you must end numbers with an 'm'
            ChangeAmount(4.19m);
            //calling the function with $3.18.
            ChangeAmount(3.18m);
            //calling the function with $.99.
            ChangeAmount(0.99m);
            //calling the function with $12.93.
            ChangeAmount(12.93m);
            //calling the function with $80 million.
            //The amount Heisenberg had hiding in the desert before...
            ChangeAmount(80000000.00m);
            //calling the function with -$1.00.
            ChangeAmount(-1.00m);
            
            Console.ReadKey();
        }

        public static Change ChangeAmount(decimal amount)
        {
            //this is our object that will hold the data of how many coins of each type to return
            Change amountAsChange = new Change();
            //Create a temp amount to subtract from
            decimal amountInput = amount;
            //Cant be having negative numbers here
            if (amount < 0.00m)
            {
               Console.WriteLine("Hey! You owe me money!");
            }
            //Checks for Hundreds and subtracts 
            while (amountInput > 100.00m)
            {
                amountInput -= 100.00m;
                amountAsChange.BenjaminFranklins++;
            }
            //Checks for Fifties and subtracts 
            while (amountInput > 50.00m)
            {
                amountInput -= 50.00m;
                amountAsChange.UlyssesGrants++;
            }
            //Checks for Twenties and subtracts 
            while (amountInput > 20.00m)
            {
                amountInput -= 20.00m;
                amountAsChange.AndrewJacksons++;
            }
            //Checks for Tens and subtracts 
            while (amountInput > 10.00m)
            {
                amountInput -= 10.00m;
                amountAsChange.AlexanderHamiltons++;
            }
            //Checks for Fives and subtracts 
            while (amountInput > 05.00m)
            {
                amountInput -= 05.00m;
                amountAsChange.AbrahamLincolns++;
            }
            //Checks for Ones and subtracts 
            while (amountInput > 01.00m)
            {
                amountInput -= 01.00m;
                amountAsChange.GeorgeWashingtons++;
            }
            //Checks for Quarters and subtracts 
            while (amountInput > 0.25m)
            {
                amountInput -= 0.25m;
                amountAsChange.Quarters++;
            }
            //Checks for Dimes and subtracts
            while (amountInput > 0.10m)
            {
                amountInput -= 0.10m;
                amountAsChange.Dimes++;
            }
            //Checks for Nickles and subtracts
            while (amountInput > 0.05m)
            {
                amountInput -= 0.05m;
                amountAsChange.Nickles++;
            }
            //Checks for Pennies and subtracts
            while (amountInput >= 0.01m)
            {
                amountInput -= 0.01m;
                amountAsChange.Pennies++;
            }
            //Output for each Change Type
            Console.WriteLine("Amount:$  " + amount);
            Console.WriteLine("$100s: " + amountAsChange.BenjaminFranklins);
            Console.WriteLine("$50s: " + amountAsChange.UlyssesGrants);
            Console.WriteLine("$20s " + amountAsChange.AndrewJacksons);
            Console.WriteLine("$10s " + amountAsChange.AlexanderHamiltons);
            Console.WriteLine("$5s " + amountAsChange.AbrahamLincolns);
            Console.WriteLine("$1s " + amountAsChange.GeorgeWashingtons);
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);
            Console.WriteLine("Dimes: " + amountAsChange.Dimes);
            Console.WriteLine("Nickles: " + amountAsChange.Nickles);
            Console.WriteLine("Pennies: " + amountAsChange.Pennies);
            //return our Change Object
            return amountAsChange;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;

            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        public int BenjaminFranklins { get; set; }
        public int UlyssesGrants { get; set; }
        public int AndrewJacksons { get; set; }
        public int AlexanderHamiltons { get; set; }
        public int AbrahamLincolns { get; set; }

        public int GeorgeWashingtons { get; set; }

        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.BenjaminFranklins = 0;
            this.UlyssesGrants = 0;
            this.AndrewJacksons = 0;
            this.AlexanderHamiltons = 0;
            this.AbrahamLincolns = 0;
            this.GeorgeWashingtons = 0;
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
        }
    }
}
