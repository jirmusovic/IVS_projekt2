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
            Assert.AreEqual(null, result5);

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
            Assert.AreEqual("2", result1);

            var result2 = eval.N_root("f(, )");
            Assert.AreEqual(null, result2);

            var result4 = eval.N_root("f(10000, 0.00000000000000000000000000000000000000000000000000000000001)");
            Assert.AreEqual(null, result4);   
        }

        [TestMethod]
        public void Factorial()
        {
            var eval = new Evaluation();
            var result = eval.Factorial("5!");
            Assert.AreEqual("120", result);

            var result1 = eval.Factorial("0!");
            Assert.AreEqual("1", result1);

            var result2 = eval.Factorial("X!");
            Assert.AreEqual(null, result2);
        }

        [TestMethod]
        public void Evaluation()
        {
            var eval = new Evaluation();
            var result = eval.Evaluate("(8*9)+(1*4)!");
            Assert.AreEqual("96", result);

            var result1 = eval.Evaluate("LASDASDASD");
            Assert.AreEqual(null, result1);

            var result2 = eval.Evaluate("(2*(7+2)-8+(2-1)^2)!");
            Assert.AreEqual("39916800", result2);

            var result3 = eval.Evaluate("(2*(7+2)-8+(2-1)^2)!");
            Assert.AreEqual("39916800", result3);

            var result4 = eval.Evaluate("(((((2*(7+2)-8+(2-1)^2)!");
            Assert.AreEqual(null, result4);

            var result5 = eval.Evaluate("(f(4, 2)!*8)^2");
            Assert.AreEqual("256", result5);

            var result6 = eval.Evaluate("e^5");
            Assert.AreEqual(148.413159103, double.Parse(result6), 0.00001);




        }
        [TestMethod]
        public void EvaluationTooManyBrackets()
        {
            var eval = new Evaluation();
            var result = eval.Evaluate("((((8*9)+(((((1*4)!");
            Assert.AreEqual(null, result);

        }
        [TestMethod]
        public void EvaluationTooManyOperators()
        {
            var eval = new Evaluation();
            var result = eval.Evaluate("(5*/*8)+(1*4)!");
            Assert.AreEqual(null, result);

        }
        [TestMethod]
        public void EvaluationMissingArguments()
        {
            var eval = new Evaluation();
            var result = eval.Evaluate("");
            Assert.AreEqual(null, result);

        }

        [TestMethod]
        public void EvaluationSin()
        {
            var eval = new Evaluation();
            var result = eval.Sin("sin(9.15555π)");
            Assert.AreEqual(-0.46945615, double.Parse(result), 0.00001);

        }

        [TestMethod]
        public void EvaluationSinBad()
        {
            var eval = new Evaluation();
            var result = eval.Sin("sin(jklasdasd)");
            Assert.AreEqual(null, result);

        }

        [TestMethod]
        public void EvaluationCos()
        {
            var eval = new Evaluation();
            var result = eval.Cos("cos(-987987π)");
            Assert.AreEqual(-1, double.Parse(result), 0.00001);

        }

        [TestMethod]
        public void EvaluationCosBad()
        {
            var eval = new Evaluation();
            var result = eval.Cos("cos(asdasdasd*π)");
            Assert.AreEqual(null, result);

        }

        [TestMethod]
        public void EvaluationTan()
        {
            var eval = new Evaluation();
            var result = eval.Tan("tan(999999*π)");
            Assert.AreEqual(0, double.Parse(result), 0.00001);

        }

        [TestMethod]
        public void EvaluationTanBad()
        {
            var eval = new Evaluation();
            var result = eval.Tan("tan()");
            Assert.AreEqual(null, result);

        }

        [TestMethod]
        public void EvaluationGoniometric()
        {
            var eval = new Evaluation();
            var result = eval.Evaluate("sin(cos(5π))");
            Assert.AreEqual(-0.8414709848, double.Parse(result), 0.00001);


        }

        [TestMethod]
        public void EvaluationGoniometricBad()
        {
            var eval = new Evaluation();
            var result = eval.Evaluate("5*0-6+12-6+sin(cos(tan()))");
            Assert.AreEqual(null, result);


        }





    }
}