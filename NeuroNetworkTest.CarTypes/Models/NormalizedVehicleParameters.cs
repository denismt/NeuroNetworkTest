using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroNetworkTest.CarTypes.Models
{
    public class NormalizedVehicleParameters
    {
        public NormalizedVehicleParameters(decimal weight, decimal power, decimal capacity, decimal carrying)
        {
            if (weight <= 0.5m)
                Weight = 0;
            else
                if (weight <= 1)
                    Weight = 0.25m;
                else
                    if (weight <= 2)
                        Weight = 0.5m;
                    else
                        if (weight <= 5)
                            Weight = 0.75m;
                        else
                            Weight = 1;
            if (power <= 20)
                Power = 0;
            else
                if (power <= 50)
                Power = 0.25m;
                else
                    if (power <= 100)
                        Power = 0.5m;
                    else
                        if (power <= 200)
                            Power = 0.75m;
                        else
                            Power = 1;
            if (capacity <= 2)
                Capacity = 0;
            else
                if (capacity <= 5)
                    Capacity = 0.25m;
                 else
                    if (capacity <= 10)
                        Capacity = 0.5m;
                     else
                        if (capacity <= 20)
                            Capacity = 0.75m;
                        else
                            Capacity = 1;
            if (carrying <= 2)
                Carrying = 0;
            else
                if (carrying <= 5)
                    Carrying = 0.25m;
                else
                    if (carrying <= 10)
                        Carrying = 0.5m;
                    else
                        if (carrying <= 20)
                            Carrying = 0.75m;
                        else
                            Carrying = 1;

        }
        public decimal Weight { get; }
        public decimal Power { get; }
        public decimal Capacity { get; }
        public decimal Carrying { get; }
    }
}
