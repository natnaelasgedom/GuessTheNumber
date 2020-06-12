using NUnit.Framework;
using System;
using GuessTheNumber;

namespace GuessTheNumberTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RunTest()
        {
            bool test = true;
            var random = new Randoms();
            for (int i = 1; i <= 999; i++)
            {
                if (random.RunTest(i) == false)
                    test = false;
            }
           
           Assert.IsTrue(test);
        }
    }
}