using System;
using StarStaffLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StarStaffLibTests
{
    [TestClass]
    public class StarStaffTest
    {
        [TestMethod]
        public void AreaCircleSuccessTest()
        {
            //arrange
            double R = 1;
            double expected = Math.PI;
            //actions
            ComputeAreaShape testobj = new AreaCircleClass(R);
            double actual = testobj.Compute();
            //assert
            Assert.AreEqual<double>(expected, actual);
            
        }
        [TestMethod]
        [ExpectedException(typeof(CircleRadiusExeption))]
        public void FailNegativeRadiusAreaCircleTest()
        {
            //arrange
            double R = -1;
            //actions
            ComputeAreaShape testobj = new AreaCircleClass(R);
           
           

        }
        [TestMethod]
        [ExpectedException(typeof(CircleRadiusExeption))]
        public void FailNullRadiusAreaCircleTest()
        {
            //arrange
            double R = 0;
            //actions
            ComputeAreaShape testobj = new AreaCircleClass(R);


        }
        [TestMethod]
        public void AreaTriangleSuccessTest()
        {
            //arrange
            double a = 5;
            double b = 12;
            double c = 13;
            double expected = 30;
            //actions
            ComputeAreaShape testobj = new AreaTriangleClass(a, b, c);
            double actual = testobj.Compute();
            
            //assert
            Assert.AreEqual<double>(expected, actual);

        }
        [TestMethod]
        [ExpectedException(typeof(TriangleTypeExeption))]
        public void FailTypeAreaTriangleTest()
        {
            //arrange
            double a = 5;
            double b = 12;
            double c = 10;
           
            //actions
            ComputeAreaShape testobj = new AreaTriangleClass(a, b, c);
          
           
           

        }
        [TestMethod]
        [ExpectedException(typeof(TriangleSideExeption))]
        public void FailOneSideAreaTriangleTest()
        {
            //arrange
            double a = 10;
            double b = 0;
            double c = 5;

            //actions
            ComputeAreaShape testobj = new AreaTriangleClass(a, b, c);
           


        }
        [TestMethod]
        [ExpectedException(typeof(TriangleSideExeption))]
        public void FailSideAreaTriangleTest()
        {
            //arrange
            double a = 0;
            double b = 0;
            double c = 0;

            //actions
            ComputeAreaShape testobj = new AreaTriangleClass(a, b, c);


        }
        [TestMethod]
        [ExpectedException(typeof(TriangleSideExeption))]
        public void FailNegativeSideAreaTriangleTest()
        {
            //arrange
            double a = 10;
            double b = -12;
            double c = 5;

            //actions
            ComputeAreaShape testobj = new AreaTriangleClass(a, b, c);


        }

    }
}
