using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzClass;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Execute();
        }

        public static void Execute()
        {
            var iterate = 101;
            var FizzBuzz = new FizzBuzz();

            for(int i=1; i<iterate; i++)
            {
                
               var result =  FizzBuzz.evaluate(i);
               Console.WriteLine(result);
            }
        }
    }
}
