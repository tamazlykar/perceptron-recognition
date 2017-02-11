using System;
using perceptron_recognition;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace perceptron_recognition_tests
{
    [TestClass]
    public class AsserstTest
    {
        [TestMethod]
        public void getBoundingBox_Test()
        {
            var bmp = new Bitmap(10, 10);
            

            int x1 = 2,
                y1 = 3,
                x2 = 8,
                y2 = 5;

            bmp.SetPixel(x1, y1, Color.Black); // (2,3)
            bmp.SetPixel(x2, y2, Color.Black); // (8,5)
            bmp.SetPixel(x1, x2, Color.Black); // (2,8)
            bmp.SetPixel(3, 8, Color.Black); //(3,8)
            
            var bbox = BoundingBox.getBoundingBox(bmp);

            Assert.AreEqual(bbox.x1, x1);
            Assert.AreEqual(bbox.y1, y1);
            Assert.AreEqual(bbox.x2, x2);
            Assert.AreEqual(bbox.y2, x2);
        }
    }
}
