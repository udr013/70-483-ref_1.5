using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.Write("Enter an Integer: ");
                    string numberText = Console.ReadLine();
                    int result;
                    result = int.Parse(numberText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("++++++++++++++");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("++++++++++++++");
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine("++++++++++++++");

                    // throw new exception containing inner exception ex
                    throw new Exception("Calculation failure: ", ex);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(ex.Message);
                Console.WriteLine("--------------");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("--------------");
                Console.WriteLine("+++++++++++++++");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine("+++++++++++++++");
                Console.WriteLine(ex.InnerException.StackTrace);
                Console.WriteLine("+++++++++++++++");
            }
            Console.ReadKey();
        }
    }
}
