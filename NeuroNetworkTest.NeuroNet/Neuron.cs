using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetworkTest.NeuroNet
{
    public class Neuron
    {
        private Network _network;
        private decimal[] _weights;
        private decimal _output;
        public decimal[] Weigts
        {
            get
            {
                return _weights;
            }
        }
        public decimal Output
        {
            get
            {
                return _output;
            }
        }
        public Neuron(Network network)
        {
            _network = network;
            _weights = new decimal[_network.Inputs.Length];
            for (int i=0;i<_weights.Length;i++)
                _weights[i] = 0;
        }
        public void Process()
        {
            decimal sum = 0;
            for (int i=0;i< _network.Inputs.Length;i++)
            {
                sum += _network.Inputs[i] * _weights[i];
            }
            _output = sum;
        }
        public void HighWeights()
        {
            for (int i=0;i<_weights.Length;i++)
            {
                _weights[i] += _network.Inputs[i];
            }
        }

        public void LowWeights()
        {
            for (int i = 0; i < _weights.Length; i++)
            {
                _weights[i] -= _network.Inputs[i]/3;
                if (_weights[i] < 0)
                    _weights[i] = 0;
            }
        }
    }
}
