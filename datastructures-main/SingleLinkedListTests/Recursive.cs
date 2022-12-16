using NUnit.Framework;
using System.Collections.Generic;

namespace DatastructureTests
{
    public class RecursionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_FixNumberIterative_ReturnsCorrectSum()
        {
            MySum ms = new MySum();
            var ret = ms.SumUpValues_Iterative(3);
            Assert.AreEqual(ret, 6);
        }

        [Test]
        public void Sum_FixNumberRecursive_ReturnsCorrectSum()
        {
            MySum ms = new MySum();
            var ret = ms.SumUpValues_Recursive(10);
            Assert.AreEqual(ret, 3628800);
        }
        private class MySum
        {
            public int SumUpValues_Iterative(int number)
            {
                var ret = 0;
                for (int i = 1; i <= number; i++)
                    ret += i;
                return ret;
            }

            public int SumUpValues_Recursive(int number)
            {
               if (number == 0)
               {
                   return 1;
               }
                return number * SumUpValues_Recursive(number - 1);
            }
        }
    }
}