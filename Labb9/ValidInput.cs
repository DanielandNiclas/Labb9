using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb9
{
    class ValidInput
    {

        public static int Integer(string text)
        {
            bool validInput;
            string input;
            int output;


            do
            {

                Console.Write(text);
                input = Console.ReadLine();

                validInput = int.TryParse(input, out output);

                if (validInput)
                    return output;
                else
                    Console.WriteLine("Invalid input, try again.");

            } while (true);
        }

        public static int Integer(int minNum, int maxNum, string text)
        {
            bool validInput;
            string input;
            int output;


            do
            {

                Console.Write(text);
                input = Console.ReadLine();

                validInput = int.TryParse(input, out output);

                if (validInput && output >= minNum && output <= maxNum)
                    return output;
                else
                    Console.WriteLine("Invalid input, try again.");

            } while (true);
        }
    }
}
