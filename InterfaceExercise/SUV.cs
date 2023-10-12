using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        // IVehicle members
        public int NumberOfWheels { get; set; }
        public string EngineType { get; set; }
        public double FuelEfficiency { get; set; }
        public double VehicleWeight { get; set; }

        // ICompany members
        public string CompanyLogo { get; set; }
        public string CompanyDescription { get; set; }

        // SUV-specific members
        public double CargoHoldSize { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
    }
}
