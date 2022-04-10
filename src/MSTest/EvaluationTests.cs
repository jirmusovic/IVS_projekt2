﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(result, "3125");

            var result1 = eval.N_power("9^X");
            Assert.AreEqual(result1, null);

            var result2 = eval.N_power("5,5^9,7");
            Assert.AreEqual(double.Parse(result2), 15188612.003356718687067719416847, 0.00001);

            var result3 = eval.N_power("0.000001^0.0008");
            Assert.AreEqual(double.Parse(result3), 0.9890084450210655287818546403166, 0.00001);

            var result4 = eval.N_power("5^5^5");
            Assert.AreEqual(result4, null);

            var result5 = eval.N_power("5");
            Assert.AreEqual(result5, null);

            var result6 = eval.N_power("L^X");
            Assert.AreEqual(result6, null);
        }
        [TestMethod]
        public void N_root()
        {
            var eval = new Evaluation();
            var result = eval.N_root("f(X, N)");
            Assert.AreEqual(result, null);

            var result1 = eval.N_root("f(4, 2)");
            Assert.AreEqual(result1, "2");

            var result2 = eval.N_root("f(, )");
            Assert.AreEqual(result2, null);

            var result3 = eval.N_root("f(4.5, 2.65)");
            Assert.AreEqual(double.Parse(result3), 0.377358490566037735849, 0.0001);

            var result4 = eval.N_root("f(10000, 0.00000000000000000000000000000000000000000000000000000000001)");
            Assert.AreEqual(result4, null);

            
        }
    }
}