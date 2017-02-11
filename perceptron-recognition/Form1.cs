using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace perceptron_recognition
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private int mouse_x;
        private int mouse_y;
        private ImageSaver imageSaver;
        private NeuralNetwork neuralNetwork;
        private int usedImgWidth;
        private int usedImgHeight;

        public Form1()
        {
            InitializeComponent();
            imageSaver = new ImageSaver();

            resetCanvas();

            usedImgWidth = 13;
            usedImgHeight = 18;

            createNeuralNetwork();
        }

        private void createNeuralNetwork()
        {
            var layers = 3;        
            var firstLayerInputsNumber = usedImgWidth * usedImgHeight;
            List<int> neuronCount = new List<int>();
            neuronCount.Add(10);
            neuronCount.Add(15);
            neuronCount.Add(10); // last layer should be equal number of recogition symbols; = 10;

            neuralNetwork = new NeuralNetwork(layers, neuronCount, firstLayerInputsNumber);
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void canvas_MouseLeave(object sender, EventArgs e)
        {
            isDrawing = false;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing)
                return;

            using (Graphics g = Graphics.FromImage(canvas.Image))
            {
                const int lineWidth = 18;
                using (SolidBrush b = new SolidBrush(Color.Black))
                    g.FillEllipse(b, new Rectangle(e.X - lineWidth/2, e.Y - lineWidth/2, lineWidth, lineWidth));
                canvas.Invalidate();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            resetCanvas();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var image = getProperImage();

            int numberType = Convert.ToInt32(tb_number_type.Text);
            imageSaver.saveImage(image, numberType);

            resetCanvas();
        }

        private void resetCanvas()
        {
            var bmp = new Bitmap(canvas.Width, canvas.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            canvas.Image = bmp;
        }

        private void btn_learn_Click(object sender, EventArgs e)
        {
            var image = getProperImage();
            var data = ImageFunctions.convertImageToBinaryVector(image);

            int numberType = Convert.ToInt32(tb_number_type.Text);
            
            List<double> expectedData = new List<double>();

            for (var i = 0; i < 10; i++)
                expectedData.Add(-0.5);

            expectedData[numberType] = 0.5;

            neuralNetwork.train(data, expectedData);

            var result = neuralNetwork.getResult();
            setResult(result);
        }

        private void btn_learn_by_data_Click(object sender, EventArgs e)
        {
            List<List<Bitmap>> images = new List<List<Bitmap>>();

            for (var i = 0; i < 2; i++)
            {
                var bitmaps = imageSaver.getBitmaps(i);
                images.Add(bitmaps);
            }

            for (var s = 0; s < 5; s++)
            {
                for (var i = 0; i < 5; i++)
                {
                    for (var type = 0; type < images.Count; type++)
                    {
                        List<double> expectedData = new List<double>();

                        for (var it = 0; it < 10; it++)
                            expectedData.Add(-0.5);

                        expectedData[type] = 0.5;

                        var data = ImageFunctions.convertImageToBinaryVector(images[type][i]);
                        neuralNetwork.train(data, expectedData);

                        var result = neuralNetwork.getResult();
                        setResult(result);
                    }
                }
            }
        }

        private Image getProperImage()
        {
            Image image = canvas.Image;

            BoundingBox bbox = BoundingBox.getBoundingBox(new Bitmap(image));

            image = ImageFunctions.CropAndResizeImage(image, usedImgWidth, usedImgHeight, bbox.x1, bbox.y1, bbox.x2, bbox.y2, ImageFormat.Bmp);
            pictureBox1.Image = image;
            image.Save("adfas.jpg");

            var data = ImageFunctions.convertImageToBinaryVector(image);
            string str = "";
            data.ForEach((val) =>
            {
                str += val.ToString() + " ";
            });

            textBox1.Text = str;

            return image;
        }

        private List<double> getProperInputVector()
        {
            var image = getProperImage();
            return ImageFunctions.convertImageToBinaryVector(image); 
        }

        private void setResult(List<double> result)
        {
            lbl_0.Text = result[0].ToString();
            lbl_1.Text = result[1].ToString();
            lbl_2.Text = result[2].ToString();
            lbl_3.Text = result[3].ToString();
            lbl_4.Text = result[4].ToString();
            lbl_5.Text = result[5].ToString();
            lbl_6.Text = result[6].ToString();
            lbl_7.Text = result[7].ToString();
            lbl_8.Text = result[8].ToString();
            lbl_9.Text = result[9].ToString();
        }

        private void btn_recognize_Click(object sender, EventArgs e)
        {
            var image = getProperImage();
            var data = ImageFunctions.convertImageToBinaryVector(image);

            var result = neuralNetwork.process(data);

            setResult(result);
        }
    }
}
