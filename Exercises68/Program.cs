using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a few numbers separated by a hyphen :");
            var input = Console.ReadLine();
            var numbers = new List<int>();

            foreach(var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            numbers.Sort();

            var consecutive = true;

            for (var i = 1; i < numbers.Count(); i++)
            {
                if (numbers[i] - 1 != numbers[i - 1])
                {
                    consecutive = false;
                    break;
                }
            }

            var message = consecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);

            
       
        }
    }
}
