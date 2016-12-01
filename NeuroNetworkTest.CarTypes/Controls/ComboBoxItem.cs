using NeuroNetworkTest.CarTypes.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetworkTest.CarTypes.Controls
{
    public class ComboBoxItem
    {
        public VehicleType Id { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
