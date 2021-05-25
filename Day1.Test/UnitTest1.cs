using NUnit.Framework;
using System.Collections.Generic;

namespace Day1.Test
{
    public class Tests
    {
        private List<string> Data = new List<string>();

        [SetUp]
        public void Setup()
        {
            Data.Add("1721");
            Data.Add("979");
            Data.Add("366");
            Data.Add("299");
            Data.Add("675");
            Data.Add("1456");
        }

        [Test]
        public void FindExpensesWithSum()
        {
            //arrange
            var expected = 
                new Day1.SumResult 
                { 
                    Expense1 = 1721, 
                    Expense2 = 299 
                };

            //act
            var day1 = new Day1();
            var actual = day1.Solution(Data, 2020);

            //assert
            Assert.Contains(expected.Expense1, actual.GetValues());            
            Assert.Contains(expected.Expense2, actual.GetValues());
            Assert.AreEqual(actual.Expense1 + expected.Expense2, 2020);
        }

        [Test]
        public void MultiplyExpenses()
        {
            //arrange
            var expected = 514579;
            var sumResult =
                new Day1.SumResult
                {
                    Expense1 = 1721,
                    Expense2 = 299
                };


            //act
            var day1 = new Day1();
            var actual = day1.Multiply(sumResult);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}