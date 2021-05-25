using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public class Day1
    {
        public class SumResult
        {
            public int Expense1 { get; set; }
            public int Expense2 { get; set; }

            public List<int> GetValues()
            {
                return
                    new List<int>
                    {
                        Expense1,
                        Expense2
                    };
            }
        }

        public SumResult Solution(List<int> data, int sum)
        {
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = i; j < data.Count; j++)
                {
                    if (data[i] + data[j] == sum)
                    {
                        return
                            new SumResult
                            {
                                Expense1 = data[i],
                                Expense2 = data[j]
                            };
                    }
                }
            }

            return
                new SumResult {};
        }

        public int Multiply(SumResult sumResult)
        {
            if(sumResult == null)
                throw new ArgumentNullException(nameof(sumResult));

            return
                sumResult.Expense1 * sumResult.Expense2;
        }
    }
}
