using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class Day1
    {
        public int Sum { get; private set; }
        public Day1(int sum)
        {
            Sum = sum;
        }

        public List<int> SolutionValues { get; } = new List<int> { };

        public void Solution(List<int> data)
        {
            SolutionValues.Clear();

            for (int i = 0; i < data.Count; i++)
            {
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (data[i] + data[j] == Sum)
                    {
                        SolutionValues.Add(data[i]);
                        SolutionValues.Add(data[j]);

                        return;
                    }
                }
            }            
        }

        public long Multiply()
        {
            long result = 1;

            foreach(int i in SolutionValues)
            {
                result *= i;
            }

            return result;
        }
    }
}
