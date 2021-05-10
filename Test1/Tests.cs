using NUnit.Framework;
using System;
using Project1;
using System.Collections.Generic;
using System.Linq;

namespace Test1
{
    public class Tests
    {
        [Test]
        public void Test1Funct1()
        {
            var input = new List<object>() {1,2,"a","b" };
            var output = new List<int>() { 1, 2 };

            var result = Tasks.Task1Function(input);
           if (!(output.All(result.Contains) && output.Count == result.Count))
                throw new Exception("WRONG");
        }

        [Test]
        public void Test2Funct1()
        {
            var input = new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231};
            var output = new List<int>() { 1, 2, 231 };

            var result = Tasks.Task1Function(input);
            if (!(output.All(result.Contains) && output.Count == result.Count))
                throw new Exception("WRONG");
        }

        [TestCase("stress", 't')]
        [TestCase("aabbcc", ' ')]
        public void Test1Funct2(string input, char output)
        {
            var charresult = Tasks.Task2Function(input);
            Assert.AreEqual(output, charresult, "Returned result is incorrect");
        }

        [TestCase(16, 7)]
        [TestCase(132189, 6)]
        public void Test1Funct3(int input, int output)
        {
            var result = Tasks.Task3Function(input);
            Assert.AreEqual(output, result, "Returned result is incorrect");
        }

        [Test]
        public void Test1Funct4()
        {
            var input = new List<int>() { 1, 3, 6, 2, 2, 0, 4, 5 };
            var target = 5;
            var output = 4;

            var result = Tasks.Task4Function(input,target);
            Assert.AreEqual(output, result, "Returned result is incorrect");
        }

        [Test]
        public void Test2Funct4()
        {
            var input = new List<int>() { -5, 11, 6, 0, 0, 0, 1, 1 };
            var target = 6;
            var output = 4;

            var result = Tasks.Task4Function(input, target);
            Assert.AreEqual(output, result, "Returned result is incorrect");
        }

        [TestCase("Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:tornbull;Raphael:Corwill;Alfred:Corwill", "(CORWIL,ALFRED)(CORWILL,FRED)(CORWILL,RAPHAEL)(CORWILL,WILFRED)(TORNBULL,BARNEY)(TORNBULL,BETTY)(TORNBULL,BJON)")]
        [TestCase("Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Fred:Corwill", "(CORWIL,FRED)(TORNBULL,BARNEY)(TORNBULL,BETTY)(TORNBULL,BJON)")]
        public void Test1Funct5(string input, string output)
        {
            var result = Tasks.Task5Function(input);
            Assert.AreEqual(output, result, "Returned result is incorrect");
        }

    }
}
