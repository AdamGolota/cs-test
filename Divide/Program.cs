using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Divide
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int from = Convert.ToInt32(Console.ReadLine());
                int to = Convert.ToInt32(Console.ReadLine());
                int value = Convert.ToInt32(Console.ReadLine());
                RangedInt ri = new RangedInt(value, from, to);
                Console.WriteLine(ri.getValue());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid value!");
               
            }
            catch (ValueOutOfRangeException)
            {
                Console.WriteLine("Value is out of range!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value is too large!");
            }
            finally
            {
                Console.ReadKey();
            }
        }
        static void divide()
        {
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("The universe is broken!");
            }
            catch (FormatException)
            {
                Console.WriteLine("You are supposed to type in numbers!");
            }
            finally
            {
            }
        }
    }
}
