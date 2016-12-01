using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetworkTest.NeuroNet
{
    public class Network
    {
        private Neuron[] _neurons;
        public Neuron[] Neurons
        {
            get
            {
                return _neurons;
            }
        }
        public decimal[] Inputs { get; }
        public Network(int inputsLength,int outputsLength)
        {
            Inputs = new decimal[inputsLength];
            _neurons = new Neuron[outputsLength];
            for (int i=0;i<outputsLength;i++)
            {
                _neurons[i] = new Neuron(this);
            }
        }
        public void Train(int correcrOutputNeuronNumber)
        {
            decimal maxValue = 0;
            int maxNeuronNumber = -1;

            for(int i=0; i<_neurons.Length;i++)
            {
                Neuron neuron = _neurons[i];
                neuron.Process();
                if (neuron.Output>maxValue)
                {
                    maxValue = neuron.Output;
                    maxNeuronNumber = i;
                }
            }

            if (maxNeuronNumber != correcrOutputNeuronNumber)
            {
                _neurons[correcrOutputNeuronNumber].HighWeights();
                if (maxNeuronNumber > -1)
                {
                    _neurons[maxNeuronNumber].LowWeights();
                }
            }
        }

        public int GetResult()
        {
            decimal maxValue = 0;
            int maxNeuronNumber = -1;

            for (int i = 0; i < _neurons.Length; i++)
            {
                Neuron neuron = _neurons[i];
                neuron.Process();
                if (neuron.Output > maxValue)
                {
                    maxValue = neuron.Output;
                    maxNeuronNumber = i;
                }
            }

            return maxNeuronNumber;
        }
    }
}
