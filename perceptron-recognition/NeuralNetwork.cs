using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perceptron_recognition
{
    public class NeuralNetwork
    {
        private int numLayers;
        private List<NeuralLayer> layers;
        private List<double> result;

        public NeuralNetwork(int numLayers, List<int> neuronCount, int firstLayerInputNum)
        {
            this.numLayers = numLayers;
            layers = new List<NeuralLayer>();

            if (numLayers != neuronCount.Count)
            {
                Console.WriteLine("Error. Layers count doesn't match");
                return;
            }

            layers.Add(new NeuralLayer(neuronCount[0], firstLayerInputNum));

            for (var i = 1; i < neuronCount.Count; i++)
            {
                var previousLayer = layers[layers.Count - 1];
                layers.Add(new NeuralLayer(neuronCount[i], previousLayer.neuronsCount));
            }
        }

        public List<double> process(List<double> data)
        {
            List<double> result = layers[0].process(data);

            for (var i = 1; i < numLayers; i++)
            {
                result = layers[i].process(result);
            }

            return result;
        }

        public void train(List<double> processedData, List<double> expectedData)
        {
            var result = process(processedData);
            this.result = result;

            if (result.Count != expectedData.Count)
            {
                Console.WriteLine("Error. Wrong params in training set");
            }
            
            setErrors(result, expectedData);

            recalculateWeights();
        }
        
        private void setErrors(List<double> result, List<double> expectedData)
        {
            List<double> lastLayerError = new List<double>();
            for (var i = 0; i < result.Count; i++)
            {
                lastLayerError.Add( (expectedData[i] - result[i]));
            }

            layers[layers.Count - 1].setErrors(lastLayerError);

            for (var i = layers.Count - 1; i >= 1; i--)
            {
                var error = layers[i].getNextLayerError();
                layers[i - 1].setErrors(error);
            }
        }

        private void recalculateWeights()
        {
            for (var i = 0; i < numLayers; i++)
            {
                layers[i].recalculateWeights();
            }
        }

        public List<double> getResult()
        {
            return result;
        }
    }
}
