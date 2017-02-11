using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using perceptron_recognition;
using System.Collections.Generic;

namespace perceptron_recognition_tests
{
    [TestClass]
    public class ImageFunctionsTest
    {
        [TestMethod]
        public void convertImageToBinaryVector()
        {
            var bmp = new Bitmap(3, 4);

            bmp.SetPixel(0, 0, Color.Black); // 1
            bmp.SetPixel(0, 2, Color.Black); // 7
            bmp.SetPixel(1, 3, Color.Black); // 11

            List<double> vec = ImageFunctions.convertImageToBinaryVector(bmp);

            for (var i = 0; i < vec.Count; i++)
            {
                switch (i)
                {
                    case 0:
                    case 6:
                    case 10:
                        Assert.AreEqual(1, vec[i]);
                        break;
                    default:
                        Assert.AreEqual(0, vec[i]);
                        break;
                }
            }
        }
    }
}
