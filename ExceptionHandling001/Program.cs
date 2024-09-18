using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = 10;
                int result = num / 0; // This will throw a DivideByZeroException
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
            Console.ReadKey();

        }
    }
}
