using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitDemonstration;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TestClass
{
    public class TriangleTest
    {
        [TestFixture]

        public class TriangleTest1
        {
            [Test]

            public void validTriangle() 
            {
                //Sachin's Test case

                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;   
                int thirdAngle = 60;
                String expected = "The triangle is valid.";

                //Act
                String actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);    

                //Assert
                ClassicAssert.AreEqual(expected, actual);   

            }
        }
    }
}
