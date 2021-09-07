using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ArrayListSimple;

namespace ArrayListSimple.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add()
        {
            int z = 3;
            ArrayListSimple ALS = new ArrayListSimple(2);

            ALS.Add(z);

            Assert.AreEqual(3, ALS.GetAt(0));

        }

        [TestMethod]
        public void Clear()
        {
            int z = 3;
            ArrayListSimple ALS = new ArrayListSimple(2);

            ALS.Add(z);

            ALS.Clear();

            Assert.AreEqual(0, ALS.Count);

        }


    }
}
