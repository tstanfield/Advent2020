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

            Day1 day1 = new Day1();

            var solution = day1.Solution(data, 2020);
            var answer = day1.Multiply(solution);

            Console.WriteLine(answer);
            
        }
    }
}
