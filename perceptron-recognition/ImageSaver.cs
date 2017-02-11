using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace perceptron_recognition
{
    public class ImageSaver
    {
        private const string path = "learning";
        private const string countFile = "index.txt";
        private const string extention = ".jpg";
        private List<string> numberPath = new List<string>();
        private List<int> imageCounter = new List<int>();

        public ImageSaver()
        {
            for (var i = 0; i < 10; i++)
            {
                numberPath.Add(path + "\\" + Convert.ToString(i));
                
                var sr = new StreamReader(numberPath[i] + "\\" + countFile);
                var str = sr.ReadLine();
                imageCounter.Add(Convert.ToInt32(str));
                sr.Close();
            }
        }

        public void saveImage(Image image, int numberType)
        {
            imageCounter[numberType] += 1;

            image.Save(numberPath[numberType] + "\\" + imageCounter[numberType] + extention);
                        
            var sw = new StreamWriter(numberPath[numberType] + "\\" + countFile);
            sw.WriteLine(Convert.ToString(imageCounter[numberType]));
            sw.Close();
        }

        public List<Bitmap> getBitmaps(int numberType)
        {
            List<Bitmap> bitmaps = new List<Bitmap>();
            int counts;

            string path = numberPath[numberType] + "\\";

            var file = File.OpenRead(path + countFile);
            var sr = new StreamReader(file);
            var str = sr.ReadLine();
            counts = Convert.ToInt32(str);
            sr.Close();
            file.Close();

            for (var i = 1; i <= counts; i++)
            {
                bitmaps.Add(new Bitmap(path + Convert.ToString(i) + extention));
            }

            return bitmaps;
        }
    }
}
