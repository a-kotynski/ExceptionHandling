using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.youtube.com/watch?v=vn7_Ae8CWsE
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { // put a piece of code that causes an error in the try block
                int a, b, c;
                Console.WriteLine("Enter a value of a: ");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a value of b: ");
                b = int.Parse(Console.ReadLine());

                c = a / b;
                Console.WriteLine("Division of a by b is: " + c);
            }
            catch (Exception)
            {

                Console.WriteLine("Error Occured");
            }
            finally
            { // finally executes code regardless if there was an exception or not
                Console.WriteLine("Program Executed");
            }
            
        }
    }
}