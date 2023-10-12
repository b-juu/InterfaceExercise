using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        int NumberOfWheels { get; set; }
        string EngineType { get; set; }
        double FuelEfficiency { get; set; }
        double VehicleWeight { get; set; }
    }
}

