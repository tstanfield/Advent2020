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
            return 
                new SumResult {};
        }        

        public int Multiply(SumResult sumResult)
        {
            if(sumResult == null)            
                throw new ArgumentNullException(nameof(sumResult));

            return
                0;
        }
    }
}
