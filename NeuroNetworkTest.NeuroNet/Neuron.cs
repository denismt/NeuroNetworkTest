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
        private decimal _maxValue;
        private decimal _activationLevel;
        public decimal ActivationLevel
        {
            get
            {
                return _activationLevel;
            }
        }
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
            _activationLevel = 0;
            _weights = new decimal[_network.Inputs.Length];
            _maxValue = 0;
            Random random = new Random();
            for (int i = 0; i < _weights.Length; i++)
                //_weights[i] = ((decimal)random.Next(9)+1)/100;
                _weights[i] = 0;
        }
        public void Process()
        {
            decimal sum = 0;
            for (int i=0;i< _network.Inputs.Length;i++)
            {
                sum += _network.Inputs[i] * _weights[i];
            }

            if (sum < 0)
                sum = 0;
            else
            if (sum >= 1)
                sum = 1;

            //if (sum < 0m)
            //    sum = 0;
            //else
            //    sum = 1;

            //sum = (decimal)(1 / (1 + Math.Exp((double)(0m - sum))));

            _output = sum;
            if (_maxValue<sum)
                _maxValue=sum;
            if (_maxValue!=0)
                _activationLevel = sum / _maxValue * 100;
        }
        public void HighWeights()
        {
            for (int i=0;i<_weights.Length;i++)
            {
                _weights[i] += (1-_output)*_network.Inputs[i]*_network.Coeff;
                //if (_weights[i] < 0)
                    //_weights[i] = 0;
            }
        }

        public void LowWeights()
        {
            for (int i = 0; i < _weights.Length; i++)
            {
                //if (_output >= 0.3m)
                //{
                _weights[i] -= _output * _network.Inputs[i] * _network.Coeff;
                    //if (_weights[i] < 0)
                        //_weights[i] = 0;
                //}
            }
        }
    }
}
