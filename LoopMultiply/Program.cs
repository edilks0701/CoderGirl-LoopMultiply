using System;
using System.Linq;

namespace LoopMultiply
{
    public static class Program
    {
        public static void Main()
        {
            
            Console.Write("Enter a number: ");
            string userNum = Console.ReadLine();
            int number = Convert.ToInt32(userNum);
            int sum = 0;

            // TODO: Loop from 2 to 20 and multiply the loop value by the number the user entered and output the value each time. 
            //Convert.ToInt32
            for (int counter = 2; counter < 21; counter++)
            {
                
                int product = (counter * number);
                Console.WriteLine(product);
                sum += product;



                //string[] multiples = multiples.Sum();
                //int multipled = Convert.ToInt32(multiples);

            }

            Console.WriteLine(sum);


            Console.ReadLine();
        }


    }
}
