using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perceptron_recognition
{
    public class NeuralLayer
    {
        public int neuronsCount { get; }
        private int inputsCount;
        private List<Neuron> neurons; 

        public NeuralLayer(int neuronsCount, int inputsCount)
        {
            this.neuronsCount = neuronsCount;
            this.inputsCount = inputsCount;
 
            createNeurons();
        }

        private void createNeurons()
        {
            neurons = new List<Neuron>();

            for (var i = 0; i < neuronsCount; i++)
            {
                neurons.Add(new Neuron(inputsCount));
            }
        }

        public List<double> process(List<double> data)
        {
            List<double> result = new List<double>();

            for (var i = 0; i < neuronsCount; i++)
            {
                var res = neurons[i].process(data);
                result.Add(res);
            }

            return result;                
        }

        public List<double> getResult()
        {
            List<double> result = new List<double>();

            for (var i = 0; i < neuronsCount; i++)
                result.Add(neurons[i].getResult());

            return result;
        }

        public void setErrors(List<double> error)
        {
            for (var i = 0; i < neuronsCount; i++)
                neurons[i].setError(error[i]);
        }

        public List<double> getNextLayerError()
        {            
            List<double> result = new List<double>();

            for (var nextLayerNeuronNumber = 0; nextLayerNeuronNumber < inputsCount; nextLayerNeuronNumber++)
            {
                double sumError = 0;
                for (var currLayerNeuronNumber = 0; currLayerNeuronNumber < neuronsCount; currLayerNeuronNumber++)
                {
                    sumError += neurons[currLayerNeuronNumber].weights[nextLayerNeuronNumber] * neurons[currLayerNeuronNumber].error;
                }

                result.Add(sumError);
            }

            return result;
        }

        public void recalculateWeights()
        {
            for (var i = 0; i < neuronsCount; i++)
            {
                neurons[i].recalculateWeights();
            }
        }
    }
}
