using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();
            
            //Create a variable of type int and initialize the variable with a value of 0 - DONE

            int variable = 0;


            // Create a do-while loop
            do{
                // Increment your variable by 1 - DONE
                    variable++
                // Then add your variable to "numbers" - DONE
                numbers.Add(variable);
            }while(variable < 100)
            // While your variable is less than 100 - DONE



            // Create a while loop - DONE
            // While your variable is less than 200 - DONE
            while(variable < 200){
                // Increment your variable by 1 - DONE
                variable++
                // Then add your variable to "numbers" - DONE
                numbers.Add(variable);
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop - DONE
            foreach (var item in numbers)
            {
                Console.WriteLine(variable);
            }
            // Write your variable to the console -DONE

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            for(int i = 199; i <= numbers.Count && i >= 0; i--)
            // in your initializer set the value of i to 199 - DONE
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count) - DONE
            // and as long as i is greater than or equal to 0 - DONE
            // Decrement i by 1 - DONE
            {
                // Write to the console "numbers" at index i - DONE
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
