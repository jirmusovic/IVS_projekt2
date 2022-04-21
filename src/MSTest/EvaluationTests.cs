using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc;
using System;

namespace MSTest
{

    [TestClass]
    public class EvaluationTests
    {
        [TestMethod]
        public void N_power()
        {
            var eval = new Evaluation();
            var result = eval.N_power("5^5");
            Assert.AreEqual("3125", result);

            var result1 = eval.N_power("9^X");
            Assert.AreEqual(null, result1);

            var result4 = eval.N_power("5^5^5");
            Assert.AreEqual(null, result4);

            var result5 = eval.N_power("5");
            Assert.AreEqual(null, result4);

            var result6 = eval.N_power("L^X");
            Assert.AreEqual(null, result6);
        }
        [TestMethod]
        public void N_root()
        {
            var eval = new Evaluation();
            var result = eval.N_root("f(X, N)");
            Assert.AreEqual(null, result);

            var result1 = eval.N_root("f(4, 2)");
            Assert.AreEqual("2", result1,);

            var result2 = eval.N_root("f(, )");
            Assert.AreEqual(null, result2);

            var result4 = eval.N_root("f(10000, 0.00000000000000000000000000000000000000000000000000000000001)");
            Assert.AreEqual(null, result4);   
        }

        [TestMethod]
        public void Factrial()
        {
            var eval = new Evaluation();
            var result = eval.N_root("5!");
            Assert.AreEqual("120", result);

            var result1 = eval.N_root("0!");
            Assert.AreEqual("1", result1);

            var result2 = eval.N_root("X!");
            Assert.AreEqual(null, result2);
        }

        [TestMethod]
        public void Evaluation()
        {
            var eval = new Evaluation();
            var result = eval.N_root("(8*9)+(1*4)!");
            Assert.AreEqual("96", result);

            var result1 = eval.N_root("LASDASDASD");
            Assert.AreEqual(null, result1);

            var result2 = eval.N_root("(2*(7+2)-8+(2-1)^2)!");
            Assert.AreEqual("39916800", result2);

            var result3 = eval.N_root("(2*(7+2)-8+(2-1)^2)!");
            Assert.AreEqual("39916800", result3);

            var result4 = eval.N_root("(((((2*(7+2)-8+(2-1)^2)!");
            Assert.AreEqual(null, result4);

            var result5 = eval.N_root("(f(4, 2)!*8))^2");
            Assert.AreEqual("256", result5);

            var result6 = eval.N_root("e^5");
            Assert.AreEqual(148.413159103, 0.00001, double.Parse(result6));




        }

    }
}