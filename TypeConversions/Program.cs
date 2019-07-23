using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with type conversions *****");

            // Add two shorts and print the result.
            short numb1 = 30000, numb2 = 30000;
            short answer = (short)Add(numb1, numb2);
            Console.WriteLine($"{numb1} + {numb2} = {answer}");
            NarrowingAttempt();
            ProcessBytes();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NarrowingAttempt()
        {
            byte myByte = 0;
            int myInt = 200;
            // Explicitly cast the int into a byte (no loss of data).
            myByte = (byte)myInt;
            Console.WriteLine("Value of myByte: {0}", myByte);
        }

        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;
            try
            {
                byte sum =checked( (byte)Add(b1, b2));
                // sum should hold the value 350. However, we find the value 94!
                Console.WriteLine("sum = {0}", sum);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
