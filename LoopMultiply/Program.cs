using System;

namespace LoopMultiply
{
    public static class Program
    {
        public static void Main()
        {
            
            Console.Write("Enter a number: ");
            string userNum = Console.ReadLine();
            int number = Convert.ToInt32(userNum);

            // TODO: Loop from 2 to 20 and multiply the loop value by the number the user entered and output the value each time. 
            //Convert.ToInt32
            for (int counter = 2; counter < 21; counter++)
            {
                
                Console.WriteLine(counter * number);
            }



            Console.ReadLine();
        }


    }
}
