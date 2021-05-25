using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = System.IO.File.ReadAllLines("input.txt");
            var data = new List<int> { };

            foreach(string line in file)
            {
                int.TryParse(line, out int value);
                data.Add(value);
            }

            Day1 day1 = new Day1(2020);

            day1.SolutionForTwo(data);
            var answer = day1.Multiply();

            Console.WriteLine("Answer part 1 =" + answer);

            day1.SolutionForThree(data);
            answer = day1.Multiply();

            Console.WriteLine("Answer part 2 =" + answer);
        }
    }
}
