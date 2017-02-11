using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perceptron_recognition
{
    public class NeuronInput
    {
        public int x { get; set; }
        public int y { get; set; }

        public NeuronInput(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class BoundingBox
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }

        public BoundingBox() { }

        static public BoundingBox getBoundingBox(Bitmap bmp)
        {
            var bbox = new BoundingBox();
            bool foundTop = false;
            bool foundBottom = false;
            bool foundLeft = false;
            bool foundRight = false;

            for (var y = 0; y < bmp.Height; y++)
                for (var x = 0; x < bmp.Width; x++)
                {
                    if (foundTop)
                        continue;

                    var color = bmp.GetPixel(x, y);
                    if (color.ToArgb().Equals(Color.Black.ToArgb()))
                    {
                        bbox.y1 = y;
                        foundTop = true;
                    }
                }

            for (var y = bmp.Height - 1; y >= 0; y--)
            {
                for (var x = bmp.Width - 1; x >= 0; x--)
                {
                    if (foundBottom)
                        continue;

                    var color = bmp.GetPixel(x, y);
                    if (color.ToArgb().Equals(Color.Black.ToArgb()))
                    {
                        bbox.y2 = y;
                        foundBottom = true;
                    }
                }
            }

            for (var x = 0; x < bmp.Width; x++)
                for (var y = 0; y < bmp.Height; y++)
                {
                    if (foundLeft)
                        continue;

                    var color = bmp.GetPixel(x, y);
                    if (color.ToArgb().Equals(Color.Black.ToArgb()))
                    {
                        bbox.x1 = x;
                        foundLeft = true;
                    }
                }

            for (var x = bmp.Width - 1; x >= 0; x--)
            {
                for (var y = bmp.Height - 1; y >= 0; y--)
                {
                    if (foundRight)
                        continue;

                    var color = bmp.GetPixel(x, y);
                    if (color.ToArgb().Equals(Color.Black.ToArgb()))
                    {
                        bbox.x2 = x;
                        foundRight = true;
                    }
                }
            }
            

            return bbox;
        }
    }
}
