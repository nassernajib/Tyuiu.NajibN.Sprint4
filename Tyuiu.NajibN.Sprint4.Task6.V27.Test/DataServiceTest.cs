using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NajibN.Sprint4.Task6.V27.Lib;
namespace Tyuiu.NajibN.Sprint4.Task6.V27.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var week = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            int res = ds.Calculate(week);
            int wait = 1;
            Assert.AreEqual(wait, res);
            {
            }
        }
    }
}
