using NUnit.Framework;
using System.Collections.Generic;

namespace Day1.Test
{
    public class Tests
    {
        private List<int> Data = new List<int>();

        [SetUp]
        public void Setup()
        {
            Data.Add(1721);
            Data.Add(979);
            Data.Add(366);
            Data.Add(299);
            Data.Add(675);
            Data.Add(1456);
        }

        [Test]
        public void FindExpensesWithSum_1()
        {
            //arrange
            var expected =
                new List<int>
                { 
                    1721,
                    299
                };

            //act
            var day1 = new Day1(2020);
            day1.SolutionForTwo(Data);

            var actual = day1.SolutionValues;

            //assert
            Assert.Contains(expected[0], actual);            
            Assert.Contains(expected[1], actual);
            Assert.AreEqual(2, actual.Count);
            Assert.AreEqual(actual[0] + actual[1], 2020);
        }


        [Test]
        public void MultiplyExpenses_1()
        {
            //arrange
            var expected = 514579;
            
            //act
            var day1 = new Day1(2020);
            day1.SolutionValues.Add(1721);
            day1.SolutionValues.Add(299);
            var actual = day1.Multiply();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FindExpensesWithSum_2()
        {
            //arrange
            var expected =
                new List<int>
                {
                    979,
                    366,
                    675
                };

            //act
            var day1 = new Day1(2020);
            day1.SolutionForThree(Data);

            var actual = day1.SolutionValues;

            //assert
            Assert.Contains(expected[0], actual);
            Assert.Contains(expected[1], actual);
            Assert.Contains(expected[2], actual);
            Assert.AreEqual(3, actual.Count);
            Assert.AreEqual(actual[0] + actual[1] + actual[2], 2020);
        }

        [Test]
        public void MultiplyExpenses_2()
        {
            //arrange
            var expected = 241861950;

            //act
            var day1 = new Day1(2020);
            day1.SolutionValues.Add(979);
            day1.SolutionValues.Add(366);
            day1.SolutionValues.Add(675);
            var actual = day1.Multiply();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}