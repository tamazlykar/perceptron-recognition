using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perceptron_recognition
{
    public class Neuron
    {
        private List<double> inputs;
        public List<double> weights { get; private set; }
        
        private int inputsCount;

        private List<double> mul;
        private double sum;
        private double result;

        public double learningSpeed { get; set; }
        public double error { get; private set; }

        public Neuron(int inputNumber, double learningSpeed = 0.59)
        {
            inputsCount = inputNumber + 1;
            this.learningSpeed = learningSpeed;
            
            mul = new List<double>();
            for (var i = 0; i < inputsCount; i++)
                mul.Add(0);
            weights = new List<double>();

            Random r = new Random();

            for (var i = 0; i < inputsCount; i++)
            {
                weights.Add(r.NextDouble());
            }
        }

        public double process(List<double> inputs)
        {
            setInput(inputs);
            multiplyInputsWeights();
            sumMultipliedWeights();
            return getResult();
        }

        public void setInput(List<double> inputs)
        {
            this.inputs = inputs;
            this.inputs.Add(0.5);
        }

        public void multiplyInputsWeights()
        {
            for (var i = 0; i < inputsCount; i++)
            {
                mul[i] = weights[i] * inputs[i];
            }
        }

        public void sumMultipliedWeights()
        {
            sum = 0;

            for (var i = 0; i < inputsCount; i++)
            {
                sum += mul[i];
            }
        }

        public double getResult()
        {
            result = activationFunction(sum);
            return result;
        }

        private double activationFunction(double x)
        {
            return  -0.5 + (1 / (1 + Math.Exp(-1 * x))); // -0.5 - offset
        }

        private double derivative(double x)
        {
            return result * (1 - result);
        }

        public void setError(double error) 
        {
            this.error = error;
        }

        public void recalculateWeights()
        {
            for (var i = 0; i < inputsCount; i++)
            {
                var res = weights[i] + learningSpeed * error * derivative(sum) * mul[i];
                weights[i] = res;
            }
        }
    }
}
