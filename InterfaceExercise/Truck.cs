using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string EngineType { get; set; }
        public double FuelEfficiency { get; set; }
        public double VehicleWeight { get; set; }

        public string CompanyLogo { get; set; }
        public string CompanyDescription { get; set; }

        public double BedSize { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
    }
}
