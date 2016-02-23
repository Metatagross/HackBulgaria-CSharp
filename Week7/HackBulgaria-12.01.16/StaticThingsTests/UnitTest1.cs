using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StaticThings;

namespace StaticThingsTests
{
    [TestClass]
    public class UnitTest1
    {
        public bool HelpCheck<T>(List<T> first, List<T> second)
        {
            if(first.Count!=second.Count)
            {
                return false;
            }
            for(int i = 0 ; i < first.Count ; i++)
            {
                if(!first[i].Equals(second[i]))
                {
                    return false;
                }
            }
            return true;
        }
        [TestMethod]
        public void TestMethodForIntersection ( )
        {
            List<int> l1 = new List<int> { 5 , 6 , 7 , 8 , 10 , 11 , 15 , 4 };
            List<int> l2 = new List<int> { 6 , 8 , 14 , 13 , 17 , 4 };
            Assert.IsTrue(ArrayExtension.Intersect(l1 , l2).Count == 3);
        }

        [TestMethod]
        public void TestMethodForUnion ( )
        {
            List<int> l1 = new List<int> { 5 , 6 , 7 , 8 , 10 , 11 , 15 , 4 };
            List<int> l2 = new List<int> { 6 , 8 , 14 , 13 , 17 , 4 };
            List<int> union = new List<int> { 5 , 6 , 7 , 8 , 10 , 11 , 15 , 4 , 14 , 13 , 17 };
            Assert.IsTrue(HelpCheck<int>(union, ArrayExtension.Union<int>(l1,l2)));

        }
    }
}
