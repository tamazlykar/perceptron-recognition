using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace perceptron_recognition
{
    public class ImageFunctions
    {
        /// <summary>
        /// Crops and resizes the image.
        /// </summary>
        /// <param name="img">The image to be processed</param>
        /// <param name="targetWidth">Width of the target</param>
        /// <param name="targetHeight">Height of the target</param>
        /// <param name="x1">The position x1</param>
        /// <param name="y1">The position y1</param>
        /// <param name="x2">The position x2</param>
        /// <param name="y2">The position y2</param>
        /// <param name="imageFormat">The image format</param>
        /// <returns>A cropped and resized image</returns>
        public static Image CropAndResizeImage(Image img, int targetWidth, int targetHeight, int x1, int y1, int x2, int y2, ImageFormat imageFormat)
        {
            var bmp = new Bitmap(targetWidth, targetHeight);
            Graphics g = Graphics.FromImage(bmp);

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            int width = x2 - x1;
            int height = y2 - y1;

            g.DrawImage(img, new Rectangle(0, 0, targetWidth, targetHeight), x1, y1, width, height, GraphicsUnit.Pixel);

            return bmp;

            //var memStream = new MemoryStream();
            //bmp.Save(memStream, imageFormat);
            //return Image.FromStream(memStream);
        }

        /// <summary>
        /// Resizes the image.
        /// </summary>
        /// <param name="img">The image to be resized</param>
        /// <param name="targetWidth">Width of the target</param>
        /// <param name="targetHeight">Height of the target</param>
        /// <param name="imageFormat">The image format</param>
        /// <returns>A resized image</returns>
        public static Image ResizeImage(Image img, int targetWidth, int targetHeight, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            return CropAndResizeImage(img, targetWidth, targetHeight, 0, 0, img.Width, img.Height, imageFormat);
        }

        /// <summary>
        /// Crops the image.
        /// </summary>
        /// <param name="img">The image</param>
        /// <param name="x1">The position x1.</param>
        /// <param name="y1">The position y1.</param>
        /// <param name="x2">The position x2.</param>
        /// <param name="y2">The position y2.</param>
        /// <param name="imageFormat">The image format.</param>
        /// <returns>A cropped image.</returns>
        public static Image CropImage(Image img, int x1, int y1, int x2, int y2, System.Drawing.Imaging.ImageFormat imageFormat)
        {
            return CropAndResizeImage(img, x2 - x1, y2 - y1, x1, y1, x2, y2, imageFormat);
        }

        public static List<double> convertImageToBinaryVector(Image img)
        {
            var bmp = new Bitmap(img);
            var xn = img.Width;
            var yn = img.Height;

            List<double> d = new List<double>();

            for (int y = 0; y < yn; y++)
                for (int x = 0; x < xn; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    if (c.ToArgb().Equals(Color.White.ToArgb()))
                        d.Add(-0.5);
                    else
                        d.Add(0.5);
                }

            return d;
        }
    }
}
