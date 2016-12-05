using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetworkTest.NeuroNet
{
    public class Network
    {
        private decimal _coeff;
        public decimal Coeff
        {
            get
            {
                return _coeff;
            }
        }
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
            _coeff = 1;
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

            //_neurons[correcrOutputNeuronNumber].HighWeights();

            //for (int i = 0; i < Neurons.Length; i++)
            //{
            //    if (correcrOutputNeuronNumber != i)
            //    {
            //        _neurons[i].LowWeights();
            //    }

            //}

            // _coeff = _coeff * 0.99m;

            if (maxNeuronNumber != correcrOutputNeuronNumber)
            {
                _neurons[correcrOutputNeuronNumber].HighWeights();
                if (maxNeuronNumber > -1)
                {

                    _neurons[maxNeuronNumber].LowWeights();

                }
                _coeff = _coeff * 0.99m;
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
