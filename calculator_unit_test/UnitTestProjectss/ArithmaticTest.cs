using CalculatorUnitTest;
using Moq;
using NUnit.Framework;
using System;

namespace UnitTestProjectss
{
    [TestFixture]
    public class ArithmaticTest
    {
        public int i = 10;
        public int j = 25;
        public bool result;

        [SetUp]//before every test
        public void checkNonNegative()
        {
            if (i > 0 && j > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }

        [TearDown]//after test
        public void setupDefaultValues()
        {
            result = false;
        }

        [Test]
        public void testSum()
        {
            if (result)
            {

                Arithmatic at = new Arithmatic();
                Assert.That(at.sum(i, j), Is.EqualTo(35));

            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        [TestCase(10, 5, 5)]
        [TestCase(25, 5, 5)]
        public void testSub(int a, int b, int expected)
        {
            Arithmatic at = new Arithmatic();
            Assert.That(at.sub(a, b), Is.EqualTo(expected));

        }

        [Test]
        [Ignore("Not implemented yet")]//ignore means this test will not run
        public void testMul()
        {

        }

        [Test]
        public void checkValues()
        {
            Mock<Arithmatic> mock = new Mock<Arithmatic>();
            mock.Setup(x=>x.checkDigitsOnly()).Returns(true);
            //by using mock we can bypass the result of any unimplement code
            Assert.That(mock.Object.checkDigitsOnly(), Is.True);

        }
    }
}
