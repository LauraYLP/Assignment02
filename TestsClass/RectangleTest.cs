using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment02;


namespace TestsClass
{
    [TestFixture]
    internal class RectangleTest
    {
        [Test]
        public void GetCurrentLength_Input1_OutputValidGetRectangleLength()
        {
            //Arrange
            int length = 1;
            string expected = "The length is valid.";

            //Act
            string actual = Rectangle.GetCurrentLength(length);
            
            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void GetCurrentLength_Input5_OutputValidGetRectangleLength()
        {
            //Arrange
            int length = 5;
            string expected = "The length is valid.";

            //Act
            string actual = Rectangle.GetCurrentLength(length);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void GetCurrentLength_Input10_OutputValidGetRectangleLength()
        {
            //Arrange
            int length = 10;
            string expected = "The length is valid.";

            //Act
            string actual = Rectangle.GetCurrentLength(length);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void GetCurrentWidth_Input1_OutputValidGetRectangleWidth()
        {
            //Arrange
            int width = 1;
            string expected = "The width is valid.";

            //Act
            string actual = Rectangle.GetCurrentWidth(width);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void GetCurrentWidth_Input5_OutputValidGetRectangleWidth()
        {
            //Arrange
            int width = 5;
            string expected = "The width is valid.";

            //Act
            string actual = Rectangle.GetCurrentWidth(width);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void GetCurrentWidth_Input10_OutputValidGetRectangleWidth()
        {
            //Arrange
            int width = 10;
            string expected = "The width is valid.";

            //Act
            string actual = Rectangle.GetCurrentWidth(width);

            //Assert
            Assert.AreEqual(expected, actual);
        }





    }
}
