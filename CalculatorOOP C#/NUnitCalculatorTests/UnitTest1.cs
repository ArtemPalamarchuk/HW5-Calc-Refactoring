using NUnit.Framework;
using System;
using CalculatorOOP;
namespace NUnitCalculatorTests

{
    public class Tests
    {
        Logic logic = new Logic();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSumm()
        {
            Assert.AreEqual(logic.Summ(10, 23), 33);
        }
        [Test]
        public void TestSumm1()
        {
            Assert.AreEqual(logic.Summ(0, 45), 45);
        }
        [Test]
        public void TestSumm2()
        {
            Assert.AreEqual(logic.Summ(67, 0), 67);
        }
        [Test]
        public void TestSumm3()
        {
            Assert.AreEqual(logic.Summ(1.1, 8.9), 10);
        }
        [Test]
        public void TestSumm4()
        {
            Assert.AreEqual(logic.Summ(2.3, 4.5), 6.8);
        }
        [Test]
        public void TestSumm5()
        {
            Assert.AreEqual(logic.Summ(0, 0), 0);
        }
        [Test]
        public void TestSumm6()
        {
            Assert.AreEqual(logic.Summ(-32, 45), 13);
        }
        [Test]
        public void TestSumm7()
        {
            Assert.AreEqual(logic.Summ(-67, 12), -55);
        }
        [Test]
        public void TestSumm8()
        {
            Assert.AreEqual(logic.Summ(-1.234567, -1), -2.234567);
        }
        [Test]
        public void TestSumm9()
        {
            Assert.AreEqual(logic.Summ(0.0000001, 1.0000001), 1.0000002);
        }
        [Test]
        public void TestSumm10()
        {
            Assert.AreEqual(logic.Summ(-8.9, 2), -6.9);
        }
        [Test]
        public void TestMinus()
        {
            Assert.AreEqual(logic.Minus(10, 6), 4);
        }
        [Test]
        public void TestMinus1()
        {
            Assert.AreEqual(logic.Minus(15, 0), 15);
        }
        [Test]
        public void TestMinus2()
        {
            Assert.AreEqual(logic.Minus(0, 8), -8);
        }
        [Test]
        public void TestMinus3()
        {
            Assert.AreEqual(logic.Minus(3, 2.5), 0.5);
        }
        [Test]
        public void TestMinus4()
        {
            Assert.AreEqual(logic.Minus(1.1, 3.8), 2.7);
        }
        [Test]
        public void TestMinus5()
        {
            Assert.AreEqual(logic.Minus(5, 3), 2);
        }
        [Test]
        public void TestMinus6()
        {
            Assert.AreEqual(logic.Minus(4.9, 1.1), 3.8);
        }
        [Test]
        public void TestMinus7()
        {
            Assert.AreEqual(logic.Minus(-9, -7), -2);
        }
        [Test]
        public void TestMinus8()
        {
            Assert.AreEqual(logic.Minus(-8.4, -9.3), -17.7);
        }
        [Test]
        public void TestMinus9()
        {
            Assert.AreEqual(logic.Minus(-9999, -9998), -1);
        }
        [Test]
        public void TestMinus10()
        {
            Assert.AreEqual(logic.Minus(-3234, -3234), 0);
        }
        [Test]
        public void TestMinus11()
        {
            Assert.AreEqual(logic.Minus(21321.123, 46.876), 21274.247);
        }
        [Test]
        public void TestMinus12()
        {
            Assert.AreEqual(logic.Minus(7123.545, 1.3), 7122.245);
        }
        [Test]
        public void TestMinus13()
        {
            Assert.AreEqual(logic.Minus(-123.4, 234342), -234456.4);
        }
        [Test]
        public void TestMinus16()
        {
            Assert.AreEqual(logic.Minus(234.777, 234.777), 0);
        }
        [Test]
        public void TestMinus17()
        {
            Assert.AreEqual(logic.Minus(-465, 463), -928);
        }
        [Test]
        public void TestMultiply1()
        {
            Assert.AreEqual(logic.Multiply(10, 23), 230);
        }
        [Test]
        public void TestMultiply2()
        {
            Assert.AreEqual(logic.Multiply(0, 45), 0);
        }
        [Test]
        public void TestMultiply3()
        {
            Assert.AreEqual(logic.Multiply(67, 0), 0);
        }
        [Test]
        public void TestMultiply4()
        {
            Assert.AreEqual(logic.Multiply(1.1, 8.9), 9.79);
        }
        [Test]
        public void TestMultiply5()
        {
            Assert.AreEqual(logic.Multiply(2.3, 4.5), 10.35);
        }
        [Test]
        public void TestMultiply6()
        {
            Assert.AreEqual(logic.Multiply(0, 0), 0);
        }
        [Test]
        public void TestMultiply7()
        {
            Assert.AreEqual(logic.Multiply(-32, -45), 1440);
        }
        [Test]
        public void TestMultiply8()
        {
            Assert.AreEqual(logic.Multiply(-8.9, -2.3), 20.47);
        }
        [Test]
        public void TestMultiply9()
        {
            Assert.AreEqual(logic.Multiply(0.9, 0.3), 0.27);
        }
        [Test]
        public void TestMultiply10()
        {
            Assert.AreEqual(logic.Multiply(8.9, 0.3), 2.4);
        }
        [Test]
        public void TestMultiply11()
        {
            Assert.AreEqual(logic.Multiply(8, 3), 24);
        }
        [Test]
        public void TestMultiply12()
        {
            Assert.AreEqual(logic.Multiply(0.5, 3), 1.5);
        }
        [Test]
        public void TestDivide()
        {
            Assert.AreEqual(logic.Divide(0, 45), 0);
        }
        [Test]
        public void TestDivide1()
        {
            Assert.AreNotEqual(logic.Divide(67, 0), 0);
        }
        [Test]
        public void TestDivide2()
        {
            Assert.AreEqual(logic.Divide(10, 10), 1);
        }
        [Test]
        public void TestDivide3()
        {
            Assert.AreNotEqual(logic.Divide(0, 0), 0);
        }
        [Test]
        public void TestDivide4()
        {
            Assert.AreEqual(logic.Divide(-8.9, 2), -4.45);
        }
        [Test]
        public void TestDivide5()
        {
            Assert.AreEqual(logic.Divide(333, 44), 7.5681818);
        }
        [Test]
        public void TestDivide6()
        {
            Assert.AreEqual(logic.Divide(0, 45), 0);
        }


 


    }
}